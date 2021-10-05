using Generic.Common.Messages;
using System;
using static LaYumba.Functional.F;
using Unit = System.ValueTuple;

namespace Generic.Core
{
    public static class ProcessMessage
    {
        public static Func<RawMessage, Unit> Process(Func<DateTime> now, Func<Guid> guid) =>
            message => ProcessOneMessage(message, now, guid);

        private static Unit ProcessOneMessage(RawMessage message, Func<DateTime> now, Func<Guid> guid) =>
            message.RunInteractor(now, guid);
    }
}