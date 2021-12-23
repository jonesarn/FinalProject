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
        //Holds doors and Badges
        public readonly Dictionary<string, List<Badges_POCO>> _BadgeAvailableDoors = new Dictionary<string, List<Badges_POCO>>();


        //Create Badges
        public bool CreateBadge(Badges_POCO badges_)
        {
            if (badges_ != null)
            {
                
                _BadgeAvailableDoors.Add(badges_.BadgeId, Badges_POCO);
                return true;
            }
            else
            {
                return false;
            }

        }



        //read
        public Dictionary<string, Badges_POCO> ReadData()
        {
            return _BadgeAvailableDoors;
        }

        //Read All
        public Badges_POCO ReadOneData(string doors)
        {
            foreach (KeyValuePair<string, Badges_POCO> door_  in _DoorsAndBadges)
            {
                if (door_.Key == doors)
                {
                    return door_.Value;
                }
                else if (door_.Key != doors)
                {
                    return null;
                }
               
            }
            return null;
        }

        //Update

        public bool UpdateData(string door, Badges_POCO NewBadgeInfo)
        {
            Badges_POCO OlddBadgeInfo = ReadOneData(door);
            if (OlddBadgeInfo != NewBadgeInfo)
            {
                OlddBadgeInfo.BadgeId = NewBadgeInfo.BadgeId;
                OlddBadgeInfo.ListOfDoorNames = NewBadgeInfo.ListOfDoorNames;
                OlddBadgeInfo.NameForBadge = NewBadgeInfo.NameForBadge;
                return true;
            }
            else
            {
                return false;
            }
        }

        //delete
        public bool DeleteItem(string Badge)
        {
            bool wasDeleted = _DoorsAndBadges.Remove(Badge);
            return wasDeleted;
        }
    }
}




  

