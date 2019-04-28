using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class ArrayEnumerator<T> : IEnumerator<T>
    {
        T[] _dynArray;
        int length;
        int position = -1;
        public ArrayEnumerator(T[] _dynArray, int length)
        {
            this._dynArray = _dynArray;
            this.length = length;
        }
        object IEnumerator.Current
        {
            get
            {
                if (position == -1 || position >= length)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    return _dynArray[position];
                }
            }
        }

        T IEnumerator<T>.Current
        {
            get
            {
                if (position == -1 || position >= length)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    return _dynArray[position];
                }
            }
        }

        void IDisposable.Dispose()
        {
            
        }

        bool IEnumerator.MoveNext()
        {
            if (position < length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        void IEnumerator.Reset()
        {
            position = -1;
        }
    }
}
