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
        private List<int> awardsId = new List<int>();
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public int Age { get; set; }
        public string Awards { get => awardsAsString; set => awardsAsString = value; }
        public List<int> AwardsId { get => awardsId; set => awardsId = value; }

        public static UserViewModel GetViewModel(User user)
        {
            var viewModel = new UserViewModel();
            viewModel.Id = user.Id;
            viewModel.FirstName = user.FirstName;
            viewModel.LastName = user.LastName;
            viewModel.DateOfBirth = user.DateOfBirth.ToShortDateString();
            viewModel.Age = user.Age;

            foreach (Award aw in user.Awards)
            {
                viewModel.Awards = viewModel.Awards + aw.AwardName.ToString() + " \n ";
                viewModel.AwardsId.Add(aw.AwardId);
            }

            return viewModel;
        }
    }
}
