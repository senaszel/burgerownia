using Burgerownia.Back.Interface;
using Burgerownia.Back.Model;
using Burgerownia.DataBase.SQLite;
using System;
using System.Collections.Generic;
using Burgerownia.DataBase.SQLite.Enum;

namespace Burgerownia.Back.Repositories
{
    public class IngredientRepository : IRepository<Ingredient>
    {
        private IDB _db;
        private string[] _splitted;
        private List<Ingredient> Ingredients;

        public IngredientRepository(IDB db)
        {
            _db = db;
            Ingredients = new List<Ingredient>();
            _db.GetAll(Tables.Ingredients)
                .ForEach(ingredient =>
                    {
                        _splitted = ingredient.Split(',');
                        Ingredients.Add(new Ingredient(
                            Convert.ToInt32(_splitted[0]),
                            _splitted[1],
                            Convert.ToDouble(_splitted[2])
                        ));
                    });
        }

        public List<Ingredient> GetAll() => Ingredients;
        public Ingredient Get(int id) => Ingredients.Find(b => b.Id == id);
        public Ingredient SpecialOfADay() => Get((int)System.DateTime.Now.DayOfWeek);


    }
}
