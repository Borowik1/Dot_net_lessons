using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    abstract class Shape
    {
        public Shape(int x, int y)
        {        
            this.X = x;
            this.Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine($"Координаты центра фигуры x={X}, y={Y}");
        }
    }
}
