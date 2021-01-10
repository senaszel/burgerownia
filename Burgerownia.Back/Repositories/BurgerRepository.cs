using Burgerownia.Back.Interface;
using Burgerownia.Back.Model;
using Burgerownia.Back.Services;
using Burgerownia.DataBase.SQLite;
using System;
using System.Collections.Generic;
using Burgerownia.DataBase.SQLite.Enum;

namespace Burgerownia.Back.Repositories
{
    public class BurgerRepository : IRepository<Burger>
    {
        private IDB _db;
        private List<Burger> _burgers;
                
        public BurgerRepository(IDB db, IServiceable<Ingredient> ingredientService) 
        {
            string[] _splitted;
            _db = db;
            _burgers = new List<Burger>();
            _db.GetAll(Tables.Burgers)
                .ForEach(ingredient =>
                {
                    _splitted = ingredient.Split(',');
                    int[] allIngredients_id = new int[_splitted.Length - 2];
                    for (int ingredient_id = 2; ingredient_id < _splitted.Length; ingredient_id++)
                    {
                        allIngredients_id[ingredient_id] = Convert.ToInt32(_splitted[ingredient_id]);
                    }

                    _burgers.Add(new Burger(
                        Convert.ToInt32(_splitted[0]),
                        _splitted[1],
                        new Ingredients(ingredientService, allIngredients_id)
                            ));
                });
        }

        public Burger Get(int id) => _burgers.Find(b => b.Id == id);
        public List<Burger> GetAll() => _burgers;
        public Burger SpecialOfADay() => Get((int)System.DateTime.Now.DayOfWeek);


    }
}
