namespace login
{
    public partial class userForm : Form
    {
        public userForm()
        {
            InitializeComponent();
            CheckLoginStatus();
            LoadUserData();
        }

        private void CheckLoginStatus()
        {
            if (!SessionManager.IsLoggedIn)
            {
                MessageBox.Show("You must be logged in to access this page.", "Access Denied", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                this.Close();
                new loginForm().Show();
            }
        }

        private void LoadUserData()
        {
            if (SessionManager.IsLoggedIn)
            {
                User currentUser = SessionManager.CurrentUser;
                welcomeLabel.Text = $"Welcome, {currentUser.Username}!";
                userDetailsLabel.Text = $"Email: {currentUser.Email}\nRole: {Utils.ConvertRoleToString(currentUser.Role)}";
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            SessionManager.Logout();
            MessageBox.Show("You have been logged out successfully.");
            this.Close();
            new loginForm().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
