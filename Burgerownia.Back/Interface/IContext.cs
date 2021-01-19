using Burgerownia.Back.Model;
using Burgerownia.DataBase.SQLite;

namespace Burgerownia.Back.Interface
{
    public interface IContext
    {
        IBurgerService BurgerService { get; }
        IDB Db { get; }
        IServiceable<Ingredient> IngredientService { get; }
        IServiceable<Refreshment> RefreshmentService { get; }
    }
}