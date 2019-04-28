using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к папке, за которой необходимо наблюдать:");
            string path = "c:\\dotnet";
            //string path = Console.ReadLine();
            MyWatcher(path);
            MyRestore(path);
        }

        public static void MyWatcher(string _path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(_path);
            List<FileInfo> fileInfos = new List<FileInfo>();


            DirectoryInfo bakDir = new DirectoryInfo(Path.Combine(_path, "_bak"));
            bakDir.Create();
            bakDir.Attributes = FileAttributes.Hidden;
            string logFilePath = Path.Combine(_path, "_bak", "log");

            foreach (FileInfo file in directoryInfo.GetFiles("*.txt", SearchOption.AllDirectories))
            {
                fileInfos.Add(file);                
            }

            foreach (FileInfo file in fileInfos)
            {
                string tmpFilePath = Path.GetTempFileName();
                file.CopyTo(tmpFilePath, true);
                Logging(logFilePath, file.DirectoryName, tmpFilePath, "First backup");
            }
            using (FileSystemWatcher sw = new FileSystemWatcher(_path))
            {
                sw.IncludeSubdirectories = true;
                //sw.NotifyFilter = NotifyFilters.DirectoryName
                //                | NotifyFilters.LastAccess
                //                | NotifyFilters.LastWrite
                //                | NotifyFilters.FileName;

                sw.Created += OnChange;
                sw.Changed += OnChange;
                sw.Renamed += OnRename;
                sw.Deleted += OnDelete;

                sw.EnableRaisingEvents = true;

                Console.WriteLine("Press 'q' to quit the sample.");
                while (Console.Read() != 'q') ;
            }

        }

        private static void Logging(string _logFilePath, string _origFilePath, string _backFilePath, string oper)
        {
            using (StreamWriter sw = new StreamWriter(_logFilePath, true))
            {
                sw.WriteLine(_origFilePath + '@' + _backFilePath + '@' + oper);
            }
        }

        private static void OnChange(object sender, FileSystemEventArgs e)
        {
            string logFilePath = Path.Combine(e.FullPath.Replace(e.Name, ""), "_bak", "log");
            string tmpFilePath = Path.GetTempFileName();
            FileInfo file = new FileInfo(e.FullPath);
            file.CopyTo(tmpFilePath, true);
            Logging(logFilePath, e.FullPath, tmpFilePath, Convert.ToString(e.ChangeType));
        }

        private static void OnRename(object sender, RenamedEventArgs e)
        {
            string logFilePath = Path.Combine(e.FullPath.Replace(e.Name, ""), "_bak", "log");
            string tmpFilePath = Path.GetTempFileName();
            FileInfo file = new FileInfo(e.FullPath);
            file.CopyTo(tmpFilePath, true);
            Logging(logFilePath, e.OldFullPath, tmpFilePath, Convert.ToString(e.ChangeType));
        }
        private static void OnDelete(object sender, FileSystemEventArgs e)
        {
            string logFilePath = Path.Combine(e.FullPath.Replace(e.Name, ""), "_bak", "log");
            string tmpFilePath = Path.GetTempFileName();
            FileInfo file = new FileInfo(e.FullPath);
            Logging(logFilePath, e.FullPath, tmpFilePath, Convert.ToString(e.ChangeType));
        }


        public static void MyRestore(string _path)
        {
            Dictionary<FileInfo, FileInfo> bakPair = new Dictionary<FileInfo, FileInfo>();
            FileInfo bakFile = new FileInfo(Path.Combine(_path, "_bak", "log"));

            if (!bakFile.Exists)
            {
                throw new Exception("Эта директория ранее не наблюдалась");
            }

            using (StreamReader sr = new StreamReader(Path.Combine(_path, "_bak", "log")))
            {
                string logString = sr.ReadLine();
                int i = 1;
                List<FileInfo> fileInfos = new List<FileInfo>();

                while (logString != null)
                {
                    string[] pathes = logString.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
                    if (pathes[2] != "First backup")
                    {
                        Console.WriteLine(Convert.ToString(i).PadRight(3)
                                        + pathes[0].PadRight(40)
                                        + pathes[2]);
                        i++;
                    }
                    FileInfo origFile = new FileInfo(pathes[0]);
                    FileInfo bakupFile = new FileInfo(pathes[1]);
                    bakPair.Add(bakupFile, origFile);
                    logString = sr.ReadLine();
                    fileInfos.Add(origFile);
                }
                FileInfo[] files = fileInfos.ToArray();

                

            }
        }
    }
}
