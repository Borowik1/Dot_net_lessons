using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static public void CultCompare(string cult1, string cult2)
        {
            CultureInfo culInf1 = new CultureInfo(cult1);
            CultureInfo culInf2 = new CultureInfo(cult2);
            CultureInfo culInf3 = CultureInfo.InvariantCulture;
            StringBuilder line = new StringBuilder();
            line.Append('-', 65);
            Console.WriteLine($"|{line}|");
            Console.WriteLine("| {0,-20}| {1,-20}| {2,-20}|", "Свойство", $"{cult1}", $"{cult2}");
            Console.WriteLine($"|{line}|");
            Console.WriteLine("| {0,-20}| {1,-20}| {2,-20}|", "LongDatePattern", culInf1.DateTimeFormat.LongDatePattern, culInf2.DateTimeFormat.LongDatePattern);
            Console.WriteLine("| {0,-20}| {1,-20}| {2,-20}|", "LongTimePattern", culInf1.DateTimeFormat.LongTimePattern, culInf2.DateTimeFormat.LongTimePattern);
            Console.WriteLine("| {0,-20}| {1,-20}| {2,-20}|", "GroupSeparator", culInf1.NumberFormat.NumberGroupSeparator, culInf2.NumberFormat.NumberGroupSeparator);
            Console.WriteLine("| {0,-20}| {1,-20}| {2,-20}|", "DecimalSeparator", culInf1.NumberFormat.NumberDecimalSeparator, culInf2.NumberFormat.NumberDecimalSeparator);
            Console.WriteLine($"|{line}|");
            Console.WriteLine();

        }


        static void Main(string[] args)
        {
            CultCompare("ru-RU", "en-US");
            Console.ReadKey();
        }
    }
}
