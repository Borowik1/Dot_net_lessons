using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            using (StreamReader sr = new StreamReader("disposable_task_file.txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    numbers.Add(int.Parse(line));
                }
            }

            using (StreamWriter sw = new StreamWriter("disposable_task_file.txt", false))
            {
                foreach (int number in numbers)
                {
                    sw.WriteLine(Convert.ToString(number * number));
                }
                sw.Flush();
            }

            Console.Read();
        }
    }
}
