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
            int N = 100;

            sw1.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            sw1.Stop();

            double time1 = sw1.Elapsed.TotalMilliseconds;
            
            sw1.Restart();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            sw1.Stop();

            double time2 = sw1.Elapsed.TotalMilliseconds;

            Console.WriteLine($"Время сборки строки суммированием: {time1} мсек");
            Console.WriteLine($"Время сборки строки Append: {time2} мсек");

            if (time1 < time2)
            {
                Console.WriteLine($"Суммирование быстрее на {time2 - time1} мсек");
            }
            else
            {
                Console.WriteLine($"Append быстрее на {time1 - time2} мсек");
            }
            Console.ReadLine();

        }
    }
}
