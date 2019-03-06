using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int s;

            Console.Write("Введите высоту прямоугольника: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a <= 0 | b <= 0)
            {
                Console.WriteLine("ОШИБКА! Введённые данные некорректны");

            }
            else
            {
                s = a * b;
                Console.WriteLine($"Площадь прямоугольника = {s}");
            }
            Console.ReadLine();
        }
    }
}
