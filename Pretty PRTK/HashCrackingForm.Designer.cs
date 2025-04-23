namespace Pretty_PRTK
{
    partial class HashCrackingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtHashToCrack = new TextBox();
            txtDictionaryPath1 = new TextBox();
            btnChooseDictionary1 = new Button();
            comboBoxHashAlgorithm = new ComboBox();
            btnStartHashCracking = new Button();
            lblHashCrackStatus = new Label();
            btnUseRainbowTable = new Button();
            txtRainbowTableOutput = new TextBox();
            SuspendLayout();
            // 
            // txtHashToCrack
            // 
            txtHashToCrack.Location = new Point(34, 31);
            txtHashToCrack.Name = "txtHashToCrack";
            txtHashToCrack.PlaceholderText = "Enter Hash Here...";
            txtHashToCrack.Size = new Size(153, 23);
            txtHashToCrack.TabIndex = 0;
            txtHashToCrack.TextChanged += txtHashToCrack_TextChanged;
            // 
            // txtDictionaryPath1
            // 
            txtDictionaryPath1.Location = new Point(34, 91);
            txtDictionaryPath1.Name = "txtDictionaryPath1";
            txtDictionaryPath1.PlaceholderText = "Select Dictionary Path...";
            txtDictionaryPath1.Size = new Size(153, 23);
            txtDictionaryPath1.TabIndex = 1;
            txtDictionaryPath1.TextChanged += txtDictionaryPath1_TextChanged;
            // 
            // btnChooseDictionary1
            // 
            btnChooseDictionary1.Location = new Point(228, 91);
            btnChooseDictionary1.Name = "btnChooseDictionary1";
            btnChooseDictionary1.Size = new Size(121, 23);
            btnChooseDictionary1.TabIndex = 2;
            btnChooseDictionary1.Text = "Browse";
            btnChooseDictionary1.UseVisualStyleBackColor = true;
            btnChooseDictionary1.Click += btnChooseDictionary1_Click;
            // 
            // comboBoxHashAlgorithm
            // 
            comboBoxHashAlgorithm.FormattingEnabled = true;
            comboBoxHashAlgorithm.Location = new Point(228, 31);
            comboBoxHashAlgorithm.Name = "comboBoxHashAlgorithm";
            comboBoxHashAlgorithm.Size = new Size(121, 23);
            comboBoxHashAlgorithm.TabIndex = 3;
            comboBoxHashAlgorithm.SelectedIndexChanged += comboBoxHashAlgorithm_SelectedIndexChanged;
            // 
            // btnStartHashCracking
            // 
            btnStartHashCracking.Location = new Point(34, 145);
            btnStartHashCracking.Name = "btnStartHashCracking";
            btnStartHashCracking.Size = new Size(153, 23);
            btnStartHashCracking.TabIndex = 4;
            btnStartHashCracking.Text = "Start Hash Cracking";
            btnStartHashCracking.UseVisualStyleBackColor = true;
            btnStartHashCracking.Click += btnStartHashCracking_Click;
            // 
            // lblHashCrackStatus
            // 
            lblHashCrackStatus.AutoSize = true;
            lblHashCrackStatus.Location = new Point(34, 212);
            lblHashCrackStatus.Name = "lblHashCrackStatus";
            lblHashCrackStatus.Size = new Size(134, 15);
            lblHashCrackStatus.TabIndex = 5;
            lblHashCrackStatus.Text = "Status will appear here...";
            lblHashCrackStatus.Click += lblHashCrackStatus_Click;
            // 
            // btnUseRainbowTable
            // 
            btnUseRainbowTable.Location = new Point(478, 31);
            btnUseRainbowTable.Name = "btnUseRainbowTable";
            btnUseRainbowTable.Size = new Size(216, 46);
            btnUseRainbowTable.TabIndex = 6;
            btnUseRainbowTable.Text = "Rainbow Table";
            btnUseRainbowTable.UseVisualStyleBackColor = true;
            btnUseRainbowTable.Click += btnUseRainbowTable_Click;
            // 
            // txtRainbowTableOutput
            // 
            txtRainbowTableOutput.Location = new Point(478, 103);
            txtRainbowTableOutput.Multiline = true;
            txtRainbowTableOutput.Name = "txtRainbowTableOutput";
            txtRainbowTableOutput.Size = new Size(216, 33);
            txtRainbowTableOutput.TabIndex = 7;
            // 
            // HashCrackingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(800, 450);
            Controls.Add(txtRainbowTableOutput);
            Controls.Add(btnUseRainbowTable);
            Controls.Add(lblHashCrackStatus);
            Controls.Add(btnStartHashCracking);
            Controls.Add(comboBoxHashAlgorithm);
            Controls.Add(btnChooseDictionary1);
            Controls.Add(txtDictionaryPath1);
            Controls.Add(txtHashToCrack);
            Name = "HashCrackingForm";
            Text = "HashCrackingForm";
            Load += HashCrackingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHashToCrack;
        private TextBox txtDictionaryPath1;
        private Button btnChooseDictionary1;
        private ComboBox comboBoxHashAlgorithm;
        private Button btnStartHashCracking;
        private Label lblHashCrackStatus;
        private Button btnUseRainbowTable;
        private TextBox txtRainbowTableOutput;
    }
}