using Burgerownia.Back.Model;
using Burgerownia.DataBase.SQLite;

namespace Burgerownia.Back.Interface
{
    public interface IContext
    {
        IRepository<Burger> BurgerRepository { get; }
        IServiceable<Burger> BurgerService { get; }
        IDB Db { get; }
        IRepository<Ingredient> IngredientRepository { get; }
        IServiceable<Ingredient> IngredientService { get; }
        IRepository<Refreshment> RefreshmentRepository { get; }
        IServiceable<Refreshment> RefreshmentService { get; }
    }
}