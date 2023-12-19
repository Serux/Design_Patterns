using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter.src
{
    public class EuropeanSocket
    {
        public bool fits(EuropeanPlug plug){
            return plug.plugType() == PlugPinsType.Round;
        }
    }
}