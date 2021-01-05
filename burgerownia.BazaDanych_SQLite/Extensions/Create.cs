using Microsoft.Data.Sqlite;
using Burgerownia.DataBase.SQLite.Enum;

namespace Burgerownia.DataBase.SQLite.Extensions
{
    public static class Create
    {
        /// <summary>
        /// Creates table of chosen name with passed declaration.
        /// </summary>
        /// <param name="sqliteCommand"></param>
        /// <param name="tableName">self explanatory</param>
        /// <param name="creationDeclaration">self explanatory</param>
        /// <returns></returns>
        public static SqliteCommand CreateTable(this SqliteCommand sqliteCommand, Tables tableName, string creationDeclaration)
        {
            sqliteCommand.CommandText = $"CREATE TABLE {tableName} ({creationDeclaration})";

            return sqliteCommand;
        }
    }
}
