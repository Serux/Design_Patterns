using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter.src
{
    public class AmericanToEuropeanPlugAdapter : EuropeanPlug
    {
        private AmericanPlug americanPlug;

        public AmericanToEuropeanPlugAdapter(AmericanPlug americanPlug)
        {
            this.americanPlug = americanPlug;
        }

        public new PlugPinsType plugType()
        {
            return PlugPinsType.Round;
        }

        public new PlugPinsType originalPinType()
        {
            return  americanPlug.plugType();
        }
    }
}