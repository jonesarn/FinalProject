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
        public string ClaimType { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncindent { get; set; }
        public DateTime DateOfClaim { get; set; }
        public string ClaimDescription { get; set; }
        public bool IsValid { get; set; }

        public ClaimPoco(string claimType,string claimdescription,double claimAmount, DateTime dateOfIncindent, DateTime dateOfClaim)
        {
            
            this.ClaimType = claimType;
            this.ClaimAmount = claimAmount;
            this.DateOfIncindent = dateOfIncindent;
            this.DateOfClaim = dateOfClaim;
            this.ClaimDescription = claimdescription;

        }
    }
}
