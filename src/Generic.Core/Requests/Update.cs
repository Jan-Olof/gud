using System;

namespace Generic.Core.Requests
{
    public record Update : Request
    {
        public Update() =>
            Name = string.Empty;

        public Guid Id { get; init; }

        public string Name { get; init; }
    }
}