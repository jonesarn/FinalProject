using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge2_Poco;

namespace ChallengeTwo_Repo
{
    public class ClaimRepo
    {
        public readonly Dictionary<int, ClaimPoco> _AllClaims = new Dictionary<int, ClaimPoco>();
        private int _count = 000;
        //Create
        public bool CreateClaim(ClaimPoco claim)
        {
            if (claim != null)
            {
                _count++;
                claim.ClaimId = _count;
                _AllClaims.Add(claim.ClaimId, claim);
                return true;
            }
            else return false;
        }
        //Read
        public Dictionary<int, ClaimPoco> ReadAllClaim()
        {
            return _AllClaims;
        }
        //ReadAll
        //Update
        //Delete

    }
}
