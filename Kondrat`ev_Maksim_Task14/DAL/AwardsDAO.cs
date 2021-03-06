﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class AwardsDAO : IAwardDAO
    {
        private List<Award> awards = new List<Award>();

        public void Add(Award award)
        {
            if(award == null) { throw new ArgumentException("award"); }

            awards.Add(award);
        }

        public void Remove(Award award)
        {
            awards.Remove(award);
        }

        public IEnumerable<Award> GetList()
        {
            return awards;
        }
    }

    public class AwardsDAOdb : IAwardDAO
    {
        public void Add(Award award)
        {
            throw new NotImplementedException();
        }

        public void Remove(Award award)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Award> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
