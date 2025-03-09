namespace login
{
    partial class adminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            userList = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteUserToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            create = new TabPage();
            creationButton = new Button();
            creationConfirmPasswordTextbox = new TextBox();
            label5 = new Label();
            creationPasswordTextbox = new TextBox();
            label4 = new Label();
            creationUsernameTextbox = new TextBox();
            label3 = new Label();
            creationEmailTextbox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            creationRoleCombobox = new ComboBox();
            update = new TabPage();
            updateButton = new Button();
            updateUsernameTextbox = new TextBox();
            label8 = new Label();
            updateEmailTextbox = new TextBox();
            label9 = new Label();
            label10 = new Label();
            updateRoleCombobox = new ComboBox();
            adminWelcomeLabel = new Label();
            logoutButton = new Button();
            adminLabel = new Label();
            contextMenuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            create.SuspendLayout();
            update.SuspendLayout();
            SuspendLayout();
            // 
            // userList
            // 
            userList.ContextMenuStrip = contextMenuStrip1;
            userList.Location = new Point(12, 64);
            userList.Name = "userList";
            userList.Size = new Size(420, 426);
            userList.TabIndex = 1;
            userList.UseCompatibleStateImageBehavior = false;
            userList.MouseDoubleClick += userList_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteUserToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(134, 26);
            // 
            // deleteUserToolStripMenuItem
            // 
            deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            deleteUserToolStripMenuItem.Size = new Size(133, 22);
            deleteUserToolStripMenuItem.Text = "Delete User";
            deleteUserToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(create);
            tabControl1.Controls.Add(update);
            tabControl1.Location = new Point(438, 64);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(350, 426);
            tabControl1.TabIndex = 9;
            // 
            // create
            // 
            create.Controls.Add(creationButton);
            create.Controls.Add(creationConfirmPasswordTextbox);
            create.Controls.Add(label5);
            create.Controls.Add(creationPasswordTextbox);
            create.Controls.Add(label4);
            create.Controls.Add(creationUsernameTextbox);
            create.Controls.Add(label3);
            create.Controls.Add(creationEmailTextbox);
            create.Controls.Add(label2);
            create.Controls.Add(label1);
            create.Controls.Add(creationRoleCombobox);
            create.Location = new Point(4, 24);
            create.Name = "create";
            create.Padding = new Padding(3);
            create.Size = new Size(342, 398);
            create.TabIndex = 0;
            create.Text = "Create user";
            create.UseVisualStyleBackColor = true;
            // 
            // creationButton
            // 
            creationButton.Location = new Point(6, 369);
            creationButton.Name = "creationButton";
            creationButton.Size = new Size(330, 23);
            creationButton.TabIndex = 22;
            creationButton.Text = "Create User";
            creationButton.UseVisualStyleBackColor = true;
            creationButton.Click += creationButton_Click;
            // 
            // creationConfirmPasswordTextbox
            // 
            creationConfirmPasswordTextbox.Location = new Point(6, 197);
            creationConfirmPasswordTextbox.Name = "creationConfirmPasswordTextbox";
            creationConfirmPasswordTextbox.Size = new Size(330, 23);
            creationConfirmPasswordTextbox.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 179);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 20;
            label5.Text = "Confirm Password";
            // 
            // creationPasswordTextbox
            // 
            creationPasswordTextbox.Location = new Point(6, 153);
            creationPasswordTextbox.Name = "creationPasswordTextbox";
            creationPasswordTextbox.Size = new Size(330, 23);
            creationPasswordTextbox.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 135);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 18;
            label4.Text = "Password";
            // 
            // creationUsernameTextbox
            // 
            creationUsernameTextbox.Location = new Point(6, 109);
            creationUsernameTextbox.Name = "creationUsernameTextbox";
            creationUsernameTextbox.Size = new Size(330, 23);
            creationUsernameTextbox.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 91);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 16;
            label3.Text = "Username";
            // 
            // creationEmailTextbox
            // 
            creationEmailTextbox.Location = new Point(6, 65);
            creationEmailTextbox.Name = "creationEmailTextbox";
            creationEmailTextbox.Size = new Size(330, 23);
            creationEmailTextbox.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 47);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 14;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 13;
            label1.Text = "Role";
            // 
            // creationRoleCombobox
            // 
            creationRoleCombobox.FormattingEnabled = true;
            creationRoleCombobox.Items.AddRange(new object[] { "User", "Admin" });
            creationRoleCombobox.Location = new Point(6, 21);
            creationRoleCombobox.Name = "creationRoleCombobox";
            creationRoleCombobox.Size = new Size(330, 23);
            creationRoleCombobox.TabIndex = 12;
            // 
            // update
            // 
            update.Controls.Add(updateButton);
            update.Controls.Add(updateUsernameTextbox);
            update.Controls.Add(label8);
            update.Controls.Add(updateEmailTextbox);
            update.Controls.Add(label9);
            update.Controls.Add(label10);
            update.Controls.Add(updateRoleCombobox);
            update.Location = new Point(4, 24);
            update.Name = "update";
            update.Padding = new Padding(3);
            update.Size = new Size(342, 398);
            update.TabIndex = 1;
            update.Text = "Update user";
            update.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(6, 369);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(330, 23);
            updateButton.TabIndex = 33;
            updateButton.Text = "Update User";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // updateUsernameTextbox
            // 
            updateUsernameTextbox.Location = new Point(6, 109);
            updateUsernameTextbox.Name = "updateUsernameTextbox";
            updateUsernameTextbox.Size = new Size(330, 23);
            updateUsernameTextbox.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 91);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 27;
            label8.Text = "Username";
            // 
            // updateEmailTextbox
            // 
            updateEmailTextbox.Location = new Point(6, 65);
            updateEmailTextbox.Name = "updateEmailTextbox";
            updateEmailTextbox.Size = new Size(330, 23);
            updateEmailTextbox.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 47);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 25;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 3);
            label10.Name = "label10";
            label10.Size = new Size(30, 15);
            label10.TabIndex = 24;
            label10.Text = "Role";
            // 
            // updateRoleCombobox
            // 
            updateRoleCombobox.FormattingEnabled = true;
            updateRoleCombobox.Items.AddRange(new object[] { "User", "Admin" });
            updateRoleCombobox.Location = new Point(6, 21);
            updateRoleCombobox.Name = "updateRoleCombobox";
            updateRoleCombobox.Size = new Size(330, 23);
            updateRoleCombobox.TabIndex = 23;
            // 
            // adminWelcomeLabel
            // 
            adminWelcomeLabel.AutoSize = true;
            adminWelcomeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminWelcomeLabel.Location = new Point(12, 10);
            adminWelcomeLabel.Name = "adminWelcomeLabel";
            adminWelcomeLabel.Size = new Size(185, 21);
            adminWelcomeLabel.TabIndex = 10;
            adminWelcomeLabel.Text = "Welcome back, admin!";
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(709, 20);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(75, 23);
            logoutButton.TabIndex = 11;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += LogoutButton_Click;
            // 
            // adminLabel
            // 
            adminLabel.AutoSize = true;
            adminLabel.Location = new Point(12, 35);
            adminLabel.Name = "adminLabel";
            adminLabel.Size = new Size(142, 15);
            adminLabel.TabIndex = 13;
            adminLabel.Text = "Email: admin@admin.org";
            adminLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // adminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 502);
            Controls.Add(adminLabel);
            Controls.Add(logoutButton);
            Controls.Add(adminWelcomeLabel);
            Controls.Add(tabControl1);
            Controls.Add(userList);
            Name = "adminForm";
            Text = "Form2";
            contextMenuStrip1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            create.ResumeLayout(false);
            create.PerformLayout();
            update.ResumeLayout(false);
            update.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView userList;
        private TabControl tabControl1;
        private TabPage update;
        private TabPage create;
        private TextBox creationConfirmPasswordTextbox;
        private Label label5;
        private TextBox creationPasswordTextbox;
        private Label label4;
        private TextBox creationUsernameTextbox;
        private Label label3;
        private TextBox creationEmailTextbox;
        private Label label2;
        private Label label1;
        private ComboBox creationRoleCombobox;
        private Button creationButton;
        private Button updateButton;
        private TextBox updateUsernameTextbox;
        private Label label8;
        private TextBox updateEmailTextbox;
        private Label label9;
        private Label label10;
        private ComboBox updateRoleCombobox;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteUserToolStripMenuItem;
        private Label adminWelcomeLabel;
        private Button logoutButton;
        private Label adminLabel;
    }
}