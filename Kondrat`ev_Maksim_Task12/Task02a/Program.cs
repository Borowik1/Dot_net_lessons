using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02a
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter = 0;
            Console.WriteLine("Введите путь к папке, за которой необходимо наблюдать:");
            WorkPath = "c:\\dotnet";
            //string path = Console.ReadLine();
            DirectoryInfo dir = new DirectoryInfo(WorkPath);
            BackupPath = Path.Combine(dir.Root.ToString(), "_bak");
            DirectoryInfo bakDir = new DirectoryInfo(BackupPath);
            bakDir.Create();
            bakDir.Attributes = FileAttributes.Hidden;
            MyBackup();

            using (FileSystemWatcher sw = new FileSystemWatcher(WorkPath))
            {
                sw.IncludeSubdirectories = true;
                sw.NotifyFilter = NotifyFilters.DirectoryName
                                | NotifyFilters.LastAccess
                                | NotifyFilters.LastWrite
                                | NotifyFilters.FileName;

                sw.Created += OnChange;
                sw.Changed += OnChange;
                sw.Renamed += OnRename;
                sw.Deleted += OnChange;

                sw.EnableRaisingEvents = true;

                Console.WriteLine("Нажмите 'q' для остановки наблюдения");
                while (Console.Read() != 'q') ;
            }

            Console.WriteLine("Введите номер строки, до которой необходимо откатить");
            string strNum = Console.ReadLine();
            MyRestore(Convert.ToInt32(strNum) - 1);
        }
        public static int Counter { get; set; }

        public static string BackupPath { get; set; }

        public static string WorkPath { get; set; }

        private static void OnRename(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"{Counter} Файл: {e.OldFullPath} переименован на {e.FullPath}");
            MyBackup();
        }

        private static void OnChange(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"{Counter} Файл: {e.FullPath} {e.ChangeType}");
            MyBackup();
        }

        public static void MyBackup()
        {
            DirectoryInfo _dir = new DirectoryInfo(WorkPath);
            DirectoryInfo _pathBak = new DirectoryInfo(BackupPath);

            foreach (DirectoryInfo dir in _dir.GetDirectories("*", SearchOption.AllDirectories))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(_pathBak + "\\" + Convert.ToString(Counter) + dir.FullName.Replace(_dir.FullName, ""));
                directoryInfo.Create();
            }

            foreach (FileInfo file in _dir.GetFiles("*", SearchOption.AllDirectories))
            {
                file.CopyTo(_pathBak + "\\" + Convert.ToString(Counter) + file.FullName.Replace(_dir.FullName, ""), true);
            }

            Counter++;
        }

        public static void MyRestore(int bakId)
        {
            if (bakId == 0)
            {
                return;
            }
            DirectoryInfo _dir = new DirectoryInfo(WorkPath);
            DirectoryInfo _pathBak = new DirectoryInfo(BackupPath + "\\" + Convert.ToString(bakId));

            _dir.Delete(true);
            _dir.Create();

            foreach (DirectoryInfo dir in _pathBak.GetDirectories("*", SearchOption.AllDirectories))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(WorkPath + dir.FullName.Replace(_pathBak.FullName, ""));
                directoryInfo.Create();
            }

            foreach (FileInfo file in _pathBak.GetFiles("*", SearchOption.AllDirectories))
            {
                file.CopyTo(_dir + file.FullName.Replace(_pathBak.FullName, ""), true);
            }
            Console.WriteLine("Восстановлено");
        }
    }
}
