using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryMethod.src.Interfaces;

namespace FactoryMethod.src
{
    public class Scooter : IVehicle
    {
        public string color()
        {
            return "red";
        }

        public string info()
        {
            return "scooter";
        }
    }
}