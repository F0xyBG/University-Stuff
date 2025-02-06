using System;

namespace Exercise_2___Restaurants
{
    public class Waiter
    {
        public List<Order> Orders = new List<Order>();

        public void TakeOrder(Order order)
        {
            Orders.Add(order);
        }

        public void ServeOrder(Order order)
        {
            order.CompleteOrder();
        }
    }
}