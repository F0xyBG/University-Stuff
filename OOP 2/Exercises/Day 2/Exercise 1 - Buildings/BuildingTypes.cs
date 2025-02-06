using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_2
{
    public class Building
    {
        public double Area { get; set; }
        public double Height { get; set; }
        public string Color { get; set; }

        public Building(double area, double height, string color)
        {
            Area = area;
            Height = height;
            Color = color;
        }
    }

    public class House : Building
    {
        public List<Room> Rooms { get; set; }
        public Person Owner { get; set; }

        public House(double height, string color, Person owner) 
            : base(0, height, color)
        {
            Rooms = new List<Room>();
            Owner = owner;
        }

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
            Area += room.Area;
        }
    }
}