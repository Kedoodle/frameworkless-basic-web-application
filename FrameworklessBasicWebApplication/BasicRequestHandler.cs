using System;
using System.IO;
using System.Net;

namespace FrameworklessBasicWebApplication
{
    public class BasicRequestHandler
    {
        private readonly IContext _context;
        private readonly TextWriter _logWriter;

        public BasicRequestHandler(IContext context, TextWriter logWriter)
        {
            _context = context;
            _logWriter = logWriter;
        }
        
        public void LogRequest()
        {
            _logWriter.WriteLine($"{_context.Request.HttpMethod} {_context.Request.Url}");
        }

        public void WriteResponse()
        {
            const string user = "Keddy";
            var greeting = GreetingFormatter.CreateGreeting(user, DateTime.Now);
            var buffer = System.Text.Encoding.UTF8.GetBytes(greeting);
            
            _context.Response.ContentLength64 = buffer.Length;
            _context.Response.OutputStream.Write(buffer, 0, buffer.Length);  // forces send of response
        }
    }
}
