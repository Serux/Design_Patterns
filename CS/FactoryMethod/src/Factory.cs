using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryMethod.src.Interfaces;

namespace FactoryMethod.src
{
    public abstract class Factory
    {
        public abstract IVehicle createVehicle();

        public string startFabric()
        {
            IVehicle vehicle = this.createVehicle();
            return $"Im a {vehicle.color()} {vehicle.info()}"; 
        }

    }
}