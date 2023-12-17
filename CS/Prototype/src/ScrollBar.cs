using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prototype.src.Interfaces;

namespace Prototype.src
{
    public class ScrollBar : IPrototype
    {
        private string scrollsize;

        public string Scrollsize { get => scrollsize; set => scrollsize = value; }

        public ScrollBar(string scrollsize)
        {
            this.scrollsize = scrollsize;
        }

        public ScrollBar(ScrollBar sb)
        {
            this.scrollsize = sb.Scrollsize;
        }

        public IPrototype clone()
        {
            return new ScrollBar(this);
        }

        public string getColor()
        {
            return "None";
        }

        public override string ToString()
        {
            return $"ScrollBar {scrollsize} {this.getColor()}";
        }
    }
}