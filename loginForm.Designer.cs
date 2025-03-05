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
            usernameTextBox.Location = new Point(312, 163);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(172, 27);
            usernameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(312, 140);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 1;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 193);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 3;
            label2.Text = "password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(312, 216);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(172, 27);
            passwordTextBox.TabIndex = 2;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(312, 249);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(172, 29);
            loginButton.TabIndex = 4;
            loginButton.Text = "login";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Location = new Point(312, 281);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(59, 20);
            registerLabel.TabIndex = 5;
            registerLabel.Text = "register";
            registerLabel.Click += registerLabel_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(registerLabel);
            Controls.Add(loginButton);
            Controls.Add(label2);
            Controls.Add(passwordTextBox);
            Controls.Add(label1);
            Controls.Add(usernameTextBox);
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