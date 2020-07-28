namespace Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class ClientProgram
    {
        public static string ExampleZip = "81003160000000013FFFFF1E01000E01100B110825270000004F01C20000000E1402B3E39B07902793183B198F0A010508010201EC";
        public static string ExampleNormal = "STT;6000000001;3FFFFF;30;1.0.14;1;20161117;08:37:39;0000004F;450;0;0014;20;+37.479323;+126.887827;62.03;65.43;10;1;00000101;00001000;1;2;0492";

        public static void Main(string[] args)
        {
            ClientTcpConnection clientTcp = new ClientTcpConnection();
            clientTcp.IpAddress = "127.0.0.1";
            clientTcp.Port = 1997;
            clientTcp.IsZipFormat = true;
            clientTcp.IsSuntech = true;
            if (clientTcp.Load())
            {
                for (int i = 0; i < 10; i++)
                {
                    clientTcp.SendMessage(ExampleZip);
                    TimeSpan timeout = new TimeSpan(0, 0, 5);
                    Thread.Sleep(timeout);
                }
            }
            
            Console.ReadKey();
        }
    }
}
