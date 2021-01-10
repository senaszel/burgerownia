using System;
using System.Collections.Generic;
using System.IO;
using Burgerownia.DataBase.SQLite.Extensions;
using Burgerownia.DataBase.SQLite.Enum;
using Microsoft.Data.Sqlite;

namespace Burgerownia.DataBase.SQLite
{
    public class SQLite_DB : IDB
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
        internal void RizeIt()
        {
            this.Rize();
        }

        /// <summary>
        /// Creates new table with statement passed in declaration.
        /// </summary>
        /// <param name="tableName">self explanatory</param>
        /// <param name="creationDeclaration"></param>
        internal void CreateTable(Tables tableName, string creationDeclaration)
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
        internal void SeedData(Tables tableName, string values)
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

        /// <summary>
        /// Gets all records from chosen table.
        /// </summary>
        /// <param name="fromTable">self explanatory</param>
        /// <returns></returns>
        public List<string> GetAll(Tables fromTable)
        {
            var result = new List<string>();
            using SqliteConnection connection = new SqliteConnection(_connectionStringBuilder.ConnectionString);
            connection.Open();
            SqliteCommand selectCmd = connection.CreateCommand().SelectAll(fromTable);
            using SqliteDataReader reader = selectCmd.ExecuteReader();
            while (reader.Read())
            {
                string newEntry = string.Empty;
                for (int col = 0; col < reader.FieldCount; col++)
                {
                    if (col == 0)
                        newEntry = reader.GetString(col);
                    else
                        newEntry += String.Concat(',', reader.GetString(col));
                }
                result.Add(newEntry);
            }

            return result;
        }

        public List<string> GetAll(int burger_id)
        {
            var result = new List<string>();
            using SqliteConnection connection = new SqliteConnection(_connectionStringBuilder.ConnectionString);
            connection.Open();
            SqliteCommand selectCmd = connection.CreateCommand().SelectIngredientsOfBurger(burger_id);
            using SqliteDataReader reader = selectCmd.ExecuteReader();
            while (reader.Read())
            {
                string newEntry = string.Empty;
                for (int col = 0; col < reader.FieldCount; col++)
                {
                    if (col == 0)
                        newEntry = reader.GetString(col);
                    else
                        newEntry += String.Concat(',', reader.GetString(col));
                }
                result.Add(newEntry);
            }

            return result;
        }



    }
}

