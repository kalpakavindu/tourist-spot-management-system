using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tourist_spot_management_system
{
    internal class Database
    {
        private readonly string _connectionString;
        private readonly SqlConnection _connection;
        private readonly SqlCommand _command;
        private DataTable _dataTable;
        private SqlDataAdapter _dataAdapter;

        public Database()
        {
            _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\data\SQLDatabaseFiles\DB_TouristManagementSystem_CS.mdf;Integrated Security=True;Connect Timeout=30";
            _connection = new SqlConnection(_connectionString); 
            _command = new SqlCommand
            {
                Connection = _connection
            };
        }

        public DataTable GetData(string query)
        {
            _dataTable = new DataTable();
            _dataAdapter = new SqlDataAdapter(query, _connectionString);
            _dataAdapter.Fill(_dataTable);
            return _dataTable;
        }

        public int SetData(string query)
        {
            int cnt;
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            _command.CommandText = query;
            cnt = _command.ExecuteNonQuery();

            return cnt;
        }
    }
}
