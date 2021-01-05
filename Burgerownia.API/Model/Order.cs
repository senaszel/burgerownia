using System.Collections.Generic;

namespace Burgerownia.Back.Model
{
    public class Order : IOrder
    {
        public List<Item> Items { get; }

        public Order()
        {
            Items = new List<Item>();
        }

        public void AddItem(Item item) => Items.Add(item);


        public double TotalPrice()
        {
            double totalPrice = 0;
            Items.ForEach(each => totalPrice += each.Price);
            return totalPrice;
        }


    }
}