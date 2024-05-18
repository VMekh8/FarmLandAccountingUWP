using System.Data.SqlClient;
using System.IO;


namespace FarmLandAccountingUWP
{
    public sealed class DataBase
    {
        private SqlConnection _connection;

        public DataBase()
        {
            _connection = new SqlConnection(getDBConfig());
        }

        public void OpenConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
                _connection.Open();
        }

        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
                _connection.Close();
        }

        public SqlConnection GetConnection() => _connection;

        private string getDBConfig()
        {
            var config = File.ReadAllLines("config.txt");
            foreach (var line in config)
            {
                if (line.StartsWith("CONNECTION_STRING="))
                {
                    var connectionString = line.Substring("CONNECTION_STRING=".Length);
                    return connectionString;
                }
            }
            return null;
        }
    }
}
