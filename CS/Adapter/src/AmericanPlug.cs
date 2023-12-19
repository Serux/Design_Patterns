using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter.src
{
    public class AmericanPlug
    {
        public PlugPinsType plugType()
        { 
            return PlugPinsType.Rectangular;
        }

        public PlugPinsType originalPinType()
        {
            return  PlugPinsType.Rectangular;
        }
    }
}