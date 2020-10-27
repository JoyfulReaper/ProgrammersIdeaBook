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
        public void DeleteAlarm(AlarmModel alarm)
        {
            using (IDbConnection connection = new SQLiteConnection(GlobalConfig.ConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@Id", alarm.Id);
                connection.Execute("DELETE FROM Alarms WHERE Id=@Id", p);
            }
        }

        public List<AlarmModel> GetAllAlarms()
        {
            using (IDbConnection connection = new SQLiteConnection(GlobalConfig.ConnectionString()))
            {
                var output = connection.Query<AlarmModel>("SELECT * FROM Alarms;");
                return output.ToList();
            }
        }

        public void SaveAlarm(AlarmModel alarm)
        {
            using (IDbConnection connection = new SQLiteConnection(GlobalConfig.ConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@AlarmDateTime", alarm.AlarmDateTime.ToString(CultureInfo.InvariantCulture));
                p.Add("@Message", alarm.Message);

                int lastId = (int)connection.QueryFirst<Int64>("INSERT INTO Alarms (AlarmDateTime, Message) VALUES (@AlarmDateTime, @Message); select last_insert_rowid();", alarm);
                alarm.Id = lastId;
            }
        }

        public static string CreateDataBase()
        {
            string sql = @"CREATE TABLE ""Alarms"" (
                          ""Id""    INTEGER NOT NULL UNIQUE,
                          ""AlarmDateTime"" TEXT NOT NULL,
	                      ""Message""   TEXT,
	                       PRIMARY KEY(""Id"" AUTOINCREMENT)
                           ); ";

            return sql;
        }
    }
}
