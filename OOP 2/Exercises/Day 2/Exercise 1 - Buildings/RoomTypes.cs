using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_2
{
    public class Room
    {
        public double Area { get; set; }
        public string Color { get; set; }

        public Room(double area, string color)
        {
            Area = area;
            Color = color;
        }
    }

    public class Bathroom : Room
    {
        public Bathroom(double area, string color) : base(area, color) { }
    }

    public class Kitchen : Room
    {
        public Kitchen(double area, string color) : base(area, color) { }
    }

    public class Bedroom : Room
    {
        public Bedroom(double area, string color) : base(area, color) { }
    }
}