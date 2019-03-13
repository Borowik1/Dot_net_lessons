using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;

            Console.WriteLine("Введите строку");
            str = Console.ReadLine();
            
            Regex reg = new Regex(@"<.*?>");

            str = reg.Replace(str, "_");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
