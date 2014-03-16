using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Pharmacy : Referral
    {
        public int PharmacyReferralId { get; set; }

        public Pharmacy(IFormatter formatter)
            : base(formatter)
        {

        }

        public override void Print()
        {
            throw new NotImplementedException();
        }


    }
}
