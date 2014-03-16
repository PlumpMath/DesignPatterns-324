using BridgePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BridgeMain
    {
        static void Main(string[] args)
        {
            List<Referral> authorizations = new List<Referral>();

            var standard = new StandardFormatter();
            var executive = new ExecutiveFormatter();
            var fancy = new FancyFormatter();

            var pharmacyReferral = new Pharmacy(standard);
            pharmacyReferral.NationalDrugCode.Add("313", "Medicine");
            authorizations.Add(pharmacyReferral);

            var externalReferral = new External(executive);
            externalReferral.Procedures.Add("757", "Evaluation");
            authorizations.Add(externalReferral);

            var internalReferral = new Internal(fancy)
            {
                InternalId = 9,
                Symptoms = "Flu"
            };

            authorizations.Add(internalReferral);

            foreach (var auth in authorizations)
            {
                auth.Print();
            }

            Console.ReadKey();
            

            

        }
    }
}
