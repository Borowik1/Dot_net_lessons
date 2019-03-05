using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.Write("Введите количество пирамид: ");
            N = Convert.ToInt32(Console.ReadLine());

            for (int l = 1; l <= N; l++)
            {
                for (int i = 1; i <= l; i++)
                {
                    for (int j = 1; j <= N - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 1; k <= 1 + (i - 1) * 2; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            

            Console.ReadLine();
        }
    }
}
