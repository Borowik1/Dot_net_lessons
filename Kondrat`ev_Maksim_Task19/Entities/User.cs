using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private int age;
        private List<Award> awards = new List<Award>();
        private int id;

        public User(int id, string firstName, string lastName, DateTime dateOfBirth, List<Award> aw)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Id = id;

            foreach (Award award in aw)
            {
                awards.Add(award);
            }
        }
        public User()
        {

        }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public int Id { get => id; set => id = value; }
        public List<Award> Awards { get => awards; set => awards = value; }
        public int Age
        {
            get
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
                return age;
            }
        }
    }
}
