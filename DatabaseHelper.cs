using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace StarBuko
{
    public static class DatabaseHelper
    {
        private static string connectionString =
            "Server=localhost;Database=starbuko;Uid=root;Pwd=root;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString); 
        }
    }
}