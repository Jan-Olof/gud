using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace Generic.Daemon
{
    internal static class Program
    {
        private static async Task Main(string[] args)
        {
            Console.WriteLine("The daemon has started...");
            await Startup.CreateBuilder().RunConsoleAsync();
        }
    }
}