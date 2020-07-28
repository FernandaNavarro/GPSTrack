namespace Client
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

    public class ClientTcpConnection
    {
        public TcpClient TcpClient { get; private set; }
        public NetworkStream Stream { get; private set; }
        public Thread ReadThread { get; private set; }
        public StreamWriter Writer { get; private set; }

        public delegate void DataCarrier(string data);
        public event DataCarrier OnDataRecieved;

        public delegate void DisconnectNotify();
        public event DisconnectNotify OnDisconnect;

        public delegate void ErrorCarrier(Exception e);
        public event ErrorCarrier OnError;
        
        public string IpAddress { get; set; }
        public int Port { get; set; }
        public bool IsZipFormat { get; set; }
        public bool IsSuntech { get; set; }

        public ClientTcpConnection()
        {
            //Default values
            IpAddress = "127.0.0.1";
            Port = 1997;
            IsZipFormat = true;
            IsSuntech = true;
        }

        public bool Load()
        {
            OnDataRecieved += MessageReceived;

            if (!ToConnect(IpAddress, Port))
            {
                Console.WriteLine("Error conectando con el servidor");
                return false;
            }

            return true;
        }

        public bool ToConnect(string ipAddress, int port)
        {
            try
            {
                TcpClient = new TcpClient();
                TcpClient.Connect(IPAddress.Parse(ipAddress), port);
                Stream = TcpClient.GetStream();
                Writer = new StreamWriter(Stream);
                ReadThread = new Thread(ToListen);
                ReadThread.Start();
                return true;
            }
            catch (Exception e)
            {
                OnError?.Invoke(e);
                return false;
            }
        }

        private void ToListen()
        {
            var reader = new StreamReader(Stream);
            var charBuffer = new List<int>();

            do
            {
                try
                {
                    if (reader.EndOfStream)
                    {
                        break;
                    }
                    int charCode = reader.Read();
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
                        for (int i = 0; i < charBuffer.Count; i++)
                        {
                            chars[i] = Convert.ToChar(charBuffer[i]);
                        }
                        var message = new string(chars);
                        OnDataRecieved(message);
                    }
                    charBuffer.Clear();
                }
                catch (Exception e)
                {
                    OnError?.Invoke(e);
                    break;
                }
            } while (true);
            OnDisconnect?.Invoke();
        }

        private void WriteMsg(string msg)
        {
            try
            {
                Writer.Write(msg + "\0");
                Writer.Flush();
            }
            catch (Exception e)
            {
                OnError?.Invoke(e);
            }
        }
        
        private static void MessageReceived(string data)
        {
            //here call or put the logic for to clasificate the message and display it.
            Console.WriteLine(data);
        }

        public void SendMessage(string message)
        {
            if (TcpClient.Connected)
            {
                WriteMsg(message);
            }
        }
    }
}
