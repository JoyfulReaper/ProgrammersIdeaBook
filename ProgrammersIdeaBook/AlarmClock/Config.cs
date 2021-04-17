/*
MIT License

Copyright(c) 2020 Kyle Givler
https://github.com/JoyfulReaper

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using AlarmClock.DataAccess;
using Dapper;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace AlarmClock
{
    public enum DatabaseType
    {
        SQLite
    }

    public class Config : IConfig
    {
        public const string version = "0.1.0";
        public const string SQLitePath = ".\\";
        public const string SQLiteFile = "Alarms.db";
        public IDataConnection Connection { get; private set; }
        public DatabaseType DatabaseType { get; } = DatabaseType.SQLite;

        public Config()
        {
            InitializeConnection(DatabaseType.SQLite);
        }

        public void InitializeConnection(DatabaseType db)
        {
            if (db == DatabaseType.SQLite)
            {
                Connection = new SQLiteConnector(this);
                if (!File.Exists($"{ SQLitePath}{ SQLiteFile}"))
                {
                    using (IDbConnection connection = new SQLiteConnection(ConnectionString()))
                    {
                        connection.Execute(SQLiteConnector.CreateDataBase());
                    }
                }
            }
            else
            {
                throw new ArgumentException($"Unsupported database type provided.", nameof(db));
            }

        }

        public string ConnectionString()
        {
            return $"DataSource={SQLitePath}{SQLiteFile};Version=3";
        }
    }
}
