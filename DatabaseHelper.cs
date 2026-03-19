using MySql.Data.MySqlClient;

namespace StarBuko
{
    public static class DatabaseHelper
    {
        private static string connectionString =
            "Server=localhost;Database=starbuko_db;Uid=root;Pwd=root;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}