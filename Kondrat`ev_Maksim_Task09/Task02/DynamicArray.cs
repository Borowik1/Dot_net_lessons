using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
     public class DynamicArray<T> : IEnumerable<T>
    {
        private T[] array;

        public DynamicArray()
        {
            this.Capacity = 16;
            this.Length = 8;
            this.Array = new T[Capacity];
        }

        public DynamicArray(int length)
        {
            this.Capacity = length * 2;
            this.Length = length;
            this.Array = new T[Capacity];
        }

        public DynamicArray(T[] array)
        {
            this.Capacity = array.Length * 2;
            this.Length = array.Length;
            this.Array = array;
        }

        public DynamicArray(IEnumerable<T> collection)
        {
            T[] array;
            array = collection.ToArray();
            this.Capacity = array.Length * 2;
            this.Length = array.Length;
            this.Array = array;
        }

        public T[] Array
        {
            get
            {
                return array;
            }
            set
            {
                array = value;

                if (array.Length < Capacity)
                {
                    T[] temp = array;
                    System.Array.Resize(ref temp, Capacity);
                    array = temp;
                }
            }
        }
        public int Capacity { get; set; }
        public int Length { get; set; }

        private void ExpandCapacity()
        {
            Capacity *= 2;
            T[] array = Array;
            System.Array.Resize(ref array, Capacity);
            Array = array;
        }

        public void Add(T element)
        {
            if (Length == Capacity)
            {
                ExpandCapacity();
            }

            Length++;
            Array[Length - 1] = element;
        }
        public void AddRange(T[] array)
        {
            if (Capacity - Length < array.Length)
            {
                for (; Capacity - Length < array.Length;)
                {
                    ExpandCapacity();
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Array[Length + i] = array[i];
            }

            Length = Length + array.Length;

        }

        public bool Remove(int element)
        {
            if (element >= Length)
            {
                return false;
            }

            for (int i = element; i < Length - 1; i++)
            {
                Array[i] = Array[i + 1];
            }

            Length--;
            return true;
        }

        public void Insert(T element, int position)
        {
            if (position > Length - 1)
            {
                throw new Exception("Элемент за пределами массива");
            }

            if (Length == Capacity)
            {
                ExpandCapacity();
            }

            Length++;

            for (int i = Length - 1; i > position + 1; i--)
            {
                Array[i] = Array[i - 1];
            }

            Array[position] = element;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new ArrayEnumerator<T>(array, Length);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ArrayEnumerator<T>(array, Length);
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 & index < Array.Length)
                {
                    return Array[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 & index < Array.Length)
                {
                    Array[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
