using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.src.Interfaces;

namespace AbstractFactory.src
{
    public class ModernChair : IChair
    {
        public string info()
        {
            return "Modern Chair";
        }
    }
}