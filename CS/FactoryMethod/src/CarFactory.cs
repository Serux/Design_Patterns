using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryMethod.src.Interfaces;

namespace FactoryMethod.src
{
    public class CarFactory : Factory
    {
        public override IVehicle createVehicle()
        {
            return new Car();
        }
    }
}