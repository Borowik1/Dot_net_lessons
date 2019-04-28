using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Ring : Circle
    {
        private int innR;

        public Ring(int x, int y, int r, int innerR)
            : base(x, y, r) => InnerR = innerR;

        public int InnerR
        {
            get
            {
                return innR;
            }
            set
            {
                if (value > 0 & value < R)
                {
                    innR = value;
                }
                else
                {
                    throw new Exception("Неверный внутренний радиус");
                }
            }
        }

        public override double GetPerimeter()
        {
            return (2 * Math.PI * R) + (2 * Math.PI * InnerR);
        }

        public double GetArea()
        {
            return (Math.PI * R * R) - (Math.PI * InnerR * InnerR);
        }

        public override void Draw()
        {
            Console.WriteLine($"Координаты центра кольца x={X}, y={Y}");
            Console.WriteLine($"Внешний радиус кольца R={R}");
            Console.WriteLine($"Внутренний радиус кольца R={InnerR}");
            Console.WriteLine($"Периметр кольца L={GetPerimeter()}");
            Console.WriteLine($"Площадь кольца S={GetArea()}");
        }

    }
}
