using Generic.Core.Requests;
using LaYumba.Functional;
using System;
using static LaYumba.Functional.F;
using Unit = System.ValueTuple;

namespace Generic.Core.Commands
{
    public abstract record Command
    {
        protected Command(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }

        // TODO: Implement!
    }

    public static class CommandExt
    {
        public static Exceptional<Command> CreateCommand(this Request request, Func<DateTime> now, Func<Guid> guid) =>
        request switch
        {
            //Add add => guid.CreateAddThing(now, add.Name, request.MessageId),
            //Remove remove => throw new NotImplementedException(),
            //Update update => throw new NotImplementedException(),
            _ => new NotImplementedException()
        };
    }
}