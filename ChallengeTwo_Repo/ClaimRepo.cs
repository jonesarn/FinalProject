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
        //Change to a que
        //public readonly Dictionary<int, ClaimPoco> _AllClaims = new Dictionary<int, ClaimPoco>();
        public readonly Queue<ClaimPoco> _AllClaims = new Queue<ClaimPoco>();
        private int _count = 000;
        //Create
        public bool CreateClaim(ClaimPoco claim)
        {
            if (claim != null)
            {
                _count++;
                claim.ClaimId = _count;
                _AllClaims.Enqueue(claim);
                return true;
            }
            else return false;
        }
        public bool ClaimActive(ClaimPoco claim)
        {
            DateTime claimDate = claim.DateOfClaim;
            DateTime IncidentDate = claim.DateOfClaim;
           
            if (IncidentDate.AddDays(30) <= claimDate)
            {
                claim.IsValid = true;
                return true;
            }
            else
            {
                claim.IsValid = false;
                return false;
            }
}
        //Read
        public Queue<ClaimPoco> ReadAllClaim()
        {
            return _AllClaims;
        }
        //ReadAll
        public ClaimPoco ReadOneClaim(int claimNumber)
        {
            foreach (ClaimPoco claim in _AllClaims)
            {
                if (claim.ClaimId == claimNumber)
                {
                    return claim;
                }
                else if(claim.ClaimId != claimNumber){
                    return null;
                }
            }
            return null;
        }
        //Update
        public bool UpdateClaim(int claimNumber, ClaimPoco NewClaimInfo)
        {
            ClaimPoco OldClaimInfo = ReadOneClaim(claimNumber);
            if(OldClaimInfo == NewClaimInfo)
            {
                return false;
            }
            else
            {
                NewClaimInfo.ClaimId = OldClaimInfo.ClaimId;
                NewClaimInfo.ClaimType = OldClaimInfo.ClaimType;
                NewClaimInfo.ClaimAmount = OldClaimInfo.ClaimAmount;
                NewClaimInfo.DateOfClaim = OldClaimInfo.DateOfClaim;
                NewClaimInfo.DateOfIncindent = OldClaimInfo.DateOfIncindent;
                return true;
            }
        }
        //Delete
        public bool DeleteClaim(ClaimPoco claim)
        {
            if(claim.IsValid = true)
            {
                return true;
                _AllClaims.Dequeue();
            }
            else
            {
                return false;
            }
           
        }
    }
}
