using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAwardsDAL;

namespace UsersAwardsBLL
{
    public class AwardsBL
    {
        private readonly IAwardDAO awardsDAO;

        public AwardsBL()
        {
            awardsDAO = new AwardsDAOdb();
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

        public void Remove(int id)
        {
            foreach(Award aw in awardsDAO.GetList())
            {
                if(id == aw.AwardId)
                {
                    awardsDAO.Remove(aw);
                }
            }
        }


        public IEnumerable<Award> GetList()
        {
            return awardsDAO.GetList();
        }

        public void Edit(Award award)
        {
            awardsDAO.Edit(award);
        }

    }
}
