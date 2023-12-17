using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Prototype.src.Interfaces;

namespace Prototype.src
{
    public class Button : IPrototype
    {
        private int x;
        private int y;
        private string color ="";

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Button(int x, int y, string color)
        {
            this.X = x;
            this.Y = y;
            this.color = color;
        }
        public Button(Button proto)
        {
            this.x = proto.X;
            this.y = proto.Y;
            this.color = proto.color;
        }

        public string getColor()
        {
            return color;
        }

        public IPrototype clone()
        {
            return new Button(this);
        }

        public override string ToString()
        {
            return $"Button: {x} {y} {color} ";
        }
    }
}