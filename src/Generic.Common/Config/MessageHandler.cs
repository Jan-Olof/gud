namespace Generic.Daemon.Config
{
    public record MessageHandler
    {
        public MessageHandler() => Folder = string.Empty;

        public string Folder { get; init; }
    }
}