using System;
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
            Employee employee1 = new Employee("Иванов", "Иван", "Иванович", "Инженер");
            employee1.DateOfBirth=DateTime.Parse("01.01.1986");
            employee1.StartOfEmployment = DateTime.Parse("01.01.2000");
            Console.WriteLine($"{employee1.LastName}, {employee1.Name}, {employee1.MiddleName}, {employee1.Age}, {employee1.Position}, {employee1.Experience}");
            Console.Read();
        }
    }
}
