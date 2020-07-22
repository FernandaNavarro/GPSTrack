namespace Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static TcpConnection connection = new TcpConnection();
        public static string IPADDRESS = "127.0.0.1";
        public const int port = 1997;

        public static void Main(string[] args)
        {
            Load();
        }

        private static void Load()
        {
            connection.OnDataRecieved += MessageReceived;

            if (!connection.ToConnect(IPADDRESS,port))
            {
                Console.WriteLine("Error conectando con el servidor");
                return;
            }

            if (connection.TcpClient.Connected)
            {
                for (int i = 0; i < 10; i++)
                {
                    connection.SendMessage("hola");
                }
            }
        }

        private static void MessageReceived(string data)
        {
            //here call or put the logic for to clasificate the message and display it.
            if (data == "StatusReport")
            {
                
            }
        }

        private static void displayData()
        {
            throw new NotImplementedException();
        }
    }
}
