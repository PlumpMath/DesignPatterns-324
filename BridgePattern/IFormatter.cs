using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    public interface IFormatter
    {
        string Format(string key, string value);
    }
}
