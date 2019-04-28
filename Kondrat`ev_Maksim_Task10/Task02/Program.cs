using System;
using System.Collections.Generic;

namespace Task02
{

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Билл");
            Person p2 = new Person("Боб");
            Person p3 = new Person("Джон");
            Person p4 = new Person("Марк");
            Person p5 = new Person("Джереми");

            List<Person> employees = new List<Person>();

            employees.Add(p1);
            employees.Add(p2);
            employees.Add(p3);
            employees.Add(p4);
            employees.Add(p5);

            Office office = new Office(employees);

            p1.GoToWork();
            p2.GoToWork();
            p3.GoToWork();
            p1.GoHome();
            p4.GoToWork();

            Console.Read();
        }
    }
}
