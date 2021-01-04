using Microsoft.Data.Sqlite;

namespace Burgerownia.DataBase.SQLite.Extensions
{
    public static class Create
    {
        public static SqliteCommand CreateTable(this SqliteCommand sqliteCommand, string tableName, string creationDeclaration)
        {
            sqliteCommand.CommandText = $"CREATE TABLE {tableName} ({creationDeclaration})";

            return sqliteCommand;
        }
    }
}
