using System;
using System.Collections.Generic;

namespace Exercise_2___Restaurants
{
    public class Order
    {
        private Menu menu { get; set; }
        public List<Dish> OrderedDishes = new List<Dish>();
        public bool IsCompleted { get; set; }

        public Order(Menu menu)
        {
            IsCompleted = false;
            this.menu = menu;
        }

        public void AddDish(Dish dish)
        {
            if(menu.Dishes.Contains(dish)) 
            {
                OrderedDishes.Add(dish);
            } else {
                throw new Exception("Dish not found in menu");
            }
        }

        public void CompleteOrder()
        {
            IsCompleted = true;
        }
    }
}