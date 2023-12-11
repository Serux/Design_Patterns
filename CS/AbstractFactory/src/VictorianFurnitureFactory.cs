using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.src.Interfaces;

namespace AbstractFactory.src
{
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair createChair()
        {
            return new VictorianChair();
        }

        public ISofa createSofa()
        {
            return new VictorianSofa();
        }
    }
}