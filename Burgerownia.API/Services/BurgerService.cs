using Burgerownia.API.Interface;
using Burgerownia.API.Model;
using Burgerownia.API.Repositories;

namespace Burgerownia.API.Services
{
    public class BurgerService : IServiceable
    {
        private BurgerRepository BurgerRepository { get; }
        public BurgerService()
        {
            BurgerRepository = new BurgerRepository();
        }


        public Item[] Items { get => BurgerRepository.GetAll().ToArray(); }
        public int ItemsCount { get => Items.Length; }

        public Item GetItemById(int burgerNumber)
        {
            return Items[burgerNumber];
        }
    }
}
