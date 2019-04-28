using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class User
    {
        string name;
        string lastName;
        DateTime dateOfBirth;
        int age;

        public User(string name, string lastName, DateTime dateOfBirth)
        {
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            this.DateOfBirth = dateOfBirth;
        }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public int Id { get; set; }
        public int Age
        {
            get => age;

            set
            {
                var nowDate = DateTime.Now;
                age = nowDate.Year - dateOfBirth.Year;
                if (nowDate.Month <= dateOfBirth.Month)
                {
                    if (nowDate.Day <= dateOfBirth.Day)
                    {
                        age--;
                    }
                }
            }
        }

    }
}
