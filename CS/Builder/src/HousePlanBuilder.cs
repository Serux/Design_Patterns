using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder.src
{
    public class HousePlanBuilder : IBuilder
    {
        private HousePlan housePlan;

        public HousePlanBuilder()
        {
            housePlan = new HousePlan();
        }

        public void buildDoors()
        {
            housePlan.doors = new List<Door>();
            housePlan.doors.Add(new Door("Metal","MainDoor"));
            housePlan.doors.Add(new Door("Wood","BathroomDoor"));
        }

        public void buildRoof()
        {
            housePlan.roofs = new List<Roof>();
            housePlan.roofs.Add(new Roof("Clay","AllRoof"));
        }

        public void buildWalls()
        {
            housePlan.walls = new List<Wall>();
            housePlan.walls.Add(new Wall("ConcreteBricks","OuterWall"));
            housePlan.walls.Add(new Wall("ClayBricks","InnerWalls"));
        }

        public void buildWindows()
        {
            housePlan.windows = new List<Window>();
            housePlan.windows.Add(new Window("BigWindow","KitchenRoom"));
            housePlan.windows.Add(new Window("SmallWindow","Bathroom"));
        }

        public void reset()
        {
            housePlan = new HousePlan();
        }

        public HousePlan? GetHousePlan()
        {
            HousePlan h = this.housePlan;
            if(h is null 
                || !(h.doors?.Any()).GetValueOrDefault(false) 
                || !(h.walls?.Any()).GetValueOrDefault(false) 
                )
            {
                return null;
            }
            return h;
        }
    }
}