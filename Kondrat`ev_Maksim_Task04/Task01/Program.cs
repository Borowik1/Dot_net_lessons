
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            string[] arr;
            float summ = 0;
            float average;


            Console.WriteLine("Введите строку");
            str = Console.ReadLine();
            arr = str.Split(new char[] { ',', '.', ';', ':', '?', '!', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string i in arr)
            {
                summ += i.Length;
            }

            average = summ / arr.Length;

            Console.WriteLine($"Средняя длинна слов в выражении {average}");
            Console.ReadKey();
        }
    }
}
