using MySql.Data.MySqlClient;

namespace login
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
            CheckAdminAccess();
            LoadAdminData();
            InitializeUserListView();
            ReadUsersFromDatabase();
        }

        private void CheckAdminAccess()
        {
            if (!SessionManager.IsLoggedIn || !SessionManager.IsAdmin)
            {
                MessageBox.Show("You must be an admin to access this page.", "Access Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.Close();
                new loginForm().Show();
            }
        }

        private void LoadAdminData()
        {
            adminWelcomeLabel.Text = $"Welcome, {SessionManager.CurrentUser.Username}!";
            adminLabel.Text = $"Email: {SessionManager.CurrentUser.Email}";
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            SessionManager.Logout();
            MessageBox.Show("You have been logged out successfully.");
            this.Close();
            new loginForm().Show();
        }

        private void InitializeUserListView()
        {
            userList.View = View.Details;
            userList.FullRowSelect = true;
            userList.Columns.Add("Id", 50);
            userList.Columns.Add("Username", 100);
            userList.Columns.Add("Email", 150);
            userList.Columns.Add("Role", 50);
        }

        private void ReadUsersFromDatabase()
        {
            try
            {
                userList.Items.Clear();
                Database.GetUsers().ForEach(user =>
                {
                    var listItem = new ListViewItem([
                        user.Id.ToString(),
                        user.Username,
                        user.Email,
                        Utils.ConvertRoleToString(user.Role)
                    ]);
                    userList.Items.Add(listItem);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearCreationTextFields()
        {
            creationRoleCombobox.Text = "";
            creationUsernameTextbox.Text = "";
            creationEmailTextbox.Text = "";
            creationPasswordTextbox.Text = "";
            creationConfirmPasswordTextbox.Text = "";
        }

        private void ClearUpdateTextFields()
        {
            updateRoleCombobox.Text = "";
            updateEmailTextbox.Text = "";
            updateUsernameTextbox.Text = "";
        }

        string selectedUserId = "";
        private void userList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedItem = userList.SelectedItems[0];

            if (selectedItem != null)
            {
                selectedUserId = selectedItem.SubItems[0].Text;
                updateUsernameTextbox.Text = selectedItem.SubItems[1].Text;
                updateEmailTextbox.Text = selectedItem.SubItems[2].Text;
                updateRoleCombobox.Text = selectedItem.SubItems[3].Text;

                tabControl1.SelectedTab = tabControl1.TabPages["update"];
            }
        }

        private void creationButton_Click(object sender, EventArgs e)
        {
            string username = creationUsernameTextbox.Text;
            string email = creationEmailTextbox.Text;
            string password = creationPasswordTextbox.Text;
            string confirmPassword = creationConfirmPasswordTextbox.Text;
            string role = creationRoleCombobox.Text;

            if (!Utils.ValidateUserInput(username, email, password, confirmPassword, role))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords don't match");
                return;
            }

            if (role != "Admin" && role != "User")
            {
                MessageBox.Show("Invalid role. Role must be either 'Admin' or 'User'.");
                return;
            }

            var (success, errorMessage) = Auth.admin_createUser(username, email, password, role);
            
            if (!success)
            {
                MessageBox.Show(errorMessage, "User Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearCreationTextFields();
            ReadUsersFromDatabase();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string username = updateUsernameTextbox.Text;
            string email = updateEmailTextbox.Text;
            string role = updateRoleCombobox.Text;

            if (Utils.ValidateUserInput(username, email, role))
            {
                if (role == "Admin" || role == "User")
                {
                    Auth.admin_updateUser(selectedUserId, username, email, role);
                    ClearCreationTextFields();
                    ClearUpdateTextFields();
                    ReadUsersFromDatabase();
                }
                else
                {
                    MessageBox.Show("Invalid role. Role must be either 'Admin' or 'User'.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = userList.SelectedItems[0];

                string userId = selectedItem.SubItems[0].Text;
                string username = selectedItem.SubItems[1].Text;

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete this user ({username})?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    userList.Items.Remove(selectedItem);
                    Auth.admin_deleteUser(userId);
                    ReadUsersFromDatabase();
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void adminLabel_Click(object sender, EventArgs e)
        {

        }
    }
}