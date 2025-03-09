using static login.Auth;

namespace login
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            new registerForm().Show();
            this.Hide();
        }
        
        private void ClearTextFields()
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (!Utils.ValidateUserInput(username, password))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            if (!VerifyUser(username, password))
            {
                MessageBox.Show("Login failed");
                ClearTextFields();
                return;
            }

            User user = GetUserByUsername(username);
            if (user == null)
            {
                MessageBox.Show("User not found");
                return;
            }
            
            ProcessSuccessfulLogin(user);
        }
        
        private void ProcessSuccessfulLogin(User user)
        {
            ClearTextFields();
            SessionManager.Login(user);
            
            if (SessionManager.IsAdmin)
            {
                new adminForm().Show();
            }
            else
            {
                new userForm().Show();
            }
            
            this.Hide();
        }
    }
}
