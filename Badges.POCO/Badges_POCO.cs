using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badges.POCO
{
    public class Badges_POCO
    {
        public string BadgeId { get; set; }
        public string ListOfDoorNames { get; set; }
        public string NameForBadge { get; set; }

        public Badges_POCO(string badgeId, string listOfDoorNames,)
        {
            this.BadgeId = badgeId;
            this.ListOfDoorNames = listOfDoorNames;
          
        }
    }
  

}

    
 


