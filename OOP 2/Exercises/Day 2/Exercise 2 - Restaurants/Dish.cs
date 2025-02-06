using System;

namespace Exercise_2___Restaurants
{
    public abstract class Dish
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        protected Dish(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }

    public class MainDish : Dish
    {
        public MainDish(string name, decimal price) : base(name, price) { }
    }

    public class Appetizer : Dish
    {
        public Appetizer(string name, decimal price) : base(name, price) { }
    }

    public class Dessert : Dish
    {
        public Dessert(string name, decimal price) : base(name, price) { }
    }
}