using System;

namespace Generic.Core.Requests
{
    public abstract record Request
    {
        public Guid MessageId { get; init; }

        public Request Create(Guid messageId) =>
            this with { MessageId = messageId };
    }
}