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
            int[,] array = new int[10,10];
            int summ = 0;

            ArrayGen.ArrayGenerator(array, -100, 100);

            for(int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        summ += array[i, j];
                    }
                }
            }

            ArrayGen.WriteArray(array);

            Console.WriteLine($"Сумма элементов, стоящих на чётных местах массива: {summ}");
            Console.Read();
        }
    }
}
