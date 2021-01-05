using System.Collections.Generic;

namespace Burgerownia.Back.Model
{
    public interface IOrder
    {
        List<Item> Items { get; }
        void AddItem(Item item);
        double TotalPrice();
    }
}