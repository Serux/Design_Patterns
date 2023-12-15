using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.src
{
    public class HousePlan
    {
        public IList<Wall>?  walls;
        public IList<Door>? doors;
        public IList<Window>? windows;
        public IList<Roof>? roofs;
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            List<string> en = walls.Select(x=>$"Drawing {x.Material} in {x.Position}").ToList();
            en.ForEach(x=>sb.AppendLine(x));
            if (windows == null) sb.AppendLine("No windows to Draw");
            sb.AppendLine("...etc...");
            return sb.ToString();
        }

    }
}