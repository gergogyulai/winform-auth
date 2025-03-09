using MySql.Data.MySqlClient;

namespace login
{
    public class Database
    {
        private const string connectionString = "Server=localhost;Database=auth;Uid=root; Password=;SslMode=None";
        public static List<User> GetUsers()
        {
            var users = new List<User>();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT `Id`, `UserName`, `Email`, `Role` FROM `users`;";
                using (var command = new MySqlCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User
                            {
                                Id = reader.GetInt32(0),
                                Username = reader.GetString(1),
                                Email = reader.GetString(2),
                                Role = reader.GetInt32(3)
                            });
                        }
                    }
                }
            }
            return users;
        }
    }

    public class Auth
    {
        private const string ConnectionString = "Server=localhost;Database=auth;Uid=root; Password=;SslMode=None";

        public static (bool Success, string ErrorMessage) CreateUser(string username, string email, string password)
        {
            // Check if username or email already exists
            var (exists, field) = UserExistsCheck(username, email);
            if (exists)
            {
                return (false, $"This {field} already exists in the database.");
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password.Trim());

            try
            {
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

                return (true, string.Empty);
            }
            catch (MySqlException ex)
            {
                return (false, $"Database error: {ex.Message}");
            }
        }

        public static (bool Success, string ErrorMessage) admin_createUser(string username, string email, string password, string role)
        {
            // Check if username or email already exists
            var (exists, field) = UserExistsCheck(username, email);
            if (exists)
            {
                return (false, $"This {field} already exists in the database.");
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password.Trim());

            try
            {
                using (var connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO users(username, email, password, role) VALUES (@username, @email, @password, @role)";
                    string convertedRole = role == "Admin" ? "1" : "0";

                    using (var command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@username", username.Trim());
                        command.Parameters.AddWithValue("@email", email.Trim());
                        command.Parameters.AddWithValue("@password", hashedPassword);
                        command.Parameters.AddWithValue("@role", convertedRole);
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                return (true, string.Empty);
            }
            catch (MySqlException ex)
            {
                return (false, $"Database error: {ex.Message}");
            }
        }

        private static (bool Exists, string Field) UserExistsCheck(string username, string email)
        {
            using var connection = new MySqlConnection(ConnectionString);
            connection.Open();

            string sqlUsername = "SELECT COUNT(*) FROM users WHERE username = @username";
            using (var command = new MySqlCommand(sqlUsername, connection))
            {
                command.Parameters.AddWithValue("@username", username.Trim());
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    return (true, "username");
                }
            }

            string sqlEmail = "SELECT COUNT(*) FROM users WHERE email = @email";
            using (var command = new MySqlCommand(sqlEmail, connection))
            {
                command.Parameters.AddWithValue("@email", email.Trim());
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    return (true, "email");
                }
            }

            return (false, string.Empty);
        }

        public static bool admin_updateUser(string id, string username, string email, string role)
        {
            using (var connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string sql = "UPDATE users SET username=@username, email=@email, role=@role WHERE id=@id";
                int convertedRole = role == "Admin" ? 1 : 0;

                using (var command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@username", username.Trim());
                    command.Parameters.AddWithValue("@email", email.Trim());
                    command.Parameters.AddWithValue("@role", convertedRole);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            return true;
        }

        public static bool admin_deleteUser(string id)
        {
            using (var connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string sql = "DELETE FROM users WHERE id=@id";

                using (var command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            return true;
        }

        public static User GetUserByUsername(string username)
        {
            using var connection = new MySqlConnection(ConnectionString);
            connection.Open();

            const string sql = "SELECT Id, Username, Email, Role, Password FROM users WHERE Username=@username";
            using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@username", username.Trim());

            using var reader = command.ExecuteReader();
            if (!reader.Read()) return null;

            return new User
            {
                Id = reader.GetInt32("Id"),
                Username = reader.GetString("Username"),
                Email = reader.GetString("Email"),
                Role = reader.GetInt32("Role")
            };
        }

        public static bool VerifyUser(string username, string password)
        {
            using var connection = new MySqlConnection(ConnectionString);
            connection.Open();

            const string sql = "SELECT Password FROM users WHERE Username=@username";
            using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@username", username.Trim());

            using var reader = command.ExecuteReader();
            if (!reader.Read()) return false;

            string passwordHash = reader.GetString("Password");

            return BCrypt.Net.BCrypt.Verify(password, passwordHash);
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int Role { get; set; }
    }

    public class Utils
    {
        public static int ConvertRoleToInt(string role)
        {
            return role == "Admin" ? 1 : 0;
        }

        public static string ConvertRoleToString(int role)
        {
            return role == 1 ? "Admin" : "User";
        }

        public static bool ValidateUserInput(params string[] inputs)
        {
            foreach (var input in inputs)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    return false;
                }
            }
            return true;
        }
    }
}