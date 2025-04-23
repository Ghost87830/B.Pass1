using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pretty_PRTK
{
    public partial class HashCrackingForm : Form
    {
        private Dictionary<string, string> rainbowTable = new Dictionary<string, string>
        {
            // MD5 Hashes
            { "5f4dcc3b5aa765d61d8327deb882cf99", "password" },
            { "e10adc3949ba59abbe56e057f20f883e", "123456" },
            { "0d107d09f5bbe40cade3de5f9d1f1bb1", "letmein" },
            { "d8578edf8458ce06fbc5bb76a58c5ca4", "qwerty" },
            { "e99a18c428cb38d5f260853678922e03", "abc123" },

            // SHA-1 Hashes
            { "5baa61e4c9b93f3f0682250b6cf8331b7ee68fd8", "password" },
            { "20ab0d1b745488aeff70e374ac90797b478c801b", "123456" },
            { "c94e9a8b2436f125a498b276c5d67e2d77ff5a2c", "letmein" },
            { "44bd9356881ed034ea840b1f402c9b32b24fbd77", "qwerty" },
            { "a99c2f1ef271b212c77cf9e72a2677e1713659ad", "abc123" },

            // SHA-256 Hashes
            { "5e884898da28047151d0e56f8dc6292773603d0d88f6d3d3f6b59bf3c6e24b9f", "password" },
            { "8d969eef6ecad3c29a3a629280e686cf0fd3ad9b8a54b8bb9c365f885c36d62f", "123456" },
            { "6d9ce4fd3cf84e8d1e16e9d8c69acda2c3579f88a0b263431ca0b90a5a23141b", "letmein" },
            { "6b3a55e0261b0304143f814de2f5f03423b08c3b85b8b7fdd98d3137b3809670", "qwerty" },
            { "6d7e4f24fbbd1be0e17b9d77d25f20fedd399108fd4d261b933df8e537d7c2d5", "abc123" }
        };
        public HashCrackingForm()
        {

            InitializeComponent();
        }

        private void HashCrackingForm_Load(object sender, EventArgs e)
        {
            

            comboBoxHashAlgorithm.Items.AddRange(new string[] { "MD5", "SHA1", "SHA256" });
            comboBoxHashAlgorithm.SelectedIndex = 0;
            lblHashCrackStatus.Text = "Status: Ready";
        }

        private void txtHashToCrack_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDictionaryPath1_TextChanged(object sender, EventArgs e)
        {

        }




        private void txtHashToCrack_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtHashToCrack_Leave(object sender, EventArgs e)
        {
           
        }









        private void btnChooseDictionary1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a Dictionary File";
                openFileDialog.Filter = "Text Files|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDictionaryPath1.Text = openFileDialog.FileName;
                }
            }
        }

        private void comboBoxHashAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hashToCrack = txtHashToCrack.Text;
            string dictionaryPath = txtDictionaryPath1.Text;

            if (string.IsNullOrEmpty(hashToCrack) || string.IsNullOrEmpty(dictionaryPath))
            {
                lblHashCrackStatus.Text = "Please provide both hash and dictionary.";
                return;
            }

            lblHashCrackStatus.Text = "Cracking in progress...";
            btnStartHashCracking.Enabled = false;

            try
            {
                string[] dictionary = File.ReadAllLines(dictionaryPath);
                bool found = false;

                foreach (string password in dictionary)
                {
                    string hashedPassword = HashPassword(password);
                    if (hashedPassword.Equals(hashToCrack, StringComparison.OrdinalIgnoreCase))
                    {
                        lblHashCrackStatus.Text = $"Password found: {password}";
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    lblHashCrackStatus.Text = "Password not found in dictionary.";
                }
            }
            catch (Exception ex)
            {
                lblHashCrackStatus.Text = "Error: " + ex.Message;
            }
            finally
            {
                btnStartHashCracking.Enabled = true;
            }
        }

        private void btnStartHashCracking_Click(object sender, EventArgs e)
        {

        }

        private void lblHashCrackStatus_Click(object sender, EventArgs e)
        {

        }
        private string HashPassword(string password)
        {
            using HashAlgorithm hashAlgorithm = comboBoxHashAlgorithm.SelectedItem switch
            {
                "SHA256" => SHA256.Create(),
                "SHA1" => SHA1.Create(),
                _ => MD5.Create()
            };

            byte[] inputBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = hashAlgorithm.ComputeHash(inputBytes);
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }



        private void btnUseRainbowTable_Click(object sender, EventArgs e)
        {
           
            string targetHash = txtHashToCrack.Text;

            // Check if the entered hash is the placeholder text or if it's empty
            if (string.IsNullOrEmpty(targetHash) || targetHash == "Enter hash to crack...")
            {
                txtRainbowTableOutput.Text = "Please enter a valid hash to look up.";
                return;
            }

            if (rainbowTable.ContainsKey(targetHash))
            {
                txtRainbowTableOutput.Text = $"Rainbow Match Found: {rainbowTable[targetHash]}";
            }
            else
            {
                txtRainbowTableOutput.Text = "No match found in rainbow table.";
            }
        }

    }
}
