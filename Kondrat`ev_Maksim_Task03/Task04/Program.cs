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
            int[,] array4 = { { 2, 3 }, { 3, 4 }, { 5, 6 } };
            int summ = 0;

            for(int i = 0; i <= array4.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array4.GetUpperBound(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        summ += array4[i, j];
                    }
                }
            }
            Console.WriteLine($"Сумма элементов, стоящих на чётных местах массива: {summ}");
            Console.Read();
        }
    }
}
