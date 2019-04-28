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
            Round rd = new Round(1, 2, 3);
            Console.WriteLine($"Длина окружности {rd.GetLenght()}");
            Console.WriteLine($"Площадь {rd.GetArea()}");
            Console.Read();
        }
    }
}
