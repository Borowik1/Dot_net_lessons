using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayGenerator;

namespace Task02
{
    class Program
    {            
        static void Main(string[] args)
        {
            int[,,] array2 = new int[10, 20, 30];

            ArrayGen.ArrayGenerator(array2, -20, 20);

            for (int i = 0; i < array2.GetLength(0); i++)
            {
               for (int j = 0; j < array2.GetLength(1); j++)
                {
                    for (int k = 0; k < array2.GetLength(2); k++)
                    {
                        
                        if (array2[i, j, k] > 0)
                        {
                            array2[i, j, k] = 0;
                        }
                            
                    }
                }

            }

            Console.WriteLine("Done!");
            Console.ReadKey();
        }   

    }
}
