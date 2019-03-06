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
            int n;

            Console.Write("Введите число строк: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var s = new string('*', i);          
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
