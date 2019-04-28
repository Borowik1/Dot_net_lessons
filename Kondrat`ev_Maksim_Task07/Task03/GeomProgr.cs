using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class GeomProgr : ISeries
    {
        int CurrentIndex;

        public GeomProgr(double start, double step) 
        {
            this.Start = start;
            this.Step = step;
            this.CurrentIndex = 1;
        }
        public double Start { get; set; }
        public double Step { get; set; }

        public double GetCurrent()
        {
            return Start * Math.Pow(Step, CurrentIndex);
        }

        public bool MoveNext()
        {
            CurrentIndex++;
            return true;
        }

        public void Reset()
        {
            CurrentIndex = 1;
        }

        public static void PrintSeries(ISeries series)
        {
            series.Reset();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }
    }
}
