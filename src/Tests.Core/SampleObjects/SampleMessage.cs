using Generic.Common.Messages;
using System;

namespace Tests.Core.SampleObjects
{
    public static class SampleMessage
    {
        public static RawMessage Create(string data = "data") =>
            new RawMessage(
                Guid.Parse("6d094222-a2e8-4c5d-a309-c0d8347ddf17"),
                data,
                new DateTime(2021, 10, 4, 7, 7, 7),
                MessageTypes.AddRequested);
    }
}