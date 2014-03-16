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
        public Member Member { get; set; }

        public string NationalDrugCode { get; set; }


        public Pharmacy(IFormatter formatter)
            : base(formatter)
        {

        }

        public override void Print()
        {
            Console.WriteLine(formatter.Format("Pharmacy Number", PharmacyReferralId.ToString()));
            Console.WriteLine(formatter.Format("Member Name", Member.FirstName + " " + Member.LastName));
            Console.WriteLine(formatter.Format("Drugs", NationalDrugCode));
            Console.WriteLine();
        }


    }
}
