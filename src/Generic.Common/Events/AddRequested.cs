namespace Generic.Common.Events
{
    public sealed record AddRequested : Event
    {
        public AddRequested(string name) =>
            Name = name;

        public string Name { get; init; }
    }
}