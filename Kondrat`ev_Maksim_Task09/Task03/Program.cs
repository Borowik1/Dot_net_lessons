using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            string[] arr;
            int maxValue = 0;
            string maxWord = null;

            Console.WriteLine("Введите строку");
            str = Console.ReadLine();
            arr = str.Split(new char[] { ',', '.', ';', ':', '?', '!', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> words = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);

            for (int i = 0; i < arr.Length; i++)
            {
                string word = arr[i];

                if (words.ContainsKey(word))
                {
                    words[word]++;
                }
                else
                {
                    words.Add(word, 1);
                }
            }

            foreach (KeyValuePair<string, int> keyValue in words)
            {
                if (keyValue.Value > maxValue)
                {
                    maxValue = keyValue.Value;
                    maxWord = keyValue.Key;
                }
            }

            foreach (KeyValuePair<string, int> keyValue in words)
            {
                if (keyValue.Value == maxValue)
                {
                    Console.WriteLine($"Слово {maxWord} встречается {maxValue} раз");
                }
            }
            
            Console.ReadKey();
        }
    }
}
