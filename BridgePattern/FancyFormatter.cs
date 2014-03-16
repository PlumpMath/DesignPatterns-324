using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class FancyFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return string.Format("<bold> {0} </bold>\t\t {1}", key, value);
        }
    }
}
