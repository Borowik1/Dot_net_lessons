using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Round : Circle
    {
        public Round(int x, int y, int r)
            : base(x, y, r)
        {

        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }

        public  double GetArea()
        {
            return Math.PI * R * R;
        }

        public override void Draw()
        {
            Console.WriteLine($"Координаты центра круга x={X}, y={Y}");
            Console.WriteLine($"Радиус круга R={R}");
            Console.WriteLine($"Периметр круга L={GetPerimeter()}");
            Console.WriteLine($"Площадь круга S={GetArea()}");
        }
    }
}
