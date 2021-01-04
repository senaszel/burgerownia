using System;
using System.IO;
using Burgerownia.DataBase.SQLite.Extensions;
using Microsoft.Data.Sqlite;

namespace Burgerownia.DataBase.SQLite
{
    public class SQLite_DB
    {
        /// <summary>
        /// connection string | path to db.
        /// </summary>
        internal SqliteConnectionStringBuilder _connectionStringBuilder;

        /// <summary>
        /// Creates database connection. If exists proceeds in ReadWrite Mode. Otherwise Creates with batch of initial data.
        /// </summary>
        public SQLite_DB()
        {
            _connectionStringBuilder = new SqliteConnectionStringBuilder();
            if (!File.Exists("./SqliteDB.db"))
            {
                _connectionStringBuilder.Mode = SqliteOpenMode.ReadWriteCreate;
                _connectionStringBuilder.DataSource = "./SqliteDB.db";
                this.CreateDB();
            }
            else
            {
                _connectionStringBuilder.Mode = SqliteOpenMode.ReadWrite;
                _connectionStringBuilder.DataSource = "./SqliteDB.db";
            }
        }

        /// <summary>
        /// Rizes db file.
        /// </summary>
        public void RizeIt()
        {
            this.Rize();
        }

        /// <summary>
        /// Creates new table with statement passed in declaration.
        /// </summary>
        /// <param name="tableName">self explanatory</param>
        /// <param name="creationDeclaration"></param>
        public void CreateTable(string tableName, string creationDeclaration)
        {
            using SqliteConnection connection = new SqliteConnection(_connectionStringBuilder.ConnectionString);
            connection.Open();
            connection
                .CreateCommand()
                .CreateTable(tableName, creationDeclaration)
                .ExecuteNonQuery();
        }

        /// <summary>
        /// Seeds db's chosen table with data.
        /// </summary>
        /// <param name="tableName">self explanatory</param>
        /// <param name="values">record's data</param>
        public void SeedData(string tableName, string values)
        {
            using var connection = new SqliteConnection(_connectionStringBuilder.ConnectionString);
            connection.Open();
            using var transaction = connection.BeginTransaction();
            connection
                .CreateCommand()
                .InsertInto(tableName, values)
                .ExecuteNonQuery();

            transaction.Commit();
        }
        public void ReadData(string fromTable)
        {
            using SqliteConnection connection = new SqliteConnection(_connectionStringBuilder.ConnectionString);
            connection.Open();
            SqliteCommand selectCmd = connection.CreateCommand().SelectAll(fromTable);
            using SqliteDataReader reader = selectCmd.ExecuteReader();
            while (reader.Read())
            {
                var message = reader.GetString(0);
                var message2 = reader.GetString(1);
                var message3 = reader.GetString(2);
                Console.Write(message);
                Console.Write(" ");
                Console.Write(message2);
                Console.Write(" ");
                Console.Write(message3);
                Console.WriteLine(" zł");
            }
        }



    }
}

