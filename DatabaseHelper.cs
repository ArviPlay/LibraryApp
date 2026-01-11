using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace LibraryAppForProject
{
    public static class DatabaseHelper
    {
        private static string dbPath = "library.db";
        private static string connectionString = $"Data Source={dbPath};Version=3;";

        public static event Action OnDatabaseChanged;

        public static void Initialize()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createTables = @"
                   CREATE TABLE IF NOT EXISTS Books (
                     Id INTEGER PRIMARY KEY AUTOINCREMENT,
                     Author TEXT,
                     Title TEXT
                   );
                   CREATE TABLE IF NOT EXISTS Clients (
                     Id INTEGER PRIMARY KEY AUTOINCREMENT,
                     Name TEXT,
                     Phone TEXT,
                     BirthDate TEXT
                   );
                   CREATE TABLE IF NOT EXISTS Issues (
                     IssueId INTEGER PRIMARY KEY AUTOINCREMENT,
                     ClientId INTEGER,
                     BookId INTEGER,
                     BorrowDate TEXT,
                     DueDate TEXT,
                     ReturnDate TEXT,
                     FOREIGN KEY (ClientId) REFERENCES Clients(Id),
                     FOREIGN KEY (BookId) REFERENCES Books(Id)
                   );
                   CREATE TABLE IF NOT EXISTS Reports (
                     Id INTEGER PRIMARY KEY AUTOINCREMENT,
                     Name TEXT,
                     Period TEXT,
                     GeneratedDate TEXT,
                     RecordsCount INTEGER
                   );";

                ExecuteNonQuery(createTables, connection);
            }
        }

        public static void ExecuteNonQuery(string query, SQLiteConnection connection)
        {
            using (var command = new SQLiteCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public static void NotifyChanges()
        {
            OnDatabaseChanged?.Invoke();
        }

        public static SQLiteDataReader ExecuteReader(string query, SQLiteConnection connection)
        {
            var command = new SQLiteCommand(query, connection);
            return command.ExecuteReader();
        }

        public static object ExecuteScalar(string query, SQLiteConnection connection)
        {
            var command = new SQLiteCommand(query, connection);
            return command.ExecuteScalar();
        }

        public static SQLiteConnection GetConnection()
        {
            var connection = new SQLiteConnection(connectionString);
            connection.Open();
            return connection;
        }

        public static int GetCount(string tableName)
        {
            string query = $"SELECT COUNT(*) FROM {tableName}";
            return Convert.ToInt32(ExecuteScalar(query, GetConnection()));
        }
    }
}