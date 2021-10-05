using System;

namespace Generic.Common.Messages
{
    public sealed record RawMessage : Message
    {
        public RawMessage(Guid messageId, string data, DateTime timestamp, MessageTypes type)
            : base(messageId, timestamp, type) =>
                Data = data;

        public string Data { get; init; }
    }
}