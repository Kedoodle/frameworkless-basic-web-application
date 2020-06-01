using System;

namespace FrameworklessBasicWebApplication
{
    public interface IRequest
    {
        public string HttpMethod { get; }
        public Uri Url { get; }
    }
}
