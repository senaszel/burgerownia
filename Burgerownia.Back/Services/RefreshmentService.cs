using Burgerownia.Back.Interface;
using Burgerownia.Back.Model;
using System.Collections.Generic;
using System.Linq;

namespace Burgerownia.Back.Services
{
    public class RefreshmentService : IServiceable<Refreshment>
    {
        private IRepository<Refreshment> RefreshmentRepository { get; }

        public RefreshmentService(IRepository<Refreshment> refreshmentRepository)
        {
            RefreshmentRepository = refreshmentRepository;

        }

        public List<Refreshment> Items => RefreshmentRepository.GetAll();
        public int ItemsCount => Items.Count;
        public Refreshment GetItemById(int refreshment_id) => Items[refreshment_id];

        public List<Refreshment> GetItemsFromArray(int[] refreshments_ids)
        {
            List<Refreshment> resultsList = new List<Refreshment>();
            refreshments_ids.ToList().ForEach(refreshment_id => resultsList.Add(GetItemById(refreshment_id)));
            return resultsList;
        }
    }
}