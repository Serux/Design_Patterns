using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prototype.src.Interfaces;

namespace Prototype.src
{
    public class PrototypeRegistry
    {
        private IList<IPrototype> items = new List<IPrototype>();
        public void additem(IPrototype i)
        {
            items.Add(i);

        } 
        public IPrototype? getById(int id)
        {
            if(id < items.Count())
                return items[id];
            return null;
        }
        public IPrototype? getByColor(string color)
        {
            foreach(IPrototype i in items)
            {
                if(i.getColor().Equals(color))
                {
                    return i.clone();
                }
            }
            return null;
        }
    }
}