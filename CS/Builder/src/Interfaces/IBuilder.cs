using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder.src
{
    public interface IBuilder
    {
        public abstract void reset();
        public abstract void buildWalls();
        public abstract void buildDoors();
        public abstract void buildWindows();
        public abstract void buildRoof();

    }
}