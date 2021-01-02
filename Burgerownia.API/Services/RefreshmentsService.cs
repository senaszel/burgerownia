using System.Collections.Generic;

using Burgerownia.API.Interface;
using Burgerownia.API.Model;

namespace Burgerownia.API.Services
{
    public class RefreshmentsService : IServiceable
    {
        public Item[] Items => refreshments;
        public int ItemsCount => refreshments.Length;

        private Refreshment[] refreshments = new Refreshment[]
        {
            new Refreshment("Water",new List<Ingredient>(){ new Ingredient("water",1.00)}),
            new Refreshment("Pepsi",new List<Ingredient>(){ new Ingredient("Pepsi",3.00)}),
            new Refreshment("Mirinda", new Ingredients(4,5))
        };

        public Item GetItemById(int refreshmentNumber)
        {
            return Items[refreshmentNumber];
        }
    }
}