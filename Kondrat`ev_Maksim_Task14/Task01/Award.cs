using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Award
    {
        public int AwardId { get; set; }
        public string AwardName { get; set; }
        public string AwardDescription { get; set; }
        public Award(int id, string awardName, string awardDesc)
        {
            AwardName = awardName;
            AwardDescription = awardDesc;
            AwardId = id;
        }
    }
}
