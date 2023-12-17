using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prototype.src.Interfaces
{
    public interface IPrototype
    {
        public abstract string getColor();
        public abstract IPrototype clone();
    }
}