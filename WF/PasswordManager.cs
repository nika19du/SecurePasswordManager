using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF
{
    public partial class PasswordManager : MetroForm
    { 
        PasswordGenerator uc = new PasswordGenerator();
        Encryptor encryptor = new Encryptor();
        public PasswordManager()
        {
            InitializeComponent();
        }

        private void PasswordManager_Load(object sender, EventArgs e)
        {
            btnGenPass.FlatStyle = FlatStyle.Flat;
            btnGenPass.FlatAppearance.BorderSize = 0;
            btnGenPass.BackColor = Color.Empty;
            btnEcriptDecr.FlatStyle = FlatStyle.Flat;
            btnEcriptDecr.FlatAppearance.BorderSize = 0;
            btnEcriptDecr.BackColor = Color.Empty;
        }

        private void btnGenPass_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(encryptor);
            uc.Dock = DockStyle.None;
            uc.Location = new Point(20, 197);
            uc.Margin = new Padding(3, 3, 3, 3);
            uc.Padding = new Padding(0, 0, 0, 0);
            this.Controls.Add(uc);
        }

        private void btnEcriptDecr_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(uc); 
            encryptor.Dock = DockStyle.None;
            encryptor.Location = new Point(21, 190);
            encryptor.Margin = new Padding(3, 3, 3, 3);
            encryptor.Padding = new Padding(0, 0, 0, 0);
            this.Controls.Add(encryptor);
        }
    }
}
