using System.Collections.Generic;

namespace Burgerownia.ConsoleApp
{
    public interface IMenuItemsProvider
    {
        List<MenuItem> Items();
    }
}