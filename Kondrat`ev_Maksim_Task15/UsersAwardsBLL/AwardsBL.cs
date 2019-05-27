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

        public void Edit(Award award)
        {
            awardsDAO.Edit(award);
        }

    }
}
