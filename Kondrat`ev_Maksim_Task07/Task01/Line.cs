using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Line : FramedShape
    {

        public Line(int x, int y, int length)
           : base(x, y, length)
        {

        }

        public override double GetPerimeter()
        {
            return Length;
        }

        public override void Draw()
        {
            Console.WriteLine($"Координаты начала отрезка x={X}, y={Y}");
            Console.WriteLine($"Длина отрезка l={Length}");
        }
    }
}
