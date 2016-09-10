using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello From Main!");
            
            var host = new WebHostBuilder()
                        .UseKestrel()      
                        .UseStartup<Startup>()                                                                           
                        .Build();

            host.Run();

        }
    }
}
