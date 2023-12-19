using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter.src
{
    public class EuropeanPlug
    {
        public PlugPinsType plugType()
        { 
            return PlugPinsType.Round;
        }

        public PlugPinsType originalPinType()
        {
            return  PlugPinsType.Round;
        }
    }
}