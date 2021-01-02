﻿using System.Collections.Generic;

namespace Burgerownia.API.Model
{
    public class Order
    {
        public List<Item> OrderItems { get => orderItems; }
        private List<Item> orderItems;

        public Order()
        {
            orderItems = new List<Item>();
        }

        public void AddItem(Item item)
        {
            OrderItems.Add(item);
        }

        

        public double TotalPrice()
        {
            double totalPrice = 0;
            OrderItems.ForEach(each => totalPrice += each.Price);
            return totalPrice;
        }
    }
}