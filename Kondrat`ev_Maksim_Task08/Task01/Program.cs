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
            string[] arr = { "sdf", "dfgds", "sdfgds" };

            DynamicArray<string> arr1 = new DynamicArray<string>(arr);

            arr1.Add("dfkvjndkf");

            Console.Read();
        }
    }
}
