using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using FactoryMethod.src.Interfaces;

namespace FactoryMethod.src
{
    public class Car : IVehicle
    {
        public string color()
        {
           return "blue";
        }

        public string info()
        {
            return "car";
        }
    }
}