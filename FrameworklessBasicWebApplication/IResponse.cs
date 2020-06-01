using System.IO;

namespace FrameworklessBasicWebApplication
{
    public interface IResponse
    {
        public Stream OutputStream { get; }
        public int ContentLength64 { get; set; }
    }
}
