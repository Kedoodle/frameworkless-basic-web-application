using System.IO;
using System.Net;

namespace FrameworklessBasicWebApplication
{
    public class Response : IResponse
    {
        public Response(HttpListenerResponse response)
        {
            OutputStream = response.OutputStream;
        }
        
        public Stream OutputStream { get; }
        public int ContentLength64 { get; set; }
    }
}