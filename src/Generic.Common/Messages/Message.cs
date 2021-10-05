using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Common.Messages
{
    public abstract record Message
    {
        public Message(Guid messageId, DateTime timestamp, MessageTypes type)
        {
            MessageId = messageId;
            Timestamp = timestamp;
            Type = type;
        }

        public Guid MessageId { get; init; }

        public DateTime Timestamp { get; init; }

        public MessageTypes Type { get; init; }
    }
}