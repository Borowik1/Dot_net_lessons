using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayGenerator;

namespace Task01
{
    class Program
    {

        static void Main(string[] args)
        {
            
            int[] array1 = new int[100];

            ArrayGen.ArrayGenerator(array1, -100, 100);
                                              
            for (int j = 0; j < array1.Length; j++)
            {
                int buffer;

                for (int k = 0; k < array1.Length-j-1; k++)
                {
                    if (array1[k] > array1[k + 1])
                    {
                        buffer = array1[k];
                        array1[k] = array1[k + 1];
                        array1[k + 1] = buffer;
                    }
                }
            }

            ArrayGen.WriteArray(array1);

            Console.WriteLine($"Минимальное значение массива: {array1[0]}");
            Console.WriteLine($"Максимальное значение массива: {array1[array1.Length - 1]}");

            Console.Read();
        }
    }
}
