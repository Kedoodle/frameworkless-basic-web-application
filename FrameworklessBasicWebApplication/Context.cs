using System.Net;

namespace FrameworklessBasicWebApplication
{
    public class Context : IContext
    {
        public Context(HttpListenerContext context)
        {
            Request = new Request(context.Request);
            Response = new Response(context.Response);
        }

        public IRequest Request { get; }
        public IResponse Response { get; }
    }
}