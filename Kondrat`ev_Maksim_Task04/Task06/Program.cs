using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Regex regComm = new Regex(@"^\-?\d*\.?\d*$");
            Regex regSci = new Regex(@"^\-?\d*\.?\d*e\-?\d*$");

            Console.Write("Введите число: ");
            str = Console.ReadLine();

            if (Regex.IsMatch(str, @"^\-?\d*\.?\d*$"))
            {
                Console.WriteLine("Число в обычной нотации");
            }
            else
            {
                if (Regex.IsMatch(str, @"^\-?\d*\.?\d*e\-?\d*$"))
                {
                    Console.WriteLine("Число в научной нотации");
                }
                else
                {
                    Console.WriteLine("Не число");
                }
            }

            Console.ReadLine();
                
        }
    }
}
