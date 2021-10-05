using Generic.Common.Events;
using Generic.Common.Helpers;
using Generic.Common.Messages;
using Generic.Core.Commands;
using LaYumba.Functional;
using System;

namespace Generic.Core
{
    public static class MessageMapping
    {
        public static Exceptional<Message> CreateManagedMessage(this RawMessage message) =>
            message.Type switch
            {
                MessageTypes.AddRequested => MapToManaged<AddRequested>(message),
                _ => new Exception($"MessageType {message.Type} not supported.")
            };

        private static Exceptional<Message> MapToManaged<T>(RawMessage msg) where T : Event
        {
            return msg.Data.Deserialize<T>()
                .Map(data => (Message)ManagedMessage<T>.Create(msg.MessageId, data, msg.Timestamp, msg.Type));
        }
    }
}