using System;
using System.IO;
using Moq;
using Xunit;

namespace FrameworklessBasicWebApplication.Tests
{
    public class BasicRequestHandlerShould
    {
        [Fact]
        public void LogRequestToConsole()
        {
            var mockRequest = Mock.Of<IRequest>(m => 
                m.HttpMethod == "DummyMethod" &&
                m.Url == new Uri("http://localhost/"));
            var mockContext = Mock.Of<IContext>(m => m.Request == mockRequest);
            var mockLogWriter = Mock.Of<TextWriter>();
            var basicRequestHandler = new BasicRequestHandler(mockContext, mockLogWriter);

            basicRequestHandler.LogRequest();
            
            Mock.Get(mockLogWriter).Verify(m => m.WriteLine("DummyMethod http://localhost/"), Times.Once);
        }

        [Fact]
        public void WriteResponseToOutputStream()
        {
            var mockStream = Mock.Of<Stream>();
            var mockResponse = Mock.Of<IResponse>(m => m.OutputStream == mockStream);
            var mockContext = Mock.Of<IContext>(m => m.Response == mockResponse);
            var mockLogWriter = Mock.Of<TextWriter>();
            var basicRequestHandler = new BasicRequestHandler(mockContext, mockLogWriter);

            basicRequestHandler.WriteResponse();
            
            Mock.Get(mockStream).Verify(m => m.Write(It.IsAny<byte[]>(), 0, It.IsAny<int>()), Times.Once);
        }
    }
}