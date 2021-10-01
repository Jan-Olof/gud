using Generic.Common.Messages;
using System;
using static LaYumba.Functional.F;
using Unit = System.ValueTuple;

namespace Generic.Core
{
    public static class ProcessMessage
    {
        public static Func<Message, Unit> Process() =>
            message => ProcessOneMessage(message);

        private static Unit ProcessOneMessage(Message message) // TODO: Some tests!
        {
            var oneMessage = message.CreateRequest() // TODO: Do things.
                .Match(
                    request => Unit(),
                    x => Unit());

            return oneMessage; // TODO: Fix ProcessOneMessage when interactor returns something.
        }
    }
}