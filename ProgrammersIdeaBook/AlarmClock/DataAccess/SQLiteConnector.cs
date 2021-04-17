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

using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;

namespace AlarmClock.DataAccess
{
    public class SQLiteConnector : IDataConnection
    {
        private readonly IConfig _config;

        public SQLiteConnector(IConfig config)
        {
            _config = config;
        }

        public void DeleteAlarm(AlarmModel alarm)
        {
            using (IDbConnection connection = new SQLiteConnection(_config.ConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@Id", alarm.Id);
                connection.Execute("DELETE FROM Alarms WHERE Id=@Id", p);
            }
        }

        public List<AlarmModel> GetAllAlarms()
        {
            using (IDbConnection connection = new SQLiteConnection(_config.ConnectionString()))
            {
                var output = connection.Query<AlarmModel>("SELECT * FROM Alarms;");
                return output.ToList();
            }
        }

        public void SaveAlarm(AlarmModel alarm)
        {
            using (IDbConnection connection = new SQLiteConnection(_config.ConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@AlarmDateTime", alarm.AlarmDateTime.ToString(CultureInfo.InvariantCulture));
                p.Add("@Message", alarm.Message);
                p.Add("@Name", alarm.Name);

                int lastId = (int)connection.QueryFirst<Int64>("INSERT INTO Alarms (AlarmDateTime, Name, Message) VALUES (@AlarmDateTime, @Name, @Message); select last_insert_rowid();", alarm);
                alarm.Id = lastId;
            }
        }

        public static string CreateDataBase()
        {
            string sql = @"CREATE TABLE ""Alarms"" (
                          ""Id""    INTEGER NOT NULL UNIQUE,
                          ""Name"" TEXT NOT NULL,
                          ""AlarmDateTime"" TEXT NOT NULL,
	                      ""Message""   TEXT,
	                       PRIMARY KEY(""Id"" AUTOINCREMENT)
                           ); ";

            return sql;
        }
    }
}
