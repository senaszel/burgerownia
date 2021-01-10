using Burgerownia.Back.Interface;
using Burgerownia.Back.Model;
using System.Collections.Generic;
using System.Linq;

namespace Burgerownia.Back.Services
{
    public class BurgerService : IServiceable<Burger>
    {
        private IRepository<Burger> BurgerRepository { get; }
        private List<Burger> _items;

        public BurgerService(IRepository<Burger> burgerRepository)
        {
            _items = burgerRepository.GetAll();
        }

        public List<Burger> Items => _items;
        public int ItemsCount => Items.Count; 
        public Burger GetItemById(int burgers_id) => Items[burgers_id];
        public List<Burger> GetItemsFromArray(int[] burgers_ids) 
        {
            List<Burger> resultsList = new List<Burger>();
            burgers_ids.ToList().ForEach(burger_id => resultsList.Add(GetItemById(burger_id)));
            return resultsList;
        }


    }
}
