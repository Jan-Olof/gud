using System;
using System.IO;

namespace Generic.Common.Messages
{
    public static class MonitorFiles
    {
        public static void MonitorFolder(string path, Action<object, FileSystemEventArgs> onChanged)
        {
            var watcher = new FileSystemWatcher
            {
                Path = path,
                IncludeSubdirectories = true,
                NotifyFilter = NotifyFilters.Attributes |
                    NotifyFilters.CreationTime |
                    NotifyFilters.DirectoryName |
                    NotifyFilters.FileName |
                    NotifyFilters.LastAccess |
                    NotifyFilters.LastWrite |
                    NotifyFilters.Security |
                    NotifyFilters.Size,
                Filter = "*.*"
            };

            watcher.Changed += new FileSystemEventHandler(onChanged);
            watcher.Created += new FileSystemEventHandler(onChanged);
            watcher.Deleted += new FileSystemEventHandler(onChanged);
            watcher.Renamed += new RenamedEventHandler(onChanged);

            watcher.EnableRaisingEvents = true;
        }
    }
}