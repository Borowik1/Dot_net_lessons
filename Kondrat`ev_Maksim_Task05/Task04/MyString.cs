using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class MyString
    {

        public MyString()
        {
            this.Arr = null;
        }

        public MyString(string st1)
        {
            this.Arr = st1.ToCharArray();
        }

        public char[] Arr { get; set; }

        public static MyString operator +(MyString st1, MyString st2)
        {
            MyString st3 = new MyString();
            char[] ar1 = st1.Arr;
            Array.Resize(ref ar1, st1.Arr.Length + st2.Arr.Length);
            st2.Arr.CopyTo(ar1, st1.Arr.Length);
            st3.Arr = ar1;
            return st3;
        }

        public static MyString operator -(MyString st1, MyString st2)
        {
            int l = 0;

            if (st1.Arr.Length < st2.Arr.Length)
            {
                throw new Exception("Вычитание из меньшего массива");
            }

            for (int i = 0; i < st1.Arr.Length - st2.Arr.Length; i++)
            {
                if (st1.Arr[i] == st2.Arr[0])
                {
                    bool match = false;

                    for (int j = 0; j < st2.Arr.Length; j++)
                    {
                        if (st1.Arr[i + j] == st2.Arr[j])
                        {
                            match = true;
                        }
                        else
                        {
                            match = false;
                            break;
                        }

                    }

                    if (match == true)
                    {
                        for (int k = i; k < st1.Arr.Length - (st2.Arr.Length * (l + 1)); k++)
                        {
                            st1.Arr[k] = st1.Arr[k + st2.Arr.Length];
                        }

                        l++;
                    }
                }
            }

            char[] ar1 = st1.Arr;
            Array.Resize(ref ar1, st1.Arr.Length - l * st2.Arr.Length);
            st1.Arr = ar1;
            return st1;
        }
        public static bool operator ==(MyString st1, MyString st2)
        {
            if (st1.Arr.Length != st2.Arr.Length)
            {
                return false;
            }

            for (int i = 0; i < st1.Arr.Length; i++)
            {
                return (st1.Arr[i] == st2.Arr[i]);
            }
            return true;
        }
        public static bool operator !=(MyString st1, MyString st2)
        {
            if (st1.Arr.Length != st2.Arr.Length)
            {
                return true;
            }

            for (int i = 0; i < st1.Arr.Length; i++)
            {
                if (st1.Arr[i] != st2.Arr[i])
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            string st = new string(this.Arr);
            return st;
        }
        public override bool Equals(object obj)
        {
            var @string = obj as MyString;
            return @string != null &&
                   EqualityComparer<char[]>.Default.Equals(Arr, @string.Arr);
        }

        public override int GetHashCode()
        {
            return -321683592 + EqualityComparer<char[]>.Default.GetHashCode(Arr);
        }

    }
}
