using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;


namespace login
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private const string ConnectionString = "Server=localhost;Database=auth;Uid=root; Password=;SslMode=None";

        private void CreateUser(string username, string email, string password)
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
        }

        private void ClearRegisterTextFields()
        {
            usernameTextBox.Text = "";
            emailTextBox.Text = "";
            passwordTextBox.Text = "";
            passwordConfirmTextBox.Text = "";
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;
            string passwordConfirm = passwordConfirmTextBox.Text;

            if (!string.IsNullOrWhiteSpace(username) &&
                !string.IsNullOrWhiteSpace(email) &&
                !string.IsNullOrWhiteSpace(password) &&
                !string.IsNullOrWhiteSpace(passwordConfirm))
            {
                if (password == passwordConfirm)
                {
                    CreateUser(username, email, password);
                    ClearRegisterTextFields();
                }
                else
                {
                    MessageBox.Show("Passwords dont match");
                }
            }
            else
            {
                MessageBox.Show("One of the required fields is empty");
            }
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            new loginForm().Show();
            this.Hide();
        }
    }
}
