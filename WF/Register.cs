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
    public partial class Register : MetroForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void linkLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Length < 3 || tbPass.Text.Length < 3)
                MessageBox.Show("Username or password is invalid or is short!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            HashingSalting.Program.Register(tbName.Text, tbPass.Text);
            MessageBox.Show("Register Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.linkLogin_Click(sender, e);
        }
    }
}
