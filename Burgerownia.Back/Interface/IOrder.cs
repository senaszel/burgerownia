using System.Collections.Generic;

namespace Burgerownia.Back.Model
{
    public interface IOrder
    {
        List<Item> Items { get; }
        void AddItem(Item item);
        bool RemoveItem(Item item);
        bool RemoveItem(double price);
        double TotalPrice();
    }
}