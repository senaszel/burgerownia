using Burgerownia.DataBase.SQLite.Extensions;
using Burgerownia.DataBase.SQLite.Enum;
using Microsoft.Data.Sqlite;
using System;

namespace Burgerownia.DataBase.SQLite
{
    public static class InitialCreation
    {
        /// <summary>
        /// Runs once to Initially create database and fill it with initial data.
        /// </summary>
        public static SQLite_DB CreateDB(this SQLite_DB db)
        {
            db.CreateTable(Tables.Refreshments, "id INTEGER PRIMARY KEY AUTOINCREMENT ,nameof VARCHAR(50) NOT NULL, price INTEGER NOT NULL");
            db.CreateTable(Tables.Ingredients, "id INTEGER PRIMARY KEY AUTOINCREMENT ,nameof VARCHAR(50) NOT NULL, price INTEGER NOT NULL");
            db.CreateTable(Tables.Burgers, "id INTEGER PRIMARY KEY AUTOINCREMENT ,nameof VARCHAR(50) NOT NULL");
            db.CreateTable(Tables.Compositions, "id INTEGER PRIMARY KEY AUTOINCREMENT, ingredient_id INTEGER NOT NULL, burger_id INTEGER NOT NULL, FOREIGN KEY(burger_id) REFERENCES Burgers(id), FOREIGN KEY(ingredient_id) REFERENCES Ingredients(id)");

            db.SeedData(Tables.Ingredients, "\'bułka przenna 100g\', 300");
            db.SeedData(Tables.Ingredients, "\'bułka razowa 100g\', 500");
            db.SeedData(Tables.Ingredients, "\'mięso wołowe 180g\', 600");
            db.SeedData(Tables.Ingredients, "\'mięso drobiowe 180g\', 500");
            db.SeedData(Tables.Ingredients, "\'mięso wieprzowe 180g\', 500");
            db.SeedData(Tables.Ingredients, "\'zestaw sałat 30g\', 300");
            db.SeedData(Tables.Ingredients, "\'jajko sadzone 1szt\', 200");
            db.SeedData(Tables.Ingredients, "\'boczek 50g\', 300");
            db.SeedData(Tables.Ingredients, "\'ser żółty 100g\', 300");
            db.SeedData(Tables.Ingredients, "\'ketchup\', 100");
            db.SeedData(Tables.Ingredients, "\'ser biały 75g\', 200");
            db.SeedData(Tables.Ingredients, "\'krewetki 50g\', 400");
            db.SeedData(Tables.Ingredients, "\'zapiekane bakłażany 80g\', 200");
            db.SeedData(Tables.Ingredients, "\'płatki złota 1g\', 50000");
            db.SeedData(Tables.Ingredients, "\'trufle 10g\', 3500");
            db.SeedData(Tables.Ingredients, "\'masło orzechowe 35g\', 200");
            db.SeedData(Tables.Ingredients, "\'powidła śliwkowe 50g\', 200");

            db.SeedData(Tables.Refreshments, "\'woda 200ml\', 4");
            db.SeedData(Tables.Refreshments, "\'kawa 200ml\', 5");
            db.SeedData(Tables.Refreshments, "\'herbata 200ml\', 3");
            db.SeedData(Tables.Refreshments, "\'Pepsi 200ml\', 6");

            db.SeedData(Tables.Burgers, "\'Mario\'");
            db.SeedData(Tables.Burgers, "\'Luigi\'");
            db.SeedData(Tables.Burgers, "\'Space Invader\'");
            db.SeedData(Tables.Burgers, "\'Contra\'");

            db.SeedData(Tables.Compositions, "3,1");
            db.SeedData(Tables.Compositions, "4,1");
            db.SeedData(Tables.Compositions, "6,1");
            db.SeedData(Tables.Compositions, "10,1");
            db.SeedData(Tables.Compositions, "4,2");
            db.SeedData(Tables.Compositions, "6,2");
            db.SeedData(Tables.Compositions, "5,2");
            db.SeedData(Tables.Compositions, "3,3");
            db.SeedData(Tables.Compositions, "4,3");
            db.SeedData(Tables.Compositions, "6,3");
            db.SeedData(Tables.Compositions, "10,4");
            db.SeedData(Tables.Compositions, "9,4");
            db.SeedData(Tables.Compositions, "11,4");
            db.SeedData(Tables.Compositions, "12,4");

            return db;
        }


    }
}
