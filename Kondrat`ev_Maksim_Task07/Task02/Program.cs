using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            ISeries progr = new GeomProgr(2, 2);
            Console.WriteLine("Progression:");
            GeomProgr.PrintSeries(progr);         
            
            ISeries list = new List(new double[] { 5, 8, 6, 3, 1 });
            Console.WriteLine("List:");
            GeomProgr.PrintSeries(list);            
            Console.Read();
        }
    }
}
