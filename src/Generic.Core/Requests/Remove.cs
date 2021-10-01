using System;

namespace Generic.Core.Requests
{
    public record Remove : Request
    {
        public Guid Id { get; init; }
    }
}