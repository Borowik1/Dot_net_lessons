using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Rectangle : FacedShape
    {
        private int height;
        private int width;

        public Rectangle(int x, int y, int height, int width)
            : base(x, y, height)
        {           
            this.Width = width;
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new Exception("Отрицательная высота");
                }
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    throw new Exception("Отрицательная высота");
                }
            }
        }

        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Координаты центра прямоугольника x={X}, y={Y}");
            Console.WriteLine($"Высота прямоугольника H={Height}");
            Console.WriteLine($"Ширина прямоугольника W={Width}");
            Console.WriteLine($"Периметр прямоугольника L={GetPerimeter()}");
            Console.WriteLine($"Площадь прямоугольника S={GetArea()}");
        }



    }
}
