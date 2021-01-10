using Microsoft.Data.Sqlite;
using Burgerownia.DataBase.SQLite.Enum;
using System;

namespace Burgerownia.DataBase.SQLite.Extensions
{
    public static class Select
    {
        /// <summary>
        /// Gets all records from chosen table.
        /// </summary>
        /// <param name="sqliteCommand"></param>
        /// <param name="tableName">Self explanatory</param>
        /// <returns></returns>
        public static SqliteCommand SelectSafelyAll(this SqliteCommand sqliteCommand, Tables tableName)
        {
            switch (tableName)
            {
                case Tables.Ingredients:
                    sqliteCommand.CommandText = $"SELECT {tableName}.id,{tableName}.nameof, {tableName}.price FROM {tableName}";
                    break;
                case Tables.Refreshments:
                    sqliteCommand.CommandText = $"SELECT {tableName}.id,{tableName}.nameof, {tableName}.price FROM {tableName}";
                    break;
                case Tables.Burgers:
                    sqliteCommand.CommandText = $"SELECT {tableName}.id,{tableName}.nameof FROM {tableName}";
                    break;
                case Tables.Compositions:
                    sqliteCommand.CommandText = $"SELECT {Tables.Compositions}.id, {Tables.Compositions}.ingredient_id , {Tables.Compositions}.burger_id FROM {Tables.Compositions}";
                    break;
                case Tables.BurgersFullInfo:
                    // todo test
                    sqliteCommand.CommandText = $"SELECT {Tables.Compositions}.ingredient_id, {Tables.Compositions}.burger_id FROM {Tables.Compositions}";
                    break;
            }

            return sqliteCommand;
        }

        /// <summary>
        /// Gets all of Ingredient's ids assosiated with passed burger's id.
        /// </summary>
        /// <param name="sqliteCommand"></param>
        /// <param name="burger_id">Burger's id</param>
        /// <returns></returns>
        public static SqliteCommand SelectIngredientsOfBurger(this SqliteCommand sqliteCommand, int burger_id)
        {
            sqliteCommand.CommandText = $"SELECT Ingredients.id FROM Compositions JOIN Ingredients ON Ingredients.id = Compositions.ingredient_id WHERE Compositions.burger_id = {burger_id}";
            return sqliteCommand;
        }


    }
}
