using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Ring : Round
    {
        private int innerR;
        public Ring(int x, int y, int r, int innerR) : base(x, y, r)
        {
            this.InnerR = innerR;
        }
        public int InnerR
        {
            get
            {
                return innerR;
            }
            set
            {
                if (R < value | value < 0)
                {
                    throw new Exception("Неверный внутренний радиус");
                }
                else
                {
                    innerR = value;
                }

            }
        }
        public override double GetLenght()
        {
            return 2 * Math.PI * (R + InnerR);
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(R, 2) - Math.PI * Math.Pow(InnerR, 2);
        }



    }
}
