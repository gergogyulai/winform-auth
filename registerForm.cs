using static login.Auth;

namespace login
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
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

            if (!Utils.ValidateUserInput(username, email, password, passwordConfirm))
            {
                MessageBox.Show("One of the required fields is empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != passwordConfirm)
            {
                MessageBox.Show("Passwords don't match", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var (success, errorMessage) = CreateUser(username, email, password);
            
            if (success)
            {
                MessageBox.Show("User registered successfully!", "Registration Success",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearRegisterTextFields();
            }
            else
            {
                MessageBox.Show(errorMessage, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            new loginForm().Show();
            this.Hide();
        }
    }
}
