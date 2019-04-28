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
            Ring rn = new Ring(1, 2, 3, 2);
            Console.WriteLine($"Длина окружности {rn.GetLenght()}");
            Console.WriteLine($"Площадь {rn.GetArea()}");
            Console.Read();

        }
    }
}
