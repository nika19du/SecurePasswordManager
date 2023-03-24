namespace WF
{
    partial class PasswordGenerator
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
            tbPass = new TextBox();
            btnGenerate = new MetroFramework.Controls.MetroButton();
            btnCopy = new MetroFramework.Controls.MetroButton();
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            trackBar1 = new TrackBar();
            cbSymbols = new MetroFramework.Controls.MetroCheckBox();
            cbDigits = new MetroFramework.Controls.MetroCheckBox();
            cbUppercase = new MetroFramework.Controls.MetroCheckBox();
            cbLowercase = new MetroFramework.Controls.MetroCheckBox();
            label1 = new Label();
            lbLength = new MetroFramework.Controls.MetroLabel();
            metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // tbPass
            // 
            tbPass.Location = new Point(17, 15);
            tbPass.Multiline = true;
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(411, 35);
            tbPass.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = SystemColors.ActiveBorder;
            btnGenerate.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerate.Location = new Point(443, 15);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(86, 35);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate";
            btnGenerate.UseSelectable = true;
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(535, 15);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(63, 35);
            btnCopy.TabIndex = 2;
            btnCopy.Text = "Copy";
            btnCopy.UseSelectable = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // metroPanel1
            // 
            metroPanel1.Controls.Add(trackBar1);
            metroPanel1.Controls.Add(cbSymbols);
            metroPanel1.Controls.Add(cbDigits);
            metroPanel1.Controls.Add(cbUppercase);
            metroPanel1.Controls.Add(cbLowercase);
            metroPanel1.HorizontalScrollbarBarColor = true;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 10;
            metroPanel1.Location = new Point(17, 71);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(581, 79);
            metroPanel1.TabIndex = 4;
            metroPanel1.VerticalScrollbarBarColor = true;
            metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            metroPanel1.VerticalScrollbarSize = 10;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(3, 0);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(578, 45);
            trackBar1.TabIndex = 6;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // cbSymbols
            // 
            cbSymbols.AutoSize = true;
            cbSymbols.Location = new Point(426, 51);
            cbSymbols.Name = "cbSymbols";
            cbSymbols.Size = new Size(68, 15);
            cbSymbols.Style = MetroFramework.MetroColorStyle.Blue;
            cbSymbols.TabIndex = 6;
            cbSymbols.Text = "Symbols";
            cbSymbols.Theme = MetroFramework.MetroThemeStyle.Light;
            cbSymbols.UseSelectable = true;
            // 
            // cbDigits
            // 
            cbDigits.AutoSize = true;
            cbDigits.Location = new Point(330, 51);
            cbDigits.Name = "cbDigits";
            cbDigits.Size = new Size(53, 15);
            cbDigits.Style = MetroFramework.MetroColorStyle.Blue;
            cbDigits.TabIndex = 5;
            cbDigits.Text = "Digits";
            cbDigits.Theme = MetroFramework.MetroThemeStyle.Light;
            cbDigits.UseSelectable = true;
            // 
            // cbUppercase
            // 
            cbUppercase.AutoSize = true;
            cbUppercase.Location = new Point(204, 51);
            cbUppercase.Name = "cbUppercase";
            cbUppercase.Size = new Size(78, 15);
            cbUppercase.Style = MetroFramework.MetroColorStyle.Blue;
            cbUppercase.TabIndex = 4;
            cbUppercase.Text = "Uppercase";
            cbUppercase.Theme = MetroFramework.MetroThemeStyle.Light;
            cbUppercase.UseSelectable = true;
            // 
            // cbLowercase
            // 
            cbLowercase.AutoSize = true;
            cbLowercase.Location = new Point(76, 51);
            cbLowercase.Name = "cbLowercase";
            cbLowercase.Size = new Size(78, 15);
            cbLowercase.Style = MetroFramework.MetroColorStyle.Blue;
            cbLowercase.TabIndex = 3;
            cbLowercase.Text = "Lowercase";
            cbLowercase.Theme = MetroFramework.MetroThemeStyle.Light;
            cbLowercase.UseSelectable = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 53);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 5;
            label1.Text = "Options";
            // 
            // lbLength
            // 
            lbLength.AutoSize = true;
            lbLength.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbLength.Location = new Point(594, 88);
            lbLength.Name = "lbLength";
            lbLength.Size = new Size(0, 0);
            lbLength.TabIndex = 6;
            // 
            // PasswordGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbLength);
            Controls.Add(label1);
            Controls.Add(metroPanel1);
            Controls.Add(btnCopy);
            Controls.Add(btnGenerate);
            Controls.Add(tbPass);
            Name = "PasswordGenerator";
            Size = new Size(636, 165);
            metroPanel1.ResumeLayout(false);
            metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPass;
        private MetroFramework.Controls.MetroButton btnGenerate;
        private MetroFramework.Controls.MetroButton btnCopy;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroCheckBox cbSymbols;
        private MetroFramework.Controls.MetroCheckBox cbDigits;
        private MetroFramework.Controls.MetroCheckBox cbUppercase;
        private MetroFramework.Controls.MetroCheckBox cbLowercase;
        private Label label1;
        private TrackBar trackBar1;
        private MetroFramework.Controls.MetroLabel lbLength;
    }
}
