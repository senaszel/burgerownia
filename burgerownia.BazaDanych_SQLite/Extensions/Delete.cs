using Microsoft.Data.Sqlite;

namespace Burgerownia.DataBase.SQLite.Extensions
{
    public static class Delete
    {
        public static SqliteCommand DeleteTable(this SqliteCommand sqliteCommand, string tableName)
        {
            sqliteCommand.CommandText = $"DROP TABLE IF EXISTS {tableName}";
            return sqliteCommand;
        }

        
    }
}
