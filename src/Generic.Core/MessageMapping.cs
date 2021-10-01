using Generic.Common.Helpers;
using Generic.Common.Messages;
using Generic.Core.Requests;
using LaYumba.Functional;
using System;

namespace Generic.Core
{
    public static class MessageMapping
    {
        public static Exceptional<Request> CreateRequest(this Message message) =>
            message.Type switch
            {
                MessageTypes.NewThing => DeserializeToRequest<Add>(message),
                MessageTypes.ThingRemoved => DeserializeToRequest<Remove>(message),
                MessageTypes.ThingChanged => DeserializeToRequest<Update>(message),
                _ => new Exception($"MessageType {message.Type} not supported.")
            };

        private static Exceptional<Request> DeserializeToRequest<T>(Message message) where T : Request =>
            message.Data.Deserialize<T>()
                .Map(request => request.Create(message.MessageId));
    }
}