using Burgerownia.Back.Model;

namespace Burgerownia.Back.Interface
{
    interface IServiceable
    {
        Item[] Items { get; }
        int ItemsCount { get; }

        Item GetItemById(int itemNumber);
    }
}