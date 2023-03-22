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
    public partial class PasswordGenerator : UserControl
    {
        public PasswordGenerator()
        {
            InitializeComponent();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbLength.Text = trackBar1.Value.ToString();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateConfig config = getGenerateConfig();
            var password = PasswordGenHelper.GeneratePassword(config);
            tbPass.Text = password;
        }

        private GenerateConfig getGenerateConfig()
        {
            GenerateConfig config = new GenerateConfig();
            config.Length = trackBar1.Value;
            config.IsLowerCase = cbLowercase.Checked;
            config.IsUpperCase = cbUppercase.Checked;
            config.IsSymbols = cbSymbols.Checked;
            config.IsDigits = cbDigits.Checked;
            return config;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbPass.Text);
        }
    }
}
