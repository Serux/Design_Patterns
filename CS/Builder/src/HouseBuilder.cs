using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder.src
{
    public class HouseBuilder : IBuilder
    {
        private House house;

        public HouseBuilder()
        {
            house = new House();
        }

        public void buildDoors()
        {
            house.doors = new List<Door>();
            house.doors.Add(new Door("Metal","MainDoor"));
            house.doors.Add(new Door("Wood","BathroomDoor"));
        }

        public void buildRoof()
        {
            house.roofs = new List<Roof>();
            house.roofs.Add(new Roof("Clay","AllRoof"));
        }

        public void buildWalls()
        {
            house.walls = new List<Wall>();
            house.walls.Add(new Wall("ConcreteBricks","OuterWall"));
            house.walls.Add(new Wall("ClayBricks","InnerWalls"));
        }

        public void buildWindows()
        {
            house.windows = new List<Window>();
            house.windows.Add(new Window("BigWindow","KitchenRoom"));
            house.windows.Add(new Window("SmallWindow","Bathroom"));
        }

        public void reset()
        {
            house = new House();
        }

        public House? GetHouse()
        {
            House h = this.house;
            if(h is null //House needs to have doors and walls
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