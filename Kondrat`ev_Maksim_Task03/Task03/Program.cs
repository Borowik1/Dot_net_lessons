using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayGenerator;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int summ=0;
            int[] array3 = new int [20];

            ArrayGen.ArrayGenerator(array3, -100, 100);

            foreach (int i in array3)
            {
                if(i > 0)
                {
                    summ += i;
                }
            }

            ArrayGen.WriteArray(array3);

            Console.Write($"Сумма неотрицательных элементов массива: {summ}");
            Console.ReadLine();
        }
    }
}
