using MetroFramework.Forms;

namespace WF
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Length < 3 || tbPass.Text.Length < 3)
                MessageBox.Show("Username or password is invalid or is short!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var result = HashingSalting.Program.Login(tbName.Text, tbPass.Text);
            if (result == "Login Successful")
            {
                MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbName.Text = "";
                tbPass.Text = "";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.ShowDialog();
            this.Hide(); 
            this.Close();
        }
    }
}