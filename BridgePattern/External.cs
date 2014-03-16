using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class External: Referral
    {
        
        public int ExternalId { get; set; }
        public string Member { get; set; }

        public Dictionary<string, string> Procedures { get; set; }

        public External(IFormatter formatter)
            : base(formatter)
        {
         
            Procedures = new Dictionary<string, string>(); 
        }

        public override void Print()
        {
            Console.WriteLine(formatter.Format("External Number", ExternalId.ToString())); 
            Console.WriteLine(formatter.Format("Member", Member));
            foreach (var item in Procedures)
            {
                Console.WriteLine(formatter.Format("Code", item.Key));
                Console.WriteLine(formatter.Format("Name", item.Value));
            }
            Console.WriteLine();
        }
    }
}
