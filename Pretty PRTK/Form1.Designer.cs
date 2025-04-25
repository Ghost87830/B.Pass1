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
        private Button btnGenerateDictionary;
        private Button btnOpenHashCracker;
        private Button btnEthics;


        private void InitializeComponent()
        {



            btnOpenHashCracker = new Button
            {
                Location = new Point(540, 400),
                Name = "btnOpenHashCracker",
                Size = new Size(300, 48),
                Text = "Open Hash Cracker",
                BackColor = Color.FromArgb(100, 100, 130)
            };
            btnOpenHashCracker.Click += btnOpenHashCracker_Click;
            Controls.Add(btnOpenHashCracker);




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

            btnGenerateDictionary = new Button
            {
                Location = new Point(540, 300),
                Name = "btnGenerateDictionary",
                Size = new Size(300, 40),
                Text = "Generate Dictionary",
                BackColor = Color.FromArgb(100, 100, 130)
            };
            btnGenerateDictionary.Click += btnGenerateDictionary_Click_1;



            btnEthics = new Button
            {
                Location = new Point(735, 70),
                Name = "btnEthics",
                Size = new Size(100, 40),
                Text = "Ethics",
                BackColor = Color.FromArgb(100, 100, 130)
            };
            btnEthics.Click += btnEthics_Click;




            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(900, 450);
            Controls.Add(txtFilePath);
            Controls.Add(txtDictionaryPath);
            Controls.Add(btnBrowseFile);
            Controls.Add(btnBrowseDictionary);
            Controls.Add(btnStart);
            Controls.Add(lblStatus);
            Controls.Add(pictureBox1);
            Controls.Add(lblFoundPassword);
            Controls.Add(lblTimeTaken);
            Controls.Add(btnGenerateDictionary);
            Controls.Add(btnEthics);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Pretty PRTK - Password Recovery Toolkit";
        }
    }
}
