using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.src.Interfaces
{
    public interface IFurnitureFactory
    {
        public abstract IChair createChair();
        public abstract ISofa createSofa();
    }
}