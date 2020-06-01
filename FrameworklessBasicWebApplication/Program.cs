using System;
using System.Net;

namespace FrameworklessBasicWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var server = new HttpListener();
            server.Prefixes.Add("http://localhost:8080/");
            server.Start();
            while (true)
            {
                var context = server.GetContext();  // Gets the request
                Console.WriteLine($"{context.Request.HttpMethod} {context.Request.Url}");

                var greeting = GreetingFormatter.CreateGreeting("Keddy", DateTime.Now);
                var buffer = System.Text.Encoding.UTF8.GetBytes(greeting);
                context.Response.ContentLength64 = buffer.Length;
                context.Response.OutputStream.Write(buffer, 0, buffer.Length);  // forces send of response
            }
            server.Stop();  // never reached...
        }
    }
}