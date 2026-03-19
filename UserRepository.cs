using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.Windows.Forms;

namespace StarBuko
{
    public class UserRepository
    {
        public User Login(string username, string password)
        {
            string hashedPassword = PasswordHelper.HashPassword(password);

            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            string query = "SELECT user_id, username, role FROM users WHERE username=@u AND password=@p";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@u", username);
            cmd.Parameters.AddWithValue("@p", hashedPassword);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new User
                {
                    UserId = reader.GetInt32("user_id"),
                    Username = reader.GetString("username"),
                    Role = reader.GetString("role")
                };
            }
            return null;
        }
    }
}
