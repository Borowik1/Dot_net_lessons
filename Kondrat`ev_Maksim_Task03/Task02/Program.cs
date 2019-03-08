using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {            
        static void Main(string[] args)
        {
            int[,,] array2 = new int[10, 20, 30];

            Random rnd = new Random();

            for (int i = 0; i < array2.GetUpperBound(0); i++)
            {
               for (int j = 0; j < array2.GetUpperBound(1); j++)
                {
                    for (int k = 0; k < array2.GetUpperBound(2); k++)
                    {
                        array2.SetValue(rnd.Next(-10, 10), i, j, k);

                        if (array2[i, j, k] > 0)
                        {
                            array2[i, j, k] = 0;
                        }
                            
                    }
                }

            }

            Console.ReadKey();
        }   

    }
}
