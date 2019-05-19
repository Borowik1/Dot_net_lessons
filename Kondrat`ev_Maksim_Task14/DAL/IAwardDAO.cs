using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IAwardDAO
    {
        void Add(Entities.Award award);
        void Remove(Entities.Award award);
        System.Collections.Generic.IEnumerable<Entities.Award> GetList();
    }
}
