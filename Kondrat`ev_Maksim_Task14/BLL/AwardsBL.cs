using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AwardsBL
    {
        private readonly IAwardDAO awardsDAO;

        public AwardsBL()
        {
            awardsDAO = new AwardsDAO();
        }

        public IEnumerable<Award> InitList()
        {
            Add("Award1", "Award1 Description");
            Add("Award2", "Award2 Description");
            Add("Award3", "Award3 Description");
            Add("Award4", "Award4 Description");

            return GetList();
        }

        public IEnumerable<Award> SortAwardsByNameAsc()
        {
            return (from a in GetList()
                    orderby a.AwardName ascending
                    select a).ToList();
        }

        public IEnumerable<Award> SortAwardsByNameDesc()
        {
            return (from a in GetList()
                    orderby a.AwardName descending
                    select a).ToList();
        }

        public void Add(string awardName, string awardDesc)
        {
            Award award = new Award(1, awardName, awardDesc);
            this.Add(award);
        }

        public void Add(Award award)
        {
            if (award == null) { throw new ArgumentException("award"); }

            awardsDAO.Add(award);
        }

        public void Remove(Award award)
        {
            awardsDAO.Remove(award);
        }

        public IEnumerable<Award> GetList()
        {
            return awardsDAO.GetList();
        }

    }
}
