using System;
using System.Collections;
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
            int qty;
            Console.WriteLine("Введите количество участников");
            qty = Convert.ToInt32(Console.ReadLine());           
            List<string> People = new List<string>(qty);

            for (int i = 0; i < People.Capacity; i++)
            {
                People.Add("Person" + $"{i + 1}");
            }

            LinkedList<string> PeopleLinked = new LinkedList<string>(People);           
            Console.WriteLine($"Оставшийся {RemoveEachSecondItem(People)}");
            Console.WriteLine($"Оставшийся (Linked List) {RemoveEachSecondItem(PeopleLinked)}");
            Console.Read();
        }

        static string RemoveEachSecondItem(ICollection<string> obj)
        {
            bool IsEven = true;

            while (obj.Count > 1)
            {
                ICollection<string> temp = new List<string>();

                foreach (string i in obj)
                {
                    if (IsEven)
                    {
                        temp.Add(i);
                    }
                    IsEven = !IsEven;
                }
                obj = temp;                
            }
            return obj.First();
        }
    }
}
