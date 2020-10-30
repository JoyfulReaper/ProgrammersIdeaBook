using AlarmClock.DataAccess;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Text;

namespace AlarmClock
{
    public enum DatabaseType
    {
        SQLite
    }

    public static class GlobalConfig
    {
        public const string version = "0.0.3";
        public const string SQLitePath = ".\\";
        public const string SQLiteFile = "Alarms.db";
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnection(DatabaseType db)
        {
            if(db == DatabaseType.SQLite)
            {
                Connection = new SQLiteConnector();
                if (!File.Exists($"{ SQLitePath}{ SQLiteFile}"))
                {
                    using (IDbConnection connection = new SQLiteConnection(GlobalConfig.ConnectionString()))
                    {
                        connection.Execute(SQLiteConnector.CreateDataBase());
                    }
                }
            }
        }

        public static string ConnectionString()
        {
            return $"DataSource={SQLitePath}{SQLiteFile};Version=3";
        }
    }
}
