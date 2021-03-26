using System;
using System.IO;
using Week1Prova.MyExpenseModel;

namespace Week1Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questo è un elaboratore di spesa\n");

            FileSystemWatcher fileWatcher = new FileSystemWatcher();
            fileWatcher.Path = @"C:\Users\WORK\Desktop\MyFolder";
            fileWatcher.Filter = "*.txt";

            fileWatcher.NotifyFilter = NotifyFilters.LastWrite
                | NotifyFilters.LastAccess | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            fileWatcher.EnableRaisingEvents = true;

            fileWatcher.Created += Controller.WatchMyFolder;
        }
    }
}
