using System;
using System.Net;

namespace FrameworklessBasicWebApplication
{
    public class Request : IRequest
    {
        public Request(HttpListenerRequest request)
        {
            HttpMethod = request.HttpMethod;
            Url = request.Url;
        }
        
        public string HttpMethod { get; }
        public Uri Url { get; }
    }
}