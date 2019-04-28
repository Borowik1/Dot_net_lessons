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
            string[] arr = { "sdf", "dfgds", "sdfgds" };
            string[] arr2 = new string[20];

            DynamicArray<string> arr1 = new DynamicArray<string>(arr);

            arr1.Add("dfkvjndkf");

            Random rn = new Random();

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = Convert.ToString(rn.NextDouble());
            }

            arr1.AddRange(arr2);

            foreach (string i in arr1)
            {
                Console.WriteLine(i);
            }

            arr1.Remove(2);           

            arr1.Insert("jkhkj", 2);

            Console.WriteLine($"{arr1[2]} {arr1.Length} {arr1.Array.Length}");

            Console.Read();
        }
    }
}
