using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public interface IUserDAO
    {
        void Add(Entities.User user);
        void Remove(Entities.User user);
        System.Collections.Generic.IEnumerable<Entities.User> GetList();
    }
}
