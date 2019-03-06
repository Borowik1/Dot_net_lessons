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
            int n;
            
            Console.Write("Введите число строк пирамиды: ");            
            n = Convert.ToInt32(Console.ReadLine());
            
                for (int j=1; j <= n; j++)
                {
                    string s = new string('*', 1+(j-1)*2);
                    Console.WriteLine(s.PadLeft (n + j - 1));                    
                }             

            Console.ReadLine();
            
        }
    }
}
