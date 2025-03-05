using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace login
{
    internal class Auth
    {
        private const string ConnectionString = "Server=localhost;Database=auth;Uid=root; Password=;SslMode=None";

        public static bool CreateUser(string username, string email, string password)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password.Trim());

            using (var connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string sql = "INSERT INTO users(username, email, password) VALUES (@username, @email, @password)";

                using (var command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@username", username.Trim());
                    command.Parameters.AddWithValue("@email", email.Trim());
                    command.Parameters.AddWithValue("@password", hashedPassword);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            return true;
        }

        public static bool VerifyUser(string email, string password)
        {

            using (var connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string sql = "SELECT password_hash FROM users WHERE email=@email";

                using (var command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@email", email.Trim());
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            return true;
        }
    }
}
