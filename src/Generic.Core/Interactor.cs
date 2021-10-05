using Generic.Common.Messages;
using Generic.Core.Commands;
using LaYumba.Functional;
using System;
using static LaYumba.Functional.F;
using Unit = System.ValueTuple;

namespace Generic.Core
{
    public static class Interactor // TODO: Tests!
    {
        public static Unit RunInteractor(this RawMessage rawMsg, Func<DateTime> now, Func<Guid> guid) =>
            rawMsg.CreateManagedMessage()
                .Bind(msg => msg.CreateCommand(now, guid))
                .Map(cmd => ShowCommand(cmd))
                .Match(errors => Unit(), command => Unit());

        private static Command ShowCommand(Command cmd) => cmd; // TODO: Remove!
    }
}