using Burgerownia.Back.Interface;
using Burgerownia.Back.Model;

namespace Burgerownia.ConsoleApp.Model
{
    public interface IRepo
    {
        IRepository<Ingredient> Ingredients { get; }
        IRepository<Refreshment> Refreshments { get; }
    }
}
