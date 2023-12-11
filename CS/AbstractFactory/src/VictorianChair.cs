using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.src.Interfaces;

namespace AbstractFactory.src
{
    public class VictorianChair : IChair
    {
        public string info()
        {
            return "Victorian Chair";
        }
    }
}