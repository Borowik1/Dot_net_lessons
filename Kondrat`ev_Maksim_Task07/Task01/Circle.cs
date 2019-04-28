using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{

    class Circle : FramedShape
    {
        private int r;

        public Circle(int x, int y, int r)
            : base(x, y, r) => R = r;

        public int R
        {
            get
            {
                return r;
            }
            set
            {
                if (value > 0)
                {
                    r = value;
                }
                else
                {
                    throw new Exception("Отрицательный радиус");
                }
            }
        }

        public override double GetPerimeter()
        {
            return 2* Math.PI* R;
        }

        public override void Draw()
        {
            Console.WriteLine($"Координаты центра окружности x={X}, y={Y}");
            Console.WriteLine($"Радиус R={R}");
            Console.WriteLine($"Длина дуги окружности L={GetPerimeter()}");
        }
    }
}
