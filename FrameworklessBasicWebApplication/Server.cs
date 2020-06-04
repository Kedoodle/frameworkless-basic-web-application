using System;
using System.Net;

namespace FrameworklessBasicWebApplication
{
    public class Server
    {
        private readonly HttpListener _listener;

        public Server(int port)
        {
            _listener = new HttpListener();
            _listener.Prefixes.Add($"http://localhost:{port}/");
        }

        public void Start()
        {
            _listener.Start();
        }

        public void ProcessRequest()
        {
            var context = new Context(_listener.GetContext());
            var handler = new BasicRequestHandler(context, Console.Out);
                
            handler.LogRequest();
            handler.WriteResponse();
        }
    }
}
