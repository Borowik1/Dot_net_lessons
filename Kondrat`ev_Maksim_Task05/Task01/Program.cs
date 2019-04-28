using System;

namespace Task01
{
    class Program
    {

        static void Main(string[] args)
        {
            User student1 = new User("Иванов", "Иван", "Иванович");
            student1.DateOfBirth = DateTime.Parse("01.01.1986");
            Console.WriteLine($"{student1.LastName} {student1.Name} {student1.MiddleName} {student1.Age}");
            Console.ReadLine();
        }
    }
}
