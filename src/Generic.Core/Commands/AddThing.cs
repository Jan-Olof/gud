using System;

namespace Generic.Core.Commands
{
    public record AddThing : Command
    {
        private AddThing(Guid id, string name, DateTime created) : base(id)
        {
            Created = created;
            Name = name;
        }

        public DateTime Created { get; }

        public string Name { get; }

        public static AddThing Create(Guid id, string name, DateTime created) =>
            new(id, name, created);
    }
}