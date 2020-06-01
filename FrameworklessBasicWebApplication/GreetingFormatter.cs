using System;

namespace FrameworklessBasicWebApplication
{
    public static class GreetingFormatter
    {
        public static string CreateGreeting(string user, DateTime dateTime)
        {
            var time = $"{dateTime:h:mmtt}".ToLower();
            var date = $"{dateTime:d MMMM yyyy}";
            
            return $"Hello {user} - the time on the server is {time} on {date}";
        }
    }
}
