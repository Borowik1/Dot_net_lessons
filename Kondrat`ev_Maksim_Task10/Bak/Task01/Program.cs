using System;

namespace Task01
{
    class Program
    {
        public delegate string[] Operation(string st1, string st2);

        static void Main(string[] args)
        {
            string[] array = { "zzzzzzz", "oiu", "uyg", "kkjkh", "gvghvhgv", "jkl", "jjn", "a" };

            for (int i = 0; i < array.Length; i++)
            {
                Operation oper;

                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].ToCharArray().Length == array[j + 1].ToCharArray().Length)
                    {
                        oper = SortByChar;
                    }
                    else
                    {
                        oper = SortByLength;
                    }

                    string[] temp = new string[2];
                    temp = oper(array[j], array[j + 1]);
                    array[j] = temp[0];
                    array[j + 1] = temp[1];
                }
            }

            foreach (string i in array)
            {
                Console.WriteLine(i);
            }

            Console.Read();

        }
        public static string[] SortByLength(string st1, string st2)
        {
            string[] result = new string[2];

            if (st1.ToCharArray().Length < st2.ToCharArray().Length)
            {
                result[0] = st1;
                result[1] = st2;
            }
            else
            {
                result[0] = st2;
                result[1] = st1;
            }
            return result;
        }

        public static string[] SortByChar(string st1, string st2)
        {
            string[] result = new string[2];
            char[] tempArray1 = st1.ToCharArray();
            char[] tempArray2 = st2.ToCharArray();
            bool variable = true;

            for (int i = 0; variable; i++)
            {
                if (tempArray1[i] != tempArray2[i])
                {
                    if (tempArray1[i] < tempArray2[i])
                    {
                        result[0] = st1;
                        result[1] = st2;
                        break;
                    }
                    else
                    {
                        result[0] = st2;
                        result[1] = st1;
                        break;
                    }
                }
                
            }

            return result;
        }
    }
}
