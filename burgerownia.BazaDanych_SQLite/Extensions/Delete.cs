using Microsoft.Data.Sqlite;

namespace Burgerownia.DataBase.SQLite.Extensions
{
    public static class Delete
    {
        /// <summary>
        /// Deletes chosen table.
        /// </summary>
        /// <param name="sqliteCommand"></param>
        /// <param name="tableName">self explanatory</param>
        /// <returns></returns>
        public static SqliteCommand DeleteTable(this SqliteCommand sqliteCommand, string tableName)
        {
            sqliteCommand.CommandText = $"DROP TABLE IF EXISTS {tableName}";
            return sqliteCommand;
        }

        
    }
}
