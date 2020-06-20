using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Net.Sockets;

namespace MEConfigurationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var configRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false)
                .AddIniFile("config.ini", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .AddCommandLine(args)
                .Build();
            Console.WriteLine("Press Ctrl+C to stop. Enter to iterate configuration read one more time.");
            while (true)
            {
                Console.WriteLine($"Hello {configRoot["Greetings:Name"]}");
                Console.ReadLine();
            }
        }
    }
}
