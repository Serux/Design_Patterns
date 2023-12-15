using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Builder.src.Enums;

namespace Builder.src
{
    public class Director
    {
        public IBuilder? builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }
        public void changeBuilder(IBuilder builder)
        {
            this.builder = builder;
        }

        public void make(HouseBuilderTypes types)
        {
            
            this.builder?.buildDoors();
            this.builder?.buildWalls();
            if (!types.Equals(HouseBuilderTypes.WithoutRoof) )
                this.builder?.buildRoof();
            if (!types.Equals(HouseBuilderTypes.WithoutWindows) )
                this.builder?.buildWindows();
        }
    }
}