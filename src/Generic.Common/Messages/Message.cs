using System;

namespace Generic.Common.Messages
{
    public sealed record Message
    {
        public Message(Guid messageId, string data, DateTime timestamp, MessageTypes type)
        {
            Data = data;
            MessageId = messageId;
            Timestamp = timestamp;
            Type = type;
        }

        public string Data { get; init; }

        public Guid MessageId { get; init; }

        public DateTime Timestamp { get; init; }

        public MessageTypes Type { get; init; }
    }
}