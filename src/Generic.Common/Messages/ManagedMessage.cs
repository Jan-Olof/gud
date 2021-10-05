using System;

namespace Generic.Common.Messages
{
    public sealed record ManagedMessage<T> : Message
    {
        private ManagedMessage(Guid messageId, T data, DateTime timestamp, MessageTypes type)
            : base(messageId, timestamp, type) =>
                Data = data;

        public T Data { get; init; }

        public static ManagedMessage<T> Create(Guid messageId, T data, DateTime timestamp, MessageTypes type) =>
            new(messageId, data, timestamp, type);
    }
}