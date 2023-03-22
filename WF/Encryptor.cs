using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace WF
{
    public partial class Encryptor : UserControl
    {
        public Encryptor()
        {
            InitializeComponent();
        }
        char[] mychar = { '!', '.', 'L', 'O', 'C', 'K', 'E', 'D' };
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog filePath = new OpenFileDialog();
            filePath.Title = "Select File";
            filePath.InitialDirectory = @"C:\";
            filePath.Filter = "All files (*.*)|*.*";
            filePath.Multiselect = true;
            filePath.FilterIndex = 1;
            filePath.ShowDialog();
            foreach (String file in filePath.FileNames)
            {
                listBox1.Items.Add(file);
            }
        }

        private void btnClearFile_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnAddFolders_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderPath = new FolderBrowserDialog();
            folderPath.ShowDialog();
            listBox2.Items.Add(folderPath);
        }

        private void btnClearFolders_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            tbPass.Text = "";
        }

        private void btmEncrypt_Click(object sender, EventArgs e)
        {
            if (tbPass.Text.Length < 8)
            {
                MessageBox.Show("Password must have 8 characters!",
                    "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (listBox1.Items.Count > 0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    string file = "" + listBox1.Items[i];
                    if (!file.Trim().EndsWith(".!LOCKED") && File.Exists(file))
                    {
                        EncryptFile("" + listBox1.Items[i], "" + listBox1.Items[i] + ".!LOCKED", tbPass.Text);
                        File.Delete("" + listBox1.Items[i]);
                    }
                }
            }
            if (listBox2.Items.Count > 0)
            {
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    string file = "" + listBox2.Items[i];
                    string[] getFiles = Directory.GetFiles(file);
                    foreach (var fileName in getFiles)
                    {
                        if (!fileName.Trim().EndsWith(".!LOCKED") && File.Exists(fileName))
                        {
                            EncryptFile(fileName, fileName+ ".!LOCKED", tbPass.Text);
                            File.Delete(fileName);
                        }
                    }
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (tbPass.Text.Length < 8)
            {
                MessageBox.Show("Password must have 8 characters!",
                    "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (listBox1.Items.Count > 0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    string file = "" + listBox1.Items[i];
                    if (file.Trim().EndsWith(".!LOCKED") && File.Exists(file))
                    {
                        DecryptFile(file,file.TrimEnd(mychar), tbPass.Text);
                        File.Delete(file);
                    }
                }

                if (listBox2.Items.Count > 0)
                {
                    for (int i = 0; i < listBox2.Items.Count; i++)
                    {
                        string file = "" + listBox1.Items[i];
                        string[] getFiles = Directory.GetFiles(file);
                        foreach (var fileName in getFiles)
                        {
                            if (fileName.Trim().EndsWith(".!LOCKED") && File.Exists(fileName))
                            {
                                DecryptFile(fileName, fileName.TrimEnd(mychar), tbPass.Text);
                                File.Delete(fileName);
                            }
                        }
                    }
                }

            }
        }
        private void EncryptFile(string inputFile, string outputFile, string password)
        {
            try
            {
                UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
                byte[] key= unicodeEncoding.GetBytes(password);

                string cryptFile = outputFile;
                FileStream fileStreamCrypt = new FileStream(cryptFile,FileMode.Create);

                RijndaelManaged rmCrypto = new RijndaelManaged();

                CryptoStream cryptoStream = new CryptoStream(fileStreamCrypt,rmCrypto.CreateEncryptor(key,key),CryptoStreamMode.Write);

                FileStream fileStreamIn = new FileStream(inputFile, FileMode.Open);

                int data;
                while((data=fileStreamIn.ReadByte()) != -1)
                {
                    cryptoStream.WriteByte((byte)data);
                }
                
                fileStreamIn.Close();
                cryptoStream.Close();
                fileStreamCrypt.Close();
            }
            catch 
            {
            }
        }
        private void DecryptFile(string inputFile, string outputFile, string password)
        {
            try
            {
                UnicodeEncoding unicodeEncoding= new UnicodeEncoding();
                byte[] key = unicodeEncoding.GetBytes(password);

                FileStream fileStreamCrypto = new FileStream(inputFile, FileMode.Open);

                RijndaelManaged rmCrypto = new RijndaelManaged();

                CryptoStream cryptoStream= new CryptoStream(fileStreamCrypto,rmCrypto.CreateDecryptor(key,key),CryptoStreamMode.Read);

                FileStream fileStreamOut=new FileStream(outputFile, FileMode.Create);

                int data;
                while((data=cryptoStream.ReadByte()) != -1) 
                { 
                    fileStreamOut.WriteByte((byte)data);
                }

                fileStreamOut.Close();
                cryptoStream.Close();
                fileStreamCrypto.Close();
            }
            catch
            {
            }
        }
    }
}
