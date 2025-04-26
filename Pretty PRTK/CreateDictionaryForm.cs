using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing; 

namespace Pretty_PRTK
{
    public partial class CreateDictionaryForm : Form
    {
        private List<string> customKeywords = new List<string>(); //Stores added keywords
        private TextBox txtKeywordInput;
        private Button btnAddKeyword;
        private ListBox lstKeywords;

        public CreateDictionaryForm()
        {
            InitializeComponent();
            

            //Masked textbox to format dob
            MaskedTextBox maskedTxtDOB = new MaskedTextBox
            {
                Mask = "00/00/0000",  //dob
                Location = new Point(20, 120),
                Name = "maskedTxtDOB",
                Size = new Size(100, 25),
                TabIndex = 6
            };
            Controls.Add(maskedTxtDOB);
        }

        

        private void BtnAddKeyword_Click(object sender, EventArgs e)
        {
            string keyword = txtKeywordInput.Text.Trim();

            if (!string.IsNullOrEmpty(keyword) && !customKeywords.Contains(keyword))
            {
                customKeywords.Add(keyword);
                lstKeywords.Items.Add(keyword);
                txtKeywordInput.Clear();
            }
            else
            {
                MessageBox.Show("Keyword is empty or already added.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGenerateDictionary1_Click(object sender, EventArgs e)
        {
            try
            {
                //collects the input data from user
                string name = txtName.Text;
                string dob = maskedTxtDOB.Text;  //sse the MaskedTextBox for dob
                string petName = txtPetName.Text;
                string partnerName = txtPartnerName.Text;
                string favouriteFilm = txtFavouriteFilm.Text;
                string currentTown = txtCurrentTown.Text;
                string secondName = txtSecondName.Text;
                string favouriteFood = txtFavouriteFood.Text;

                //generats passwords
                List<string> passwords = GeneratePasswords(name, dob, petName, partnerName, favouriteFilm, currentTown, secondName, favouriteFood, customKeywords);

                //creates personalised dictionary and allows the user to save
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Text Files (*.txt)|*.txt",
                    Title = "Save Password Dictionary"
                };

                //for saving the txt file
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(saveFileDialog.FileName, passwords);

                    //lets user know when txt doc has been saved
                    MessageBox.Show($"Passwords successfully saved to {saveFileDialog.FileName}");
                }
            }
            catch (Exception ex)
            {
                //shows error msg if need be
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private List<string> GeneratePasswords(string name, string dob, string petName, string partnerName, string favoriteFilm, string currentTown, string secondName, string favouriteFood, List<string> keywords)
        {
            List<string> passwords = new List<string>();

            string SafeSubstring(string str, int startIndex, int length)
            {
                if (str.Length < startIndex) return "";
                return str.Substring(startIndex, Math.Min(length, str.Length - startIndex));
            }

            string year = SafeSubstring(dob, 6, 4);
            string monthDay = SafeSubstring(dob, 0, 2) + SafeSubstring(dob, 3, 2);
            //password combinations
            passwords.Add($"{name}{dob}");
            passwords.Add($"{name}{year}");
            passwords.Add($"{name}{monthDay}{year}");
            passwords.Add($"{name}{monthDay}");
            passwords.Add($"{currentTown}{dob}");
            passwords.Add($"{currentTown}{year}");
            passwords.Add($"{currentTown}{monthDay}{year}");
            passwords.Add($"{currentTown}{monthDay}");

            passwords.Add($"{name}{petName}");
            passwords.Add($"{name}{partnerName}");
            passwords.Add($"{name}{favoriteFilm}");
            passwords.Add($"{name}{currentTown}");
            passwords.Add($"{name}{secondName}{dob}");
            passwords.Add($"{name}{favouriteFood}");

            passwords.Add($"{name}{petName}{partnerName}");
            passwords.Add($"{name}{petName}{favoriteFilm}");
            passwords.Add($"{name}{favoriteFilm}{currentTown}");
            passwords.Add($"{petName}{favoriteFilm}");
            passwords.Add($"{petName}{SafeSubstring(favoriteFilm, 0, 2)}");
            passwords.Add($"{petName.ToUpper()}!{SafeSubstring(favoriteFilm, 0, 3)}");

            passwords.Add($"{SafeSubstring(name, 0, 2)}{year}");
            passwords.Add($"{SafeSubstring(name, 0, 2)}{monthDay}{year}");
            passwords.Add($"{SafeSubstring(name, 0, 2)}{monthDay}");
            passwords.Add($"{SafeSubstring(name, 0, 1).ToUpper()}{SafeSubstring(dob, 0, 1)}{petName.ToLower()}");

            Random random = new Random();
            passwords.Add($"{name}{dob}{random.Next(1000, 9999)}");
            passwords.Add($"{dob}{name}{random.Next(1000, 9999)}");
            passwords.Add($"{name}{partnerName}{dob}");
            passwords.Add($"{SafeSubstring(name, 0, 1)}{SafeSubstring(partnerName, 0, 1)}{dob}");

            passwords.Add($"{SafeSubstring(name, 0, 2)}{SafeSubstring(partnerName, 0, 2)}{random.Next(100, 999)}");
            passwords.Add($"{SafeSubstring(name, 0, 2)}{SafeSubstring(secondName, 0, 2)}{random.Next(100, 999)}");

            passwords.Add($"{SafeSubstring(dob, 0, 2)}{SafeSubstring(dob, 3, 2)}{SafeSubstring(dob, 6, 4)}");
            passwords.Add($"{SafeSubstring(dob, 0, 4)}{SafeSubstring(name, 0, 2)}");
            passwords.Add($"{SafeSubstring(dob, 5, 2)}{SafeSubstring(dob, 0, 4)}");

            passwords.Add($"{name.ToUpper()}{dob}");
            passwords.Add($"{name.ToLower()}123");
            passwords.Add($"{partnerName.ToUpper()}@{dob}");
            passwords.Add($"{name.ToUpper()}{partnerName.ToLower()}{dob}");

            //variations with user-defined keywords
            foreach (string keyword in keywords)
            {
                passwords.Add($"{name}{keyword}");
                passwords.Add($"{keyword}{dob}");
                passwords.Add($"{keyword}{year}");
                passwords.Add($"{name}{keyword}{year}");
                passwords.Add($"{SafeSubstring(name, 0, 2)}{keyword}{SafeSubstring(dob, 0, 2)}");
            }

            return passwords;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
