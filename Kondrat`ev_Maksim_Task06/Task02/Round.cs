using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Round
    {
        public int X;
        public int Y;
        private int radius;
        private double length;
        private double area;

        private Exception ex = new Exception();

        public Round(int x, int y, int r)
        {
            this.X = x;
            this.Y = y;
            this.R = r;
        }

        public int R
        {
            get
            {
                return radius;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("ОШИБКА! Отрицательный радиус");
                    throw ex;
                }
                else
                {
                    radius = value;
                }
            }
        }
        public virtual double GetLenght()
        {
            return length = 2 * Math.PI * R;
        }
        public virtual double GetArea()
        {
            return area = Math.PI * Math.Pow(R, 2);
        }

    }
}