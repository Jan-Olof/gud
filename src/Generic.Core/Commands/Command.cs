using System;

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
}