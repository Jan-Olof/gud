using Generic.Core.Commands;
using Generic.Core.Requests;
using LaYumba.Functional;
using System;
using static LaYumba.Functional.F;
using Unit = System.ValueTuple;

namespace Generic.Core
{
    public static class Interactor
    {
        public static Unit RunInteractor(this Request request, Func<DateTime> now, Func<Guid> guid) =>
            request.CreateCommand(now, guid)
                .Map(cmd => ShowCommand(cmd))
                .Match(errors => Unit(), command => Unit());

        private static Command ShowCommand(Command cmd) => cmd; // TODO: Remove!
    }
}