using System;
using System.IO;
using Unit = System.ValueTuple;

namespace Generic.Common.Messages
{
    public class MessageHandling
    {
        public MessageHandling()
        {
        }

        public void HandleMessages(Func<Message, Unit> processMessage)
        {
            MonitorFiles.MonitorFolder(@"C:\tmp", NewMessage);
        }

        public void NewMessage(object source, FileSystemEventArgs e)
        {
            string text = File.ReadAllText(e.FullPath);
        }
    }
}