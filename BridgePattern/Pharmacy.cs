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
        public string Member { get; set; }

        public Dictionary<string, string> NationalDrugCode { get; set; }


        public Pharmacy(IFormatter formatter)
            : base(formatter)
        {
          
            NationalDrugCode = new Dictionary<string, string>(); 

        }

        public override void Print()
        {
            Console.WriteLine(formatter.Format("Pharmacy Number", PharmacyReferralId.ToString()));
            Console.WriteLine(formatter.Format("Member", Member));
            foreach (var drug in NationalDrugCode)
            {
                Console.WriteLine(formatter.Format("Code", drug.Key));
                Console.WriteLine(formatter.Format("Name", drug.Value));
            }
            Console.WriteLine();
        }


    }
}
