namespace login
{
    partial class registerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameTextBox = new TextBox();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            passwordConfirmTextBox = new TextBox();
            registerButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            loginLabel = new Label();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(271, 99);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(248, 27);
            usernameTextBox.TabIndex = 0;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(271, 152);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(248, 27);
            emailTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(271, 205);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(248, 27);
            passwordTextBox.TabIndex = 2;
            // 
            // passwordConfirmTextBox
            // 
            passwordConfirmTextBox.Location = new Point(271, 258);
            passwordConfirmTextBox.Name = "passwordConfirmTextBox";
            passwordConfirmTextBox.Size = new Size(248, 27);
            passwordConfirmTextBox.TabIndex = 3;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(270, 291);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(249, 29);
            registerButton.TabIndex = 4;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 76);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 5;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 129);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 6;
            label2.Text = "email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 182);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 7;
            label3.Text = "password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(271, 235);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 8;
            label4.Text = "password confirm ";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(271, 323);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(43, 20);
            loginLabel.TabIndex = 9;
            loginLabel.Text = "login";
            loginLabel.Click += loginLabel_Click;
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(registerButton);
            Controls.Add(passwordConfirmTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(usernameTextBox);
            Name = "registerForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private TextBox passwordConfirmTextBox;
        private Button registerButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label loginLabel;
    }
}
