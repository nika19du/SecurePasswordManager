namespace WF
{
    partial class Encryptor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            tbPass = new TextBox();
            metroLabel3 = new MetroFramework.Controls.MetroLabel();
            btnAddFile = new MetroFramework.Controls.MetroButton();
            btnClearFile = new MetroFramework.Controls.MetroButton();
            btnAddFolders = new MetroFramework.Controls.MetroButton();
            btnClearFolders = new MetroFramework.Controls.MetroButton();
            btmEncrypt = new MetroFramework.Controls.MetroButton();
            btnDecrypt = new MetroFramework.Controls.MetroButton();
            btnClearAll = new MetroFramework.Controls.MetroButton();
            SuspendLayout();
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel1.Location = new Point(0, 7);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(34, 19);
            metroLabel1.TabIndex = 0;
            metroLabel1.Text = "Files";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 29);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(450, 94);
            listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(0, 147);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(450, 94);
            listBox2.TabIndex = 3;
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel2.Location = new Point(0, 126);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(52, 19);
            metroLabel2.TabIndex = 2;
            metroLabel2.Text = "Folders";
            // 
            // tbPass
            // 
            tbPass.Location = new Point(0, 268);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(130, 23);
            tbPass.TabIndex = 4;
            // 
            // metroLabel3
            // 
            metroLabel3.AutoSize = true;
            metroLabel3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            metroLabel3.Location = new Point(0, 246);
            metroLabel3.Name = "metroLabel3";
            metroLabel3.Size = new Size(63, 19);
            metroLabel3.TabIndex = 5;
            metroLabel3.Text = "Password";
            // 
            // btnAddFile
            // 
            btnAddFile.Location = new Point(456, 53);
            btnAddFile.Name = "btnAddFile";
            btnAddFile.Size = new Size(86, 32);
            btnAddFile.TabIndex = 6;
            btnAddFile.Text = "Add";
            btnAddFile.UseSelectable = true;
            btnAddFile.Click += btnAddFile_Click;
            // 
            // btnClearFile
            // 
            btnClearFile.Location = new Point(456, 91);
            btnClearFile.Name = "btnClearFile";
            btnClearFile.Size = new Size(86, 32);
            btnClearFile.TabIndex = 7;
            btnClearFile.Text = "Clear";
            btnClearFile.UseSelectable = true;
            btnClearFile.Click += btnClearFile_Click;
            // 
            // btnAddFolders
            // 
            btnAddFolders.Location = new Point(456, 171);
            btnAddFolders.Name = "btnAddFolders";
            btnAddFolders.Size = new Size(86, 32);
            btnAddFolders.TabIndex = 8;
            btnAddFolders.Text = "Add";
            btnAddFolders.UseSelectable = true;
            btnAddFolders.Click += btnAddFolders_Click;
            // 
            // btnClearFolders
            // 
            btnClearFolders.Location = new Point(456, 209);
            btnClearFolders.Name = "btnClearFolders";
            btnClearFolders.Size = new Size(86, 32);
            btnClearFolders.TabIndex = 9;
            btnClearFolders.Text = "Clear";
            btnClearFolders.UseSelectable = true;
            btnClearFolders.Click += btnClearFolders_Click;
            // 
            // btmEncrypt
            // 
            btmEncrypt.Location = new Point(31, 297);
            btmEncrypt.Name = "btmEncrypt";
            btmEncrypt.Size = new Size(147, 30);
            btmEncrypt.TabIndex = 10;
            btmEncrypt.Text = "Encrypt";
            btmEncrypt.UseSelectable = true;
            btmEncrypt.Click += btmEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(208, 297);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(147, 30);
            btnDecrypt.TabIndex = 11;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseSelectable = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(383, 297);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(147, 30);
            btnClearAll.TabIndex = 12;
            btnClearAll.Text = "ClearAll";
            btnClearAll.UseSelectable = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // Encryptor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnClearAll);
            Controls.Add(btnDecrypt);
            Controls.Add(btmEncrypt);
            Controls.Add(btnClearFolders);
            Controls.Add(btnAddFolders);
            Controls.Add(btnClearFile);
            Controls.Add(btnAddFile);
            Controls.Add(metroLabel3);
            Controls.Add(tbPass);
            Controls.Add(listBox2);
            Controls.Add(metroLabel2);
            Controls.Add(listBox1);
            Controls.Add(metroLabel1);
            Name = "Encryptor";
            Size = new Size(548, 343);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private ListBox listBox1;
        private ListBox listBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private TextBox tbPass;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnAddFile;
        private MetroFramework.Controls.MetroButton btnClearFile;
        private MetroFramework.Controls.MetroButton btnAddFolders;
        private MetroFramework.Controls.MetroButton btnClearFolders;
        private MetroFramework.Controls.MetroButton btmEncrypt;
        private MetroFramework.Controls.MetroButton btnDecrypt;
        private MetroFramework.Controls.MetroButton btnClearAll;
    }
}
