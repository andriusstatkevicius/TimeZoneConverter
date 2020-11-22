using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using TimeZoneConvertUtilities.Models;

namespace TimeZoneConvertUtilities
{
    public class DataRepository
    {
        private readonly string _connectionString;

        public DataRepository()
        {
            _connectionString = Environment.GetEnvironmentVariable("timeZoneSqlConnection");
        }

        public List<IanaTimeZoneEntry> GetDataEntries()
        {
            List<IanaTimeZoneEntry> dataEntries;
            string query = "Select * FROM TimeZoneEntries";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                dataEntries = connection.Query<IanaTimeZoneEntry>(query).ToList();
            }

            return dataEntries;
        }

        public void InsertEntries(List<IanaTimeZoneEntry> entries)
        {
            string query = "INSERT INTO TimeZoneEntries (IANATimeZoneID, WinTimeZoneID) Values (@IANAID, @WINID);";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var affectedRows = connection.Execute(query, entries.Select(entry => new { IANAID = entry.IANATimeZoneID, WINID = entry.WinTimeZoneID }).ToArray());
            }
        }
    }
}
