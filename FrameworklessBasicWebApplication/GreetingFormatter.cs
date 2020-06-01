using System;
using System.Collections.Generic;

namespace FrameworklessBasicWebApplication
{
    public static class GreetingFormatter
    {
        public static IEnumerable<char> CreateGreeting(string user, DateTime systemTime)
        {
            var time = $"{systemTime:hh:mmtt}".ToLower();
            var date = $"{systemTime:dd MMMM yyyy}";
            return $"Hello {user} - the time on the server is {time} on {date}";
        }
    }
}
