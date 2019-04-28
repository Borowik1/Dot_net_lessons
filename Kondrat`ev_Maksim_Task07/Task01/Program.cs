using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] sh = new Shape[10];

            Random rn = new Random();

            for (int i = 0; i < 10; i++)
            {
                switch (rn.Next(4))
                {
                    case 0:
                        sh[i] = new Line(rn.Next(-10, 10), rn.Next(-10, 10), rn.Next(1, 10));
                        break;
                    case 1:
                        sh[i] = new Circle(rn.Next(-10, 10), rn.Next(-10, 10), rn.Next(1, 10));
                        break;
                    case 2:
                        sh[i] = new Round(rn.Next(-10, 10), rn.Next(-10, 10), rn.Next(1, 10));
                        break;
                    case 3:
                        sh[i] = new Ring(rn.Next(-10, 10), rn.Next(-10, 10), rn.Next(5, 10), rn.Next(1, 4));
                        break;
                    case 4:
                        sh[i] = new Rectangle(rn.Next(-10, 10), rn.Next(-10, 10), rn.Next(1, 10), rn.Next(1, 10));
                        break;
                }
            }

            for (int i = 0; i < sh.Length; i++)
            {

                if (sh[i] is Line)
                {
                    ((Line)sh[i]).Draw();
                }
                else if (sh[i] is Circle)
                {
                    ((Circle)sh[i]).Draw();
                }
                else if (sh[i] is Round)
                {
                    ((Round)sh[i]).Draw();
                }
                else if (sh[i] is Ring)
                {
                    ((Ring)sh[i]).Draw();
                }
                else if (sh[i] is Rectangle)
                {
                    ((Rectangle)sh[i]).Draw();
                }

                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
