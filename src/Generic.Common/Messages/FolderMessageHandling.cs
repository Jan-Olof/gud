using Generic.Common.Helpers;
using Generic.Daemon.Config;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using Unit = System.ValueTuple;

namespace Generic.Common.Messages
{
    public class FolderMessageHandling : MessageHandling
    {
        private readonly ILogger _logger;
        private readonly MessageHandler _msgHandlerConfig;
        private readonly Func<RawMessage, Unit> _processMessage;

        public FolderMessageHandling(ILogger logger, MessageHandler msgHandlerConfig, Func<RawMessage, Unit> processMessage)
        {
            _logger = logger;
            _msgHandlerConfig = msgHandlerConfig;
            _processMessage = processMessage;
        }

        public override void StartMonitoring() =>
            MonitorFiles.MonitorFolder(_msgHandlerConfig.Folder, NewMessage);

        private void NewMessage(object source, FileSystemEventArgs e) =>
            File.ReadAllText(e.FullPath)
                .Deserialize<RawMessage>()
                .Match(e => e.Log(_logger), m => _processMessage(m));
    }
}