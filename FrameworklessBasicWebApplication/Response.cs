using System.IO;
using System.Net;

namespace FrameworklessBasicWebApplication
{
    public class Response : IResponse
    {
        public Response(HttpListenerResponse response)
        {
            ContentLength64 = response.ContentLength64;
            OutputStream = response.OutputStream;
        }

        public Stream OutputStream { get; }
        public long ContentLength64 { get; set; }
    }
}
