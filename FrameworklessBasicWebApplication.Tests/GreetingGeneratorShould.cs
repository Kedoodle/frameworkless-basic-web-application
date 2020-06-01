using System;
using Xunit;

namespace FrameworklessBasicWebApplication.Tests
{
    public class GreetingGeneratorShould
    {
        [Fact]
        public void FormatGreetingGivenDateTime()
        {
            var systemTime = new DateTime(2018, 3, 14, 22, 48, 0);
            const string expectedGreeting = "Hello Bob - the time on the server is 10:48pm on 14 March 2018";

            var actualGreeting = GreetingFormatter.CreateGreeting("Bob", systemTime);
            
            Assert.Equal(expectedGreeting, actualGreeting);
        }
    }
}
