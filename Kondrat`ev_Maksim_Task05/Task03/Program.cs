using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr1 = new Triangle(5, 6, 17);            
            Console.WriteLine($"Длины сторон треугольника a={tr1.Len1}, b={tr1.Len2}, c={tr1.Len3}");
            Console.WriteLine($"Периметр треугольника {tr1.GetPerimeter()}");
            Console.WriteLine($"Площадь треугольника {tr1.GetArea()}");
            Console.Read();
        }
    }
}
