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
        public static SqliteCommand SelectAll(this SqliteCommand sqliteCommand, Tables tableName)
        {
            sqliteCommand.CommandText = String.Format($"SELECT * FROM {tableName}");
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
