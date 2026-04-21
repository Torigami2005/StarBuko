using MySql.Data.MySqlClient;
using System.Configuration;

namespace StarBuko
{
    public static class DatabaseHelper
    {
        private static string connectionString =
            ConfigurationManager.ConnectionStrings["StarBukoDb"].ConnectionString;

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}