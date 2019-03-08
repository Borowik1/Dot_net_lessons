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
            Random rnd = new Random();
            int[] array1 = new int[100];

            for (int i = 0; i < array1.Length; i++)
            {
                array1.SetValue(rnd.Next(-1000, 1000),i);
            }
                       
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

            Console.WriteLine($"Минимальное значение массива: {array1[0]}");
            Console.WriteLine($"Максимальное значение массива: {array1[array1.Length - 1]}");
            foreach(int i in array1)
            {
                Console.WriteLine($"{i} ");
            }
            Console.Read();
        }
    }
}
