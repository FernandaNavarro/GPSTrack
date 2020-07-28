namespace Server.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class ServerTcpConnection
    {
        public TcpClient tcpClient;
        public StreamReader streamReader;
        public StreamWriter streamWriter;
        public Thread readThread;

        public delegate void ErrorCarrier(Exception e);
        public event ErrorCarrier OnError;

        public delegate void ClientCarrier(ServerTcpConnection tcpConnection);
        public event ClientCarrier OnClientConnected;
        public event ClientCarrier OnClientDisconnected;

        public delegate void DataRecieved(ServerTcpConnection tcpConnection, string data);
        public event DataRecieved OnDataRecieved;

        private TcpListener _tcpListener;
        private Thread _acceptThread;
        private List<ServerTcpConnection> connectedClients = new List<ServerTcpConnection>();

        public string IpAddress { get; set; }
        public int Port { get; set; }
        public bool IsZipFormat { get; set; }
        public bool IsSuntech { get; set; }

        public ServerTcpConnection()
        {
            IpAddress = "127.0.0.1";
            Port = 1997;
            IsZipFormat = true;
            IsSuntech = true;
        }

        public ServerTcpConnection(TcpClient client)
        {
            var ns = client.GetStream();
            streamReader = new StreamReader(ns);
            streamWriter = new StreamWriter(ns);
            tcpClient = client;
        }

        public void Load()
        {
            OnDataRecieved += MessageRecieved;
            OnClientConnected += ConnectioRecieved;
            OnClientDisconnected += ConnectionClosed;

            ClientsListener(IpAddress, Port);
        }

        private void ClientsListener(string ipAddress, int port)
        {
            try
            {
                _tcpListener = new TcpListener(IPAddress.Parse(ipAddress), port);
                _tcpListener.Start();
                _acceptThread = new Thread(AccepClients);
                _acceptThread.Start();
            }
            catch (Exception e)
            {
                Console.Write(e.Message.ToString());
            }
        }

        private void AccepClients()
        {
            do
            {
                try
                {
                    Console.WriteLine("Esperando una conexión... ");
                    var connection = _tcpListener.AcceptTcpClient();
                    Console.WriteLine("Conectado!");
                    var srvClient = new ServerTcpConnection(connection)
                    {
                        readThread = new Thread(ReadData)
                    };
                    srvClient.readThread.Start(srvClient);

                    OnClientConnected?.Invoke(srvClient);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message.ToString());
                }

            } while (true);
        }

        private void ReadData(object client)
        {
            var cli = client as ServerTcpConnection;
            var charBuffer = new List<int>();

            do
            {
                try
                {
                    if (cli == null)
                    {
                        break;
                    }
                    if (cli.streamReader.EndOfStream)
                    {
                        break;
                    }
                    int charCode = cli.streamReader.Read();
                    if (charCode == -1)
                    {
                        break;
                    }
                    if (charCode != 0)
                    {
                        charBuffer.Add(charCode);
                        continue;
                    }
                    if (OnDataRecieved != null)
                    {
                        var chars = new char[charBuffer.Count];
                        //Convert  all the characters codes to their representable characters
                        for (int i = 0; i < charBuffer.Count; i++)
                        {
                            chars[i] = Convert.ToChar(charBuffer[i]);
                        }
                        //Convert the character array to string
                        var message = new string(chars);

                        //Invoke the event
                        OnDataRecieved(cli, message);
                    }
                    charBuffer.Clear();
                }
                catch (IOException)
                {
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message.ToString());

                    break;
                }

            } while (true);

            OnClientDisconnected?.Invoke(cli);
        }

        private void ConnectionClosed(ServerTcpConnection tcpConnection)
        {
            lock (connectedClients)
            {
                if (connectedClients.Contains(tcpConnection))
                {
                    int clientIndex = connectedClients.IndexOf(tcpConnection);
                    connectedClients.RemoveAt(clientIndex);
                }
            }
        }

        private void ConnectioRecieved(ServerTcpConnection tcpConnection)
        {
            lock (connectedClients)
            {
                if (!connectedClients.Contains(tcpConnection))
                {
                    connectedClients.Add(tcpConnection);
                }

            }
        }

        private void MessageRecieved(ServerTcpConnection tcpConnection, string data)
        {
            //here call or put the logic for to clasificate the message and display it.
            if (IsSuntech)
            {
                if (IsZipFormat)
                {
                    new SuntechServices().DeserializeZip(data);
                }
            }
        }

        private void WriteMsg(string msg)
        {
            try
            {
                streamWriter.Write(msg + "\0");
                streamWriter.Flush();
            }
            catch (Exception e)
            {
                OnError?.Invoke(e);
            }
        }

        public void SendMessage(string message)
        {
            WriteMsg(message);
        }
    }
}
