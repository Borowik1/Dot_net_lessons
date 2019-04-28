using System;
using MyMath;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int cons = 10;
            int factorial = Factorial.GetFactorial(cons);
            int exp = Exp.GetExp(cons, 8);
            Console.WriteLine($"Факториал {cons} равен {factorial}");
            Console.WriteLine($"Возведение в степень {exp}");
        }


    }
}
