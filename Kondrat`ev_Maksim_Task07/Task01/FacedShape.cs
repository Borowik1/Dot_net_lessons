using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{  
    
    abstract class FacedShape : Shape
    {
        public int len;

        public FacedShape(int x, int y, int length) 
            : base(x, y)
        {
            Length = length;
        }

        public int Length
        {
            get
            {
                return len;
            }
            set
            {
                if (value > 0)
                {
                    len = value;
                }
                else
                {
                    throw new Exception("Отрицательная величина");
                }
            }
        }

        public abstract double GetPerimeter();

        public abstract double GetArea();

        public override void Draw()
        {
            Console.WriteLine($"Координаты каркасной фигуры x={X}, y={Y}");
            Console.WriteLine($"Условная длинна {Length}");
        }
    }


}
