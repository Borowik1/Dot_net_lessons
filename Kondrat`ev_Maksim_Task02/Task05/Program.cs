using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int Summ=0;

            for(int i = 1; i<= 1000; i++)
            {
                if (i % 3 == 0)
                {
                    Summ += i;
                }
                if (i % 5 == 0)
                {
                    Summ += i;
                }
                    
            }

            Console.Write("Сумма всех натуральных чисел, меньших 1000 и кратных трём и пяти: " + Summ);
            Console.ReadLine();
        }
    }
}
