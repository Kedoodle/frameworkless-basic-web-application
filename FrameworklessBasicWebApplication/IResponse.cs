using System.IO;

namespace FrameworklessBasicWebApplication
{
    public interface IResponse
    {
        public Stream OutputStream { get; }
        public long ContentLength64 { set; }
    }
}
