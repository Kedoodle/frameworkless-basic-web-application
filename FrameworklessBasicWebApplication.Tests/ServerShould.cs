using System.Net;
using System.Net.Http;
using Xunit;

namespace FrameworklessBasicWebApplication.Tests
{
    public class ServerShould
    {
        [Fact]
        public void GreetUserUponGetRequest()
        {
            const int post = 8000;
            var server = new Server(post);
            server.Start();
            
            var client = new HttpClient();
            var response = client.GetAsync($"http://localhost:{post}/");
            server.ProcessRequest();
            
            Assert.Equal(HttpStatusCode.OK, response.Result.StatusCode);
            Assert.Contains(" - the time on the server is ", response.Result.Content.ReadAsStringAsync().Result);
        }
    }
}
