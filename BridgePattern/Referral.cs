using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class Referral
    {

        protected readonly IFormatter formatter;

        public Referral(IFormatter formatter)
        { 
            this.formatter = formatter;
        }

        abstract public void Print();
    }
}
