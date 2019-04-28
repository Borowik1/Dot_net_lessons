using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Triangle
    {
        private int len1;
        private int len2;
        private int len3;
        private double area;

        private Exception ex = new Exception();

        public Triangle(int len1, int len2, int len3)
        {
            this.Len1 = len1;
            this.Len2 = len2;
            this.Len3 = len3;
            TriangleExist();
        }

        public int Len1
        {
            get
            {
                return len1;
            }
            set
            {
                if (value > 0)
                {
                    len1 = value;
                }
                else
                {
                    Console.WriteLine("Отрицательная длина");
                    throw ex;
                }
            }
        }

        public int Len2
        {
            get
            {
                return len2;
            }
            set
            {
                if (value > 0)
                {
                    len2 = value;
                }
                else
                {
                    Console.WriteLine("Отрицательная длина");
                    throw ex;
                }
            }
        }

        public int Len3
        {
            get
            {
                return len3;
            }
            set
            {
                if (value > 0)
                {
                    len3 = value;
                }
                else
                {
                    Console.WriteLine("Отрицательная длина");
                    throw ex;
                }
            }
        }

        public int GetPerimeter()
        {
            return len1 + len2 + len3;
        }

        public double GetArea()
        {
            double perim = (len1 + len2 + len3) / 2;
            area = Math.Sqrt((perim / 2) * (perim / 2 - len1) * (perim / 2 - len2) * (perim / 2 - len3));
            return area;
        }

        private void TriangleExist()
        {
            if (!((len1 < len2 + len3) && (len1 > Math.Abs(len2 - len3))))
            {
                Console.Write("ОШИБКА!Несуществующий треугольник");
                throw ex;
            }
        }

    }
}
