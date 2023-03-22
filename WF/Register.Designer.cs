namespace WF
{
    partial class Register
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
            label1 = new Label();
            Password = new Label();
            tbName = new TextBox();
            tbPass = new TextBox();
            btnRegister = new MetroFramework.Controls.MetroButton();
            linkLogin = new MetroFramework.Controls.MetroLink();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(287, 60);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 11;
            label1.Text = "Name";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            Password.ForeColor = SystemColors.ActiveCaption;
            Password.Location = new Point(270, 145);
            Password.Name = "Password";
            Password.Size = new Size(110, 31);
            Password.TabIndex = 10;
            Password.Text = "Password";
            // 
            // tbName
            // 
            tbName.Location = new Point(159, 94);
            tbName.Multiline = true;
            tbName.Name = "tbName";
            tbName.Size = new Size(305, 39);
            tbName.TabIndex = 9;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(159, 179);
            tbPass.Multiline = true;
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(305, 39);
            tbPass.TabIndex = 8;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(238, 234);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(161, 47);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseSelectable = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // linkLogin
            // 
            linkLogin.Cursor = Cursors.Hand;
            linkLogin.Location = new Point(287, 291);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(75, 23);
            linkLogin.TabIndex = 12;
            linkLogin.Text = "LogIn";
            linkLogin.UseSelectable = true;
            linkLogin.Click += linkLogin_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 337);
            Controls.Add(linkLogin);
            Controls.Add(label1);
            Controls.Add(Password);
            Controls.Add(tbName);
            Controls.Add(tbPass);
            Controls.Add(btnRegister);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Password;
        private TextBox tbName;
        private TextBox tbPass;
        private MetroFramework.Controls.MetroButton btnRegister;
        private MetroFramework.Controls.MetroLink linkLogin;
    }
}