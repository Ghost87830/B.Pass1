using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Aspose.Cells;
using Aspose.Words;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //Shows the EthicsForm when the program starts
            EthicsForm ethicsForm = new EthicsForm();
            //makes the EthicsForm modal so that a user cannot intereact with Form1 (main page)
            ethicsForm.ShowDialog();

            //After the EthicsForm is ticked and closed, continue with Form1's functionality
            lblStatus.Text = "Ready";
        }

        private void btnEthics_Click(object sender, EventArgs e)
        {
            EthicsForm ethicsForm = new EthicsForm();
            ethicsForm.Show();
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
            lblStatus.Text = success ? "Password found!" : "Password not found.";
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
        //1
        private bool CheckIfWordEncrypted(string filePath)
        {
            try
            {
                var doc = new WordDocument(filePath);
                return false;
            }
            catch (UnsupportedFileFormatException)
            {
                return false;
            }
            catch (Aspose.Words.IncorrectPasswordException)
            {
                return true;
            }
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select an Excel or Word File",
                Filter = "Excel & Word Files|*.xls;*.xlsx;*.docx"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnBrowseDictionary_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select a Dictionary File",
                Filter = "Text Files|*.txt"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtDictionaryPath.Text = openFileDialog.FileName;
            }
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
                Aspose.Cells.LoadOptions loadOptions = new Aspose.Cells.LoadOptions { Password = password };
                new Workbook(filePath, loadOptions);
                return true;
            }
            catch (CellsException)
            {
                return false;
            }
        }
        //2
        private bool TryOpenWordFile(string filePath, string password)
        {
            try
            {
                Aspose.Words.Loading.LoadOptions loadOptions = new Aspose.Words.Loading.LoadOptions { Password = password };
                new WordDocument(filePath, loadOptions);
                return true;
            }
            catch (UnsupportedFileFormatException)
            {
                return false;
            }
            catch (Aspose.Words.IncorrectPasswordException)
            {
                return false;
            }
        }

        private void btnGenerateDictionary_Click_1(object sender, EventArgs e)
        {
            CreateDictionaryForm createDictionaryForm = new CreateDictionaryForm();
            createDictionaryForm.Show();
        }

        private void btnOpenHashCracker_Click(object sender, EventArgs e)
        {
            HashCrackingForm hashCrackingForm = new HashCrackingForm();
            hashCrackingForm.Show();
        }
    }
}
