using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int summ=0;
            int[] array3 = { -3, 2, 4, -3, -8, 0, -5, 6, 9, 7};

            foreach (int i in array3)
            {
                if(i > 0)
                {
                    summ += i;
                }
            }
            Console.Write($"Сумма неотрицательных элементов массива: {summ}");
            Console.ReadLine();
        }
    }
}
