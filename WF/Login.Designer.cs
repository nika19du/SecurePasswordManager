namespace WF
{
    partial class Login
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
            btnLogin = new MetroFramework.Controls.MetroButton();
            btnRegister = new MetroFramework.Controls.MetroButton();
            tbPass = new TextBox();
            tbName = new TextBox();
            Password = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(81, 229);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(161, 47);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "LogIn";
            btnLogin.UseSelectable = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(335, 229);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(161, 47);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseSelectable = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(138, 174);
            tbPass.Multiline = true;
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(305, 39);
            tbPass.TabIndex = 2;
            // 
            // tbName
            // 
            tbName.Location = new Point(138, 98);
            tbName.Multiline = true;
            tbName.Name = "tbName";
            tbName.Size = new Size(305, 39);
            tbName.TabIndex = 3;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            Password.ForeColor = SystemColors.ActiveCaption;
            Password.Location = new Point(239, 140);
            Password.Name = "Password";
            Password.Size = new Size(110, 31);
            Password.TabIndex = 4;
            Password.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(255, 64);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 299);
            Controls.Add(label1);
            Controls.Add(Password);
            Controls.Add(tbName);
            Controls.Add(tbPass);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroButton btnRegister;
        private TextBox tbPass;
        private TextBox tbName;
        private Label Password;
        private Label label1;
    }
}