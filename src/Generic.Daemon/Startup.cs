using Generic.Common.Helpers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Generic.Daemon
{
    public static class Startup
    {
        public static IHostBuilder CreateBuilder() =>
            new HostBuilder()
                .ConfigureServices(services =>
                {
                    services.AddHostedService<Daemon>();
                })
                .ConfigureLogging(logging =>
                {
                    logging.AddConfiguration(ConfigurationHelper.GetConfiguration().GetSection("Logging"));
                    logging.AddConsole();
                });
    }
}