using System;
using System.Collections.Generic;

namespace Exercise_2___Restaurants
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant("Gourmet Paradise");

            Dish pasta = new MainDish("Pasta", 12.99m);
            Dish salad = new Appetizer("Salad", 5.99m);
            Dish cake = new Dessert("Cake", 6.99m);

            restaurant.Menu.AddDish(pasta);
            restaurant.Menu.AddDish(salad);
            restaurant.Menu.AddDish(cake);

            Waiter waiter = new Waiter();
            restaurant.Waiter = waiter;

            Order order = new Order(restaurant.Menu);
            order.AddDish(pasta);
            order.AddDish(cake);

            waiter.TakeOrder(order);

            waiter.ServeOrder(order);

            Console.WriteLine($"Order completed: {order.IsCompleted}");
        }
    }

    
}
