using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.Data;

namespace FactoryMethod.src.Interfaces
{
    public interface IVehicle
    {
        public abstract string info();
        public abstract string color();

    }
}