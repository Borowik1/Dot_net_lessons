using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Regex reg = new Regex(@"\b([0,1]?\d|2[0-3]):[0-5]\d\b");

            Console.Write("Введите текс: ");
            str = Console.ReadLine();
            MatchCollection col = reg.Matches(str);

            Console.WriteLine($"Время в тексте присутствует {col.Count} раз");
            Console.Read();
        }
    }
}
