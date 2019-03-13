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
            string str;
            string strComp;
            StringBuilder strRes = new StringBuilder();
            Console.Write("Введите строку:");
            str = Console.ReadLine();
            Console.Write("Введите сравниваемую строку:");
            strComp = Console.ReadLine();
            
            for (int i = 0; i < str.Length; i++)
            {
                if (strComp.Contains(str[i]))
                {
                    strRes.Append(str[i], 2);
                }
                else
                {
                    strRes.Append(str[i]);
                }
            }

            Console.WriteLine($"Изменнённая строка: {strRes}");
            Console.ReadLine();
        }
    }
}
