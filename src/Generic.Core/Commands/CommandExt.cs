using Generic.Common.Events;
using Generic.Common.Messages;
using LaYumba.Functional;
using System;

namespace Generic.Core.Commands
{
    public static class CommandExt
    {
        public static Exceptional<Command> CreateCommand(this Message msg, Func<DateTime> now, Func<Guid> guid) =>
        msg switch
        {
            ManagedMessage<AddRequested> add => AddThing.Create(guid(), add.Data.Name, now()),
            _ => new NotImplementedException()
        };
    }
}