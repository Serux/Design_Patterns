using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.src.Interfaces;

namespace AbstractFactory.src
{
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair createChair()
        {
            return new ModernChair();
        }

        public ISofa createSofa()
        {
            return new ModernSofa();
        }
    }
}