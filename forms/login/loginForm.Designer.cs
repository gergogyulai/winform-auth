namespace login
{
    partial class loginForm
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
            usernameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            registerLabel = new Label();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(273, 122);
            usernameTextBox.Margin = new Padding(3, 2, 3, 2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(151, 23);
            usernameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 105);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 147);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(273, 164);
            passwordTextBox.Margin = new Padding(3, 2, 3, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(151, 23);
            passwordTextBox.TabIndex = 2;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(273, 191);
            loginButton.Margin = new Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(150, 30);
            loginButton.TabIndex = 4;
            loginButton.Text = "login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Segoe UI", 10F);
            registerLabel.ForeColor = Color.SteelBlue;
            registerLabel.Location = new Point(273, 223);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(55, 19);
            registerLabel.TabIndex = 5;
            registerLabel.Text = "register";
            registerLabel.Click += registerLabel_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(registerLabel);
            Controls.Add(loginButton);
            Controls.Add(label2);
            Controls.Add(passwordTextBox);
            Controls.Add(label1);
            Controls.Add(usernameTextBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "loginForm";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private Label label1;
        private Label label2;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Label registerLabel;
    }
}