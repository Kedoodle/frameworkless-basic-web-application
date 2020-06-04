namespace FrameworklessBasicWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var server = new Server(8080);
            server.Start();
            
            while (true)
            {
                server.ProcessRequest();
            }
        }
    }
}
