using Generic.Common.Helpers;
using Generic.Common.Messages;
using Generic.Core;
using Generic.Daemon.Config;
using Microsoft.Extensions.Configuration;
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

        public override void Dispose()
        {
            base.Dispose();
            GC.SuppressFinalize(this);
            _logger.LogInformation("Daemon is disposed.");
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Daemon is running ExecuteAsync.");
            _logger.LogDebug("Extra debug logging is shown.");

            var msgHandlerConfig = ConfigurationHelper.GetConfiguration().GetSection("MessageHandler").Get<MessageHandler>();
            if (msgHandlerConfig == null) throw new ArgumentNullException("MessageHandler is null.");

            MessageHandling
                .GetHandler(
                    _logger,
                    msgHandlerConfig,
                    ProcessMessage.Process(
                        () => DateTime.UtcNow,
                        () => Guid.NewGuid()))
                .StartMonitoring();

            await Task.CompletedTask;
        }
    }
}