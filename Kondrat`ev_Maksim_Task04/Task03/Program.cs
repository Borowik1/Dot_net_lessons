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
        static void Main(string[] args)
        {
            string cult1 = "ru-RU";
            string cult2 = "en-US";
            string cult3 = "";
            CultComp(cult1, cult2);
            CultComp(cult1, cult3);
            CultComp(cult2, cult3);
            Console.Read();
        }

        static void CultComp(string cult1, string cult2)
        {
            CultureInfo culInf1 = new CultureInfo(cult1);            
            CultureInfo culInf2 = new CultureInfo(cult2);           
            StringBuilder line = new StringBuilder();

            if (cult1 == "")
            {
                cult1 = "invariant";
            }
            else
            {
                if (cult2 == "")
                {
                    cult2 = "invariant";
                }
            }
         
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
    }
}
