﻿using Burgerownia.Back.Interface;
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
        private List<Ingredient> _ingredients;

        public IngredientRepository(IDB db)
        {
            string[] _splitted;
            _db = db;
            _ingredients = new List<Ingredient>();
            _db.Select(Tables.Ingredients)
                .ForEach(ingredient =>
                    {
                        _splitted = ingredient.Split(',');
                        _ingredients.Add(new Ingredient(
                            id: Convert.ToInt32(_splitted[0]),
                            name: _splitted[1],
                            price: Convert.ToDouble(_splitted[2])
                        ));
                    });
        }

        public List<Ingredient> GetAll() => _ingredients;
        public Ingredient Get(int id) => _ingredients.Find(b => b.Id == id);


    }
}
