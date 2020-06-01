using System;

namespace FrameworklessBasicWebApplication
{
    public static class GreetingFormatter
    {
        public static string CreateGreeting(string user, DateTime systemTime)
        {
            var time = $"{systemTime:h:mmtt}".ToLower();
            var date = $"{systemTime:d MMMM yyyy}";
            return $"Hello {user} - the time on the server is {time} on {date}";
        }
    }
}
