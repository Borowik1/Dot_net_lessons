using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayGenerator
{
    public static class ArrayGen
    {
        public static void ArrayGenerator(int[] arr, int min, int max)
        {
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(min, max);
            }            
        }

        public static void ArrayGenerator(int[,] arr, int min, int max)
        {
            Random rnd = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(min, max);
                }
            }
        }
        public static void ArrayGenerator(int[,,]arr, int min, int max)
        {
            Random rnd = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = rnd.Next(min, max);
                    }
                }

            }
        }
        public static void WriteArray(int[] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine();
        }
        public static void WriteArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
