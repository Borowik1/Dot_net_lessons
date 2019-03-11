using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayGenerator;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array4 = new int[10,10];
            int summ = 0;

            ArrayGen.ArrayGenerator(array4, -100, 100);

            for(int i = 0; i < array4.GetLength(0); i++)
            {
                for (int j = 0; j < array4.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        summ += array4[i, j];
                    }
                }
            }

            ArrayGen.WriteArray(array4);

            Console.WriteLine($"Сумма элементов, стоящих на чётных местах массива: {summ}");
            Console.Read();
        }
    }
}
