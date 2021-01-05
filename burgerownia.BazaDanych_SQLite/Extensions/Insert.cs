using Microsoft.Data.Sqlite;
using Burgerownia.DataBase.SQLite.Enum;

namespace Burgerownia.DataBase.SQLite.Extensions
{
    public static class Insert
    {
        /// <summary>
        /// Inserts record passed as values into chosen table.
        /// </summary>
        /// <param name="sqliteCommand"></param>
        /// <param name="tableName">self explanatory</param>
        /// <param name="values">records data</param>
        /// <returns></returns>
        public static SqliteCommand InsertInto(this SqliteCommand sqliteCommand, Tables tableName, string values)
        {
            switch (tableName)
            {
                case Tables.Ingredients:
                    sqliteCommand.CommandText = $"INSERT INTO {tableName}(nameof, price) VALUES({values})";
                    break;
                case Tables.Refreshments:
                    sqliteCommand.CommandText = $"INSERT INTO {tableName}(nameof, price) VALUES({values})";
                    break;
                case Tables.Burgers:
                    sqliteCommand.CommandText = $"INSERT INTO {tableName}(nameof) VALUES({values})";
                    break;
                case Tables.Compositions:
                    sqliteCommand.CommandText = $"INSERT INTO {tableName}(ingredient_id, burger_id) VALUES({values})";
                    break;
            }

            return sqliteCommand;
        }



    }
}
