namespace Server
{
    using Server.Helpers;

    public class ServerProgram
    {
        public static void Main(string[] args)
        {
            ServerTcpConnection serverTcp = new ServerTcpConnection();
            serverTcp.IpAddress = "127.0.0.1";
            serverTcp.Port = 1997;
            serverTcp.IsZipFormat = true;
            serverTcp.IsSuntech = true;
            serverTcp.Load();
        }
    }
}
