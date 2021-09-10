using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Generic.Daemon
{
    public class Daemon : BackgroundService
    {
        private readonly ILogger _logger;

        public Daemon(ILogger<Daemon> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Daemon is running ExecuteAsync.");
            _logger.LogDebug("Extra debug logging is shown.");

            await Task.CompletedTask;
        }

        public override void Dispose()
        {
            base.Dispose();
            GC.SuppressFinalize(this);
            _logger.LogInformation("Daemon is disposed.");
        }
    }
}