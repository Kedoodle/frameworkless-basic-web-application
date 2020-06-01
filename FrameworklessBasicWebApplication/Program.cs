using System;
using System.Net;

namespace FrameworklessBasicWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var server = new HttpListener();
            server.Prefixes.Add("http://localhost:8080/");
            server.Start();
            while (true)
            {
                var context = new Context(server.GetContext());  // Gets the request
                var handler = new BasicRequestHandler(context, Console.Out);
                handler.LogRequest();
                handler.WriteResponse();
            }
            server.Stop();  // never reached...
        }
    }
}