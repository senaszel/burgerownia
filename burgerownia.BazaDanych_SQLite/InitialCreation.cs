using Burgerownia.DataBase.SQLite.Extensions;
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
            db.CreateTable("Refreshments", "id INTEGER PRIMARY KEY AUTOINCREMENT ,name VARCHAR(50) NOT NULL, price INTEGER NOT NULL");
            db.CreateTable("Ingredients", "id INTEGER PRIMARY KEY AUTOINCREMENT ,name VARCHAR(50) NOT NULL, price INTEGER NOT NULL");

            db.SeedData("Ingredients", "\'bułka przenna 100g\', 3");
            db.SeedData("Ingredients", "\'bułka razowa 100g\', 5");
            db.SeedData("Ingredients", "\'mięso wołowe 180g\', 6");
            db.SeedData("Ingredients", "\'mięso drobiowe 180g\', 5");
            db.SeedData("Ingredients", "\'mięso wieprzowe 180g\', 5");
            db.SeedData("Ingredients", "\'zestaw sałat 30g\', 3");
            db.SeedData("Ingredients", "\'jajko sadzone 1szt\', 2");
            db.SeedData("Ingredients", "\'boczek 50g\', 3");
            db.SeedData("Ingredients", "\'ser żółty 100g\', 3");
            db.SeedData("Ingredients", "\'ketchup\', 1");
            db.SeedData("Ingredients", "\'ser biały 75g\', 2");
            db.SeedData("Ingredients", "\'krewetki 50g\', 4");
            db.SeedData("Ingredients", "\'zapiekane bakłażany 80g\', 2");
            db.SeedData("Ingredients", "\'płatki złota 1g\', 50");
            db.SeedData("Ingredients", "\'trufle 15g\', 35");
            db.SeedData("Ingredients", "\'masło orzechowe 35g\', 2");
            db.SeedData("Ingredients", "\'powidła śliwkowe 50g\', 2");

            db.SeedData("Refreshments", "\'woda 200ml\', 4");
            db.SeedData("Refreshments", "\'kawa 200ml\', 5");
            db.SeedData("Refreshments", "\'herbata 200ml\', 3");
            db.SeedData("Refreshments", "\'Pepsi 200ml\', 6");


            return db;
        }


    }
}
