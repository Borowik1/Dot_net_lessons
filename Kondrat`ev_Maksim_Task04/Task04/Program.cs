using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            StringBuilder sb = new StringBuilder();
            Stopwatch sw1 = new Stopwatch();
            Stopwatch sw2 = new Stopwatch();
            int N = 100;

            sw1.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            sw1.Stop();

            sw2.Start();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            sw2.Stop();

            Console.WriteLine($"Время сборки строки суммированием: {sw1.Elapsed.TotalMilliseconds} мсек");
            Console.WriteLine($"Время сборки строки Append: {sw2.Elapsed.TotalMilliseconds} мсек");

            if (sw1.Elapsed.TotalMilliseconds < sw2.Elapsed.TotalMilliseconds)
            {
                Console.WriteLine($"Суммирование быстрее на {sw2.Elapsed.TotalMilliseconds - sw1.Elapsed.TotalMilliseconds} мсек");
            }
            else
            {
                Console.WriteLine($"Append быстрее на {sw1.Elapsed.TotalMilliseconds - sw2.Elapsed.TotalMilliseconds} мсек");
            }
            Console.ReadLine();

        }
    }
}
