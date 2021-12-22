using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badges.POCO
{
    public class Badges_POCO
    {
        public int BadgeId { get; set; }
        public string ListBadgeNames { get; set; }
        public string NameForBadge { get; set; }

        public Badges_POCO(int badgeId, string listBadgeNames, string nameForBadges)
        {
            this.BadgeId = badgeId;
            this.ListBadgeNames = listBadgeNames;
            this.NameForBadge = nameForBadges;
        }
    }
  

}

    
 


