using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAwardsPL
{
    public class UserViewModel
    {
        private string awardsAsString;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AwardsAsString { get => awardsAsString; set => awardsAsString = value; }
        public UserViewModel(User user)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            DateOfBirth = user.DateOfBirth;
            foreach (Award aw in user.Awards)
            {
                awardsAsString = awardsAsString + aw.AwardName + "\n";
            }
        }
    }
}
