using Burgerownia.API.Model;

namespace Burgerownia.API.Interface
{
    interface IServiceable
    {
        Item[] Items { get; }
        int ItemsCount { get; }

        Item GetItemById(int itemNumber);
    }
}