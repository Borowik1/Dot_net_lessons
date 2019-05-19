using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAwardsDAL
{
    public interface IUserDAO
    {
        void Add(Entities.User user);
        void Remove(Entities.User user);
        void Edit(Entities.User user);
        System.Collections.Generic.IEnumerable<Entities.User> GetList();
    }
}
