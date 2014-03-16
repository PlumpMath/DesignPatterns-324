using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Internal : Referral
    {
        public int InternalId { get; set; }
        public string Member { get; set; }

        public string Symptoms { get; set; }

        public Internal(IFormatter formatter)
            : base(formatter)
        {
         
        }

        public override void Print()
        {
            Console.WriteLine(formatter.Format("Internal Number", InternalId.ToString()));
            Console.WriteLine(formatter.Format("Member", Member));
            Console.WriteLine(formatter.Format("Symptoms", Symptoms));
            Console.WriteLine();
        }
    }
}
