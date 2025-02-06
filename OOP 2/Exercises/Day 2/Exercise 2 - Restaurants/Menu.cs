using System;
using System.Collections.Generic;

namespace Exercise_2___Restaurants
{
    public class Menu
    {
        public List<Dish> Dishes = new List<Dish>();

        public Menu()
        {
            Dishes = new List<Dish>();
        }

        public void AddDish(Dish dish)
        {
            Dishes.Add(dish);
        }
    }
}