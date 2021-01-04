using Microsoft.Data.Sqlite;
using System;

namespace Burgerownia.DataBase.SQLite.Extensions
{
    public static class Select
    {
        public static SqliteCommand SelectAll(this SqliteCommand sqliteCommand, string tableName)
        {
            sqliteCommand.CommandText = String.Format("SELECT * FROM {0}",tableName);
            return sqliteCommand;
        }


    }
}
