using Microsoft.Data.Sqlite;

namespace Burgerownia.DataBase.SQLite.Extensions
{
    public static class Insert
    {
        public static SqliteCommand InsertInto(this SqliteCommand sqliteCommand, string tableName, string values)
        {
            switch (tableName)
            {
                case "Ingredients":
                    sqliteCommand.CommandText = $"INSERT INTO {tableName}(name, price) VALUES({values})";
                    break;
                case "Refreshments":
                    sqliteCommand.CommandText = $"INSERT INTO {tableName}(name, price) VALUES({values})";
                    break;
            }

            return sqliteCommand;
        }



    }
}
