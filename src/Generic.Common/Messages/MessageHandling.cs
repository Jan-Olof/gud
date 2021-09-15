using Generic.Daemon.Config;
using Microsoft.Extensions.Logging;
using System;
using Unit = System.ValueTuple;

namespace Generic.Common.Messages
{
    public abstract class MessageHandling
    {
        public abstract void StartMonitoring();

        public static MessageHandling GetHandler(ILogger logger, MessageHandler msgHandlerConfig, Func<Message, Unit> processMessage) =>
            new FolderMessageHandling(logger, msgHandlerConfig, processMessage);
    }
}