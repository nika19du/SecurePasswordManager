namespace WF
{
    partial class PasswordManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordManager));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            btnEcriptDecr = new Button();
            btnGenPass = new Button();
            menuStrip1.SuspendLayout();
            metroPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(20, 60);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(760, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(53, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(56, 29);
            editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(65, 29);
            viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(63, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // metroPanel1
            // 
            metroPanel1.Controls.Add(btnEcriptDecr);
            metroPanel1.Controls.Add(btnGenPass);
            metroPanel1.HorizontalScrollbarBarColor = true;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 10;
            metroPanel1.Location = new Point(20, 96);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(760, 84);
            metroPanel1.Style = MetroFramework.MetroColorStyle.Black;
            metroPanel1.TabIndex = 1;
            metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroPanel1.UseCustomBackColor = true;
            metroPanel1.UseStyleColors = true;
            metroPanel1.VerticalScrollbarBarColor = true;
            metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnEcriptDecr
            // 
            btnEcriptDecr.BackgroundImageLayout = ImageLayout.Stretch;
            btnEcriptDecr.Cursor = Cursors.Hand;
            btnEcriptDecr.FlatStyle = FlatStyle.Flat;
            btnEcriptDecr.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEcriptDecr.Image = (Image)resources.GetObject("btnEcriptDecr.Image");
            btnEcriptDecr.Location = new Point(92, 0);
            btnEcriptDecr.Name = "btnEcriptDecr";
            btnEcriptDecr.Size = new Size(60, 78);
            btnEcriptDecr.TabIndex = 3;
            btnEcriptDecr.UseVisualStyleBackColor = true;
            btnEcriptDecr.Click += btnEcriptDecr_Click;
            // 
            // btnGenPass
            // 
            btnGenPass.Cursor = Cursors.Hand;
            btnGenPass.FlatStyle = FlatStyle.Flat;
            btnGenPass.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenPass.Image = (Image)resources.GetObject("btnGenPass.Image");
            btnGenPass.Location = new Point(3, 3);
            btnGenPass.Name = "btnGenPass";
            btnGenPass.Size = new Size(83, 75);
            btnGenPass.TabIndex = 2;
            btnGenPass.UseVisualStyleBackColor = true;
            btnGenPass.Click += btnGenPass_Click;
            // 
            // PasswordManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(metroPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "PasswordManager";
            Text = "PasswordManager";
            Load += PasswordManager_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            metroPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Button btnGenPass;
        private Button btnEcriptDecr;
    }
}