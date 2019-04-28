using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Employee : User, IEquatable<Employee>
    {
        private string position;

        public Employee(string lastName, string name, string middleName, string position) : base(lastName, name, middleName)
        {
            this.Position = position;
        }
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                if (StringCheck(value))
                {
                    position = value;
                }
            }
        }
        public DateTime StartOfEmployment { get; set; }
        public int Experience
        {
            get
            {
                return GetDiffOfDates(this.StartOfEmployment);
            }
        }

        public bool Equals(Employee other)
        {
            if (this == null || other == null)
            {
                throw new Exception("Объекты сравнения не могут быть null");
            }
            else
            {
                return this.Name == other.Name && this.LastName == other.LastName && this.MiddleName == other.MiddleName && this.DateOfBirth == other.DateOfBirth && this.StartOfEmployment == other.StartOfEmployment;
            }
        }

        bool IEquatable<Employee>.Equals(Employee other)
        {
            if (this == null || other == null)
            {
                throw new Exception("Объекты сравнения не могут быть null");
            }
            else
            {
                return this.Name == other.Name && this.LastName == other.LastName && this.MiddleName == other.MiddleName && this.DateOfBirth == other.DateOfBirth && this.StartOfEmployment == other.StartOfEmployment;
            }
        }
    }
}
