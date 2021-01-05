using Burgerownia.Back.Model;
using System.Collections.Generic;

namespace Burgerownia.Back.Interface
{
    public interface IServiceable<T>
    {
        List<T> Items { get; }
        int ItemsCount { get; }
        T GetItemById(int items_id);
        List<T> GetItemsFromArray(int[] items_ids);
    }
}