using System;
using System.Collections.Generic;

namespace Exercise_2___Restaurants
{
    public class Restaurant
    {
        public string Name { get; set; }
        public Menu Menu { get; set; }
        public Waiter Waiter { get; set; }

        public Restaurant(string name)
        {
            Name = name;
            Menu = new Menu();
            Waiter = new Waiter();
        }
    }
}