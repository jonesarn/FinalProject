using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2_Poco
{
    public class ClaimPoco
    {
        public int ClaimId { get; set; }
        public bool ClaimType { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncindent { get; set; }
        public DateTime DateOfClaim { get; set; }
        public string Description { get; set; }
        public bool IsValid { get; set; }

        public ClaimPoco(int claimId,bool claimType,double claimAmount, DateTime dateOfIncindent, DateTime dateOfClaim, bool isValid)
        {
            this.ClaimId = claimId;
            this.ClaimType = claimType;
            this.ClaimAmount = claimAmount;
            this.DateOfIncindent = dateOfIncindent;
            this.DateOfClaim = dateOfClaim;
            this.IsValid = isValid;

        }
    }
}
