namespace Pretty_PRTK
{
    public partial class Form1 : Form
    {
        private TextBox txtFilePath;
        private TextBox txtDictionaryPath;
        private Button btnBrowseFile;
        private Button btnBrowseDictionary;
        private Button btnStart;
        private Label lblStatus;
        private PictureBox pictureBox1;
        private Label lblFoundPassword;
        private Label lblTimeTaken;
        private TextBox txtHashToCrack;
        private TextBox txtDictionaryPath1;
        private Button btnStartHashCracking;
        private Label lblHashCrackStatus;
        private Button btnChooseDictionary1;
        private Label label1;
        private Button btnGenerateDictionary;
        private ComboBox comboBoxHashAlgorithm;
        private Button btnVisualizeGraph;
        private Button btnUseRainbowTable;
        private System.Windows.Forms.TextBox txtRainbowTableOutput;
        private Button btnCrackHashes;





        private void InitializeComponent()
        {



            btnUseRainbowTable = new Button
            {
                Location = new Point(520, 380),
                Name = "btnUseRainbowTable",
                Size = new Size(470, 40),
                Text = "Use Rainbow Table",
                BackColor = Color.FromArgb(85, 85, 110)
            };
            btnUseRainbowTable.Click += btnUseRainbowTable_Click;
            Controls.Add(btnUseRainbowTable);



            this.txtRainbowTableOutput = new System.Windows.Forms.TextBox();
            this.txtRainbowTableOutput.Location = new System.Drawing.Point(12, 440);  // Set appropriate location
            this.txtRainbowTableOutput.Multiline = true;  // Allow multiline input
            this.txtRainbowTableOutput.Size = new System.Drawing.Size(400, 100);  // Set the size
            this.Controls.Add(this.txtRainbowTableOutput);




            btnCrackHashes = new Button
            {
                Location = new Point(690, 430),  // Adjust the position as needed
                Name = "btnCrackHashes",
                Size = new Size(300, 40),
                Text = "Crack Hashes",
                BackColor = Color.FromArgb(100, 100, 130)
            };
            btnCrackHashes.Click += BtnCrackHashes_Click;  // Event handler for button click

            Controls.Add(btnCrackHashes);







            txtFilePath = new TextBox
            {
                Location = new Point(20, 160),
                Name = "txtFilePath",
                Size = new Size(300, 25),
                PlaceholderText = "Enter file path"
            };

            txtDictionaryPath = new TextBox
            {
                Location = new Point(20, 200),
                Name = "txtDictionaryPath",
                Size = new Size(300, 25),
                PlaceholderText = "Enter dictionary file path"
            };

            btnBrowseFile = new Button
            {
                Location = new Point(340, 160),
                Name = "btnBrowseFile",
                Size = new Size(150, 30),
                Text = "Choose File",
                BackColor = Color.FromArgb(70, 70, 90)
            };
            btnBrowseFile.Click += btnBrowseFile_Click; 

            btnBrowseDictionary = new Button
            {
                Location = new Point(340, 200),
                Name = "btnBrowseDictionary",
                Size = new Size(150, 30),
                Text = "Choose Dictionary",
                BackColor = Color.FromArgb(70, 70, 90)
            };
            btnBrowseDictionary.Click += btnBrowseDictionary_Click; 

            btnStart = new Button
            {
                Location = new Point(20, 250),
                Name = "btnStart",
                Size = new Size(470, 40),
                Text = "Start File Password Recovery",
                BackColor = Color.FromArgb(85, 85, 110)
            };
            btnStart.Click += btnStart_Click; 

            lblStatus = new Label
            {
                Location = new Point(20, 300),
                Name = "lblStatus",
                Size = new Size(470, 30),
                Text = "Status: Waiting..."
            };

            pictureBox1 = new PictureBox
            {
                Image = Properties.Resources.bpass,
                Location = new Point(20, 20),
                Name = "pictureBox1",
                Size = new Size(500, 120),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            lblFoundPassword = new Label
            {
                Location = new Point(20, 340),
                Name = "lblFoundPassword",
                Size = new Size(470, 30),
                Text = "Password: "
            };

            lblTimeTaken = new Label
            {
                Location = new Point(520, 40),
                Name = "lblTimeTaken",
                Size = new Size(300, 30),
                Text = "Time Taken: "
            };

            txtHashToCrack = new TextBox
            {
                Location = new Point(520, 160),
                Name = "txtHashToCrack",
                Size = new Size(300, 25),
                PlaceholderText = "Enter hash to crack"
            };

            txtDictionaryPath1 = new TextBox
            {
                Location = new Point(520, 200),
                Name = "txtDictionaryPath1",
                Size = new Size(300, 25),
                PlaceholderText = "Enter dictionary file path"
            };

            btnStartHashCracking = new Button
            {
                Location = new Point(520, 250),
                Name = "btnStartHashCracking",
                Size = new Size(470, 40),
                Text = "Start Hash Cracking",
                BackColor = Color.FromArgb(85, 85, 110)
            };
            btnStartHashCracking.Click += btnStartHashCracking_Click; 

            lblHashCrackStatus = new Label
            {
                Location = new Point(520, 300),
                Name = "lblHashCrackStatus",
                Size = new Size(470, 30),
                Text = "Hash Status: Waiting..."
            };

            btnChooseDictionary1 = new Button
            {
                Location = new Point(840, 200),
                Name = "btnChooseDictionary1",
                Size = new Size(150, 30),
                Text = "Choose Dictionary",
                BackColor = Color.FromArgb(70, 70, 90)
            };
            btnChooseDictionary1.Click += btnChooseDictionary1_Click; 

            label1 = new Label
            {
                Location = new Point(840, 160),
                Name = "label1",
                Size = new Size(150, 27),
                Text = "<-- Input Hash Here"
            };

            btnGenerateDictionary = new Button
            {
                Location = new Point(690, 431),
                Name = "btnGenerateDictionary",
                Size = new Size(300, 40),
                Text = "Generate Dictionary",
                BackColor = Color.FromArgb(100, 100, 130)
            };
            btnGenerateDictionary.Click += btnGenerateDictionary_Click_1; 


            comboBoxHashAlgorithm = new ComboBox
            {
                Location = new Point(984, 160),
                Name = "comboBoxHashAlgorithm",
                Size = new Size(117, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            comboBoxHashAlgorithm.Items.AddRange(new object[] { "MD5", "SHA1", "SHA256" });
            comboBoxHashAlgorithm.SelectedIndexChanged += comboBoxHashAlgorithm_SelectedIndexChanged; 

            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(1200, 612);
            Controls.Add(comboBoxHashAlgorithm);
            Controls.Add(txtFilePath);
            Controls.Add(txtDictionaryPath);
            Controls.Add(btnBrowseFile);
            Controls.Add(btnBrowseDictionary);
            Controls.Add(btnStart);
            Controls.Add(lblStatus);
            Controls.Add(pictureBox1);
            Controls.Add(lblFoundPassword);
            Controls.Add(lblTimeTaken);
            Controls.Add(txtHashToCrack);
            Controls.Add(txtDictionaryPath1);
            Controls.Add(btnStartHashCracking);
            Controls.Add(lblHashCrackStatus);
            Controls.Add(btnChooseDictionary1);
            Controls.Add(label1);
            Controls.Add(btnGenerateDictionary);
            Controls.Add(btnCrackHashes);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Pretty PRTK - Password Recovery Toolkit";
        }
        private void BtnCrackHashes_Click(object sender, EventArgs e)
        {
            // Open the HashCrackingForm when the button is clicked
            HashCrackingForm hashForm = new HashCrackingForm();
            hashForm.Show();
        }
    }
}
