using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString string1 = new MyString("qerwter");
            MyString string2 = new MyString("er");
            MyString string3 = string1 - string2;
            Console.WriteLine(string3.ToString());
            bool compare = string1 == string2;
            
            Console.Read();
        }
    }
}
