namespace Generic.Core.Requests
{
    public record Add : Request
    {
        public Add() =>
            Name = string.Empty;

        public string Name { get; init; }
    }
}