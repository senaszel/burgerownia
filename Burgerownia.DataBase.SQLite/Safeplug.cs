using Burgerownia.DataBase.SQLite.Extensions;
using Microsoft.Data.Sqlite;
using System.IO;

namespace Burgerownia.DataBase.SQLite
{
    public static class Safeplug
    {
        /// <summary>
        /// Safeplug to rize db file if ever neccessary.
        /// </summary>
        /// <param name="db">Extension method</param>
        /// <returns></returns>
        public static SQLite_DB Rize(this SQLite_DB db)
        {
            File.Delete("./SqliteDB.db");

            return db;
        }
    }
}
