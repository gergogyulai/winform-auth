namespace login
{
    partial class userForm
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
            welcomeLabel = new Label();
            userDetailsLabel = new Label();
            logoutButton = new Button();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(12, 20);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(127, 21);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome, user!";
            // 
            // userDetailsLabel
            // 
            userDetailsLabel.AutoSize = true;
            userDetailsLabel.Font = new Font("Segoe UI", 10F);
            userDetailsLabel.Location = new Point(12, 60);
            userDetailsLabel.Name = "userDetailsLabel";
            userDetailsLabel.Size = new Size(45, 19);
            userDetailsLabel.TabIndex = 1;
            userDetailsLabel.Text = "label1";
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(12, 120);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(100, 30);
            logoutButton.TabIndex = 2;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += LogoutButton_Click;
            // 
            // userForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logoutButton);
            Controls.Add(userDetailsLabel);
            Controls.Add(welcomeLabel);
            Name = "userForm";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private Label userDetailsLabel;
        private Button logoutButton;
    }
}