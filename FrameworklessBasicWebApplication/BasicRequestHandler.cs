using System;
using System.IO;

namespace FrameworklessBasicWebApplication
{
    public class BasicRequestHandler
    {
        private readonly TextWriter _logWriter;
        private readonly IRequest _request;
        private readonly IResponse _response;

        public BasicRequestHandler(IContext context, TextWriter logWriter)
        {
            _logWriter = logWriter;
            _request = context.Request;
            _response = context.Response;
        }
        
        public void LogRequest()
        {
            _logWriter.WriteLine($"{_request.HttpMethod} {_request.Url}");
        }

        public void WriteResponse()
        {
            const string user = "Keddy"; 
            var greeting = GreetingFormatter.CreateGreeting(user, DateTime.Now);
            var buffer = System.Text.Encoding.UTF8.GetBytes(greeting);
            
            _response.ContentLength64 = buffer.Length;
            _response.OutputStream.Write(buffer, 0, buffer.Length);
            _response.OutputStream.Close();
        }
    }
}
