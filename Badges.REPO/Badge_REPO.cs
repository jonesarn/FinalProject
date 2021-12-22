using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Badges.POCO;

namespace Badges.REPO
{
    public class Badge_REPO
    {

        Dictionary<string, List<Badges_POCO>> _DoorsAndBadges = new Dictionary<string, List<Badges_POCO>>();
        
        //Create
        public bool CreateBadgeId(Badges_POCO badges)
        {
            if (badges != null)
            {
                _count++;
                badges.BadgeId = _count;
                _BadgeRepoInfo.Add(badges.BadgeId, badges);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CreateDoors(Badges_POCO doors)
        {
            if(doors == null)
            {
                return false;
            }
            else
            {
                doors.
            }
        }
        //read
        //Update
        //delete

    }

    internal class Dictionary<T1, T2, T3>
    {
    }
}
