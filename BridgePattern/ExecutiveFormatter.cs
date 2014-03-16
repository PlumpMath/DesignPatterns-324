using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class ExecutiveFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return string.Format("<italics> {0} ----- =-- {1} </italics>", key, value);
        }
    }
}
