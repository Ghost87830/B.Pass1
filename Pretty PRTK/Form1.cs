using System;
using System.Diagnostics;
using System.IO;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Aspose.Cells; //for excel docs
using Aspose.Words; //for word docs
using Aspose.Words.Loading;
using WordDocument = Aspose.Words.Document;
using CellsLoadOptions = Aspose.Cells.LoadOptions;


namespace Pretty_PRTK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text;
            string dictionaryPath = txtDictionaryPath.Text;

            if (string.IsNullOrEmpty(filePath) || string.IsNullOrEmpty(dictionaryPath))
            {
                lblStatus.Text = "Please specify both file and dictionary paths.";
                return;
            }

            if (!File.Exists(filePath))
            {
                lblStatus.Text = "File not found.";
                return;
            }

            if (!File.Exists(dictionaryPath))
            {
                lblStatus.Text = "Dictionary file not found.";
                return;
            }

            string fileType = IdentifyFile(filePath);
            lblStatus.Text = $"File type detected: {fileType}";

            Stopwatch stopwatch = Stopwatch.StartNew();
            bool success = false;

            if (fileType == "Excel")
            {
                lblStatus.Text = "Checking if the Excel file is encrypted...";
                if (CheckIfExcelEncrypted(filePath))
                {
                    lblStatus.Text = "File is encrypted. Starting dictionary attack...";
                    success = DictionaryAttackExcel(filePath, dictionaryPath);
                }
                else lblStatus.Text = "File is not encrypted.";
            }
            else if (fileType == "Word")
            {
                lblStatus.Text = "Checking if the Word file is encrypted...";
                if (CheckIfWordEncrypted(filePath))
                {
                    lblStatus.Text = "File is encrypted. Starting dictionary attack...";
                    success = DictionaryAttackWord(filePath, dictionaryPath);
                }
                else lblStatus.Text = "File is not encrypted.";
            }
            else
            {
                lblStatus.Text = "Unsupported file type.";
            }

            stopwatch.Stop();
            lblTimeTaken.Text = $"Time Taken: {stopwatch.Elapsed.TotalSeconds:F2} seconds.";
            if (success) lblStatus.Text = "Password found!";
            else lblStatus.Text = "Password not found.";
        }

        private string IdentifyFile(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();
            return extension switch
            {
                ".xlsx" => "Excel",
                ".docx" => "Word",
                _ => "Unsupported"
            };
        }

        private bool CheckIfExcelEncrypted(string filePath)
        {
            try
            {
                new Workbook(filePath);
                return false;
            }
            catch (CellsException)
            {
                return true;
            }
        }

        private bool CheckIfWordEncrypted(string filePath)
        {
            try
            {
                //checks the doc
                var doc = new WordDocument(filePath);

                //If no exception is thrown, the document is not encrypted
                return false;
            }
            catch (UnsupportedFileFormatException)
            {
                //The file is not a valid Word document
                return false;
            }
            catch (Aspose.Words.IncorrectPasswordException)
            {
                // The document is password-protected
                return true;
            }
        }


        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Excel or Word File";
                openFileDialog.Filter = "Excel & Word Files|*.xls;*.xlsx;*.docx";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnBrowseDictionary_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a Dictionary File";
                openFileDialog.Filter = "Text Files|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDictionaryPath.Text = openFileDialog.FileName;
                }
            }
        }








        private void btnStartHashCracking_Click(object sender, EventArgs e)
        {
            string hashToCrack = txtHashToCrack.Text;
            string dictionaryPath = txtDictionaryPath1.Text;

            if (string.IsNullOrEmpty(hashToCrack) || string.IsNullOrEmpty(dictionaryPath))
            {
                lblHashCrackStatus.Text = "Please provide a hash and a dictionary.";
                return;
            }

            lblHashCrackStatus.Text = "Hash cracking started...";
            btnStartHashCracking.Enabled = false;

            try
            {
                // Read the dictionary file
                string[] dictionary = File.ReadAllLines(dictionaryPath);
                bool found = false;

                // Iterate over each word in the dictionary
                foreach (string password in dictionary)
                {
                    string hashedPassword = HashPassword(password);

                    // Check if the hashed password matches the target hash
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
                lblHashCrackStatus.Text = "Error during hash cracking: " + ex.Message;
            }
            finally
            {
                btnStartHashCracking.Enabled = true;
            }
        }

        // A function to hash a string using MD5, SHA256, or other selected algorithms
        private string HashPassword(string password)
        {
            HashAlgorithm hashAlgorithm;

            // Select the appropriate hash algorithm based on the ComboBox selection
            switch (comboBoxHashAlgorithm.SelectedItem.ToString())
            {
                case "SHA256":
                    hashAlgorithm = SHA256.Create();
                    break;
                case "SHA1":
                    hashAlgorithm = SHA1.Create();
                    break;
                case "MD5":
                default:
                    hashAlgorithm = MD5.Create();
                    break;
            }

            byte[] inputBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = hashAlgorithm.ComputeHash(inputBytes);
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }



        


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

        private void btnUseRainbowTable_Click(object sender, EventArgs e)
        {
            string targetHash = txtHashToCrack.Text;

            if (string.IsNullOrEmpty(targetHash))
            {
                txtRainbowTableOutput.Text = "Please enter a hash to look up.";
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


        private void Form1_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Ready";
        }

        private bool DictionaryAttackExcel(string filePath, string dictionaryPath)
        {
            foreach (string password in File.ReadLines(dictionaryPath))
            {
                if (TryOpenExcelFile(filePath, password))
                {
                    lblFoundPassword.Text = $"Found Password: {password}";
                    return true;
                }
            }
            return false;
        }

        private bool DictionaryAttackWord(string filePath, string dictionaryPath)
        {
            foreach (string password in File.ReadLines(dictionaryPath))
            {
                if (TryOpenWordFile(filePath, password))
                {
                    lblFoundPassword.Text = $"Found Password: {password}";
                    return true;
                }
            }
            return false;
        }

        private bool TryOpenExcelFile(string filePath, string password)
        {
            try
            {
                CellsLoadOptions loadOptions = new CellsLoadOptions { Password = password };
                new Workbook(filePath, loadOptions);
                return true;
            }
            catch (CellsException)
            {
                return false;
            }
        }

        private bool TryOpenWordFile(string filePath, string password)
        {
            try
            {
                //tests word with password
                Aspose.Words.Loading.LoadOptions loadOptions = new Aspose.Words.Loading.LoadOptions { Password = password };

                //attempt to load the document with the provided password list
                new WordDocument(filePath, loadOptions); //using alias here too
                return true; //password worked
            }
            catch (UnsupportedFileFormatException)
            {
                // The file is not a valid Word document
                return false;
            }
            catch (Aspose.Words.IncorrectPasswordException)
            {
                // The password provided is incorrect
                return false;
            }
        }


        private void btnGenerateDictionary_Click_1(object sender, EventArgs e)
        {
            CreateDictionaryForm createDictionaryForm = new CreateDictionaryForm();
            createDictionaryForm.Show();
        }

        private void comboBoxHashAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedAlgorithm = comboBoxHashAlgorithm.SelectedItem.ToString();
            MessageBox.Show($"Selected Algorithm: {selectedAlgorithm}");
        }

        private void btnOpenHashCracker_Click(object sender, EventArgs e)
        {
            HashCrackingForm hashCrackingForm = new HashCrackingForm();
            hashCrackingForm.Show();
        }



    }
}
