using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Pretty_PRTK
{
    partial class CreateDictionaryForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private TextBox txtName;
        private TextBox txtSecondName;
        private TextBox txtPetName;
        private TextBox txtPartnerName;
        private TextBox txtFavouriteFilm;
        private MaskedTextBox maskedTxtDOB;
        private TextBox txtCurrentTown;
        private TextBox txtFavouriteFood;
        private Button btnGenerateDictionary1;
        private Label lblName;
        private Label lblSecondName;
        private Label lblPetName;
        private Label lblPartnerName;
        private Label lblFavouriteFilm;
        private Label lblDOB;
        private Label lblCurrentTown;
        private Label lblFavouriteFood;

        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtSecondName = new TextBox();
            txtPetName = new TextBox();
            txtPartnerName = new TextBox();
            maskedTxtDOB = new MaskedTextBox();
            txtFavouriteFilm = new TextBox();
            txtCurrentTown = new TextBox();
            txtFavouriteFood = new TextBox();
            btnGenerateDictionary1 = new Button();
            lblName = new Label();
            lblDOB = new Label();
            lblPetName = new Label();
            lblPartnerName = new Label();
            lblFavouriteFilm = new Label();
            lblSecondName = new Label();
            lblCurrentTown = new Label();
            lblFavouriteFood = new Label();
            txtKeywordInput = new TextBox();
            btnAddKeyword = new Button();
            lstKeywords = new ListBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(14, 74);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(184, 25);
            txtName.TabIndex = 0;
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(14, 123);
            txtSecondName.Margin = new Padding(3, 2, 3, 2);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(184, 25);
            txtSecondName.TabIndex = 1;
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(14, 171);
            txtPetName.Margin = new Padding(3, 2, 3, 2);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(184, 25);
            txtPetName.TabIndex = 2;
            // 
            // txtPartnerName
            // 
            txtPartnerName.Location = new Point(14, 219);
            txtPartnerName.Margin = new Padding(3, 2, 3, 2);
            txtPartnerName.Name = "txtPartnerName";
            txtPartnerName.Size = new Size(184, 25);
            txtPartnerName.TabIndex = 3;
            // 
            // maskedTxtDOB
            // 
            maskedTxtDOB.Location = new Point(14, 316);
            maskedTxtDOB.Mask = "00/00/0000";
            maskedTxtDOB.Name = "maskedTxtDOB";
            maskedTxtDOB.Size = new Size(184, 25);
            maskedTxtDOB.TabIndex = 5;
            // 
            // txtFavouriteFilm
            // 
            txtFavouriteFilm.Location = new Point(14, 267);
            txtFavouriteFilm.Margin = new Padding(3, 2, 3, 2);
            txtFavouriteFilm.Name = "txtFavouriteFilm";
            txtFavouriteFilm.Size = new Size(184, 25);
            txtFavouriteFilm.TabIndex = 4;
            // 
            // txtCurrentTown
            // 
            txtCurrentTown.Location = new Point(14, 365);
            txtCurrentTown.Margin = new Padding(3, 2, 3, 2);
            txtCurrentTown.Name = "txtCurrentTown";
            txtCurrentTown.Size = new Size(184, 25);
            txtCurrentTown.TabIndex = 7;
            // 
            // txtFavouriteFood
            // 
            txtFavouriteFood.Location = new Point(14, 413);
            txtFavouriteFood.Margin = new Padding(3, 2, 3, 2);
            txtFavouriteFood.Name = "txtFavouriteFood";
            txtFavouriteFood.Size = new Size(184, 25);
            txtFavouriteFood.TabIndex = 8;
            // 
            // btnGenerateDictionary1
            // 
            btnGenerateDictionary1.BackColor = Color.FromArgb(70, 70, 90);
            btnGenerateDictionary1.Location = new Point(610, 381);
            btnGenerateDictionary1.Margin = new Padding(3, 2, 3, 2);
            btnGenerateDictionary1.Name = "btnGenerateDictionary1";
            btnGenerateDictionary1.Size = new Size(178, 57);
            btnGenerateDictionary1.TabIndex = 10;
            btnGenerateDictionary1.Text = "Generate Dictionary";
            btnGenerateDictionary1.UseVisualStyleBackColor = false;
            btnGenerateDictionary1.Click += btnGenerateDictionary1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(14, 55);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 19);
            lblName.TabIndex = 12;
            lblName.Text = "Name";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(14, 297);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(87, 19);
            lblDOB.TabIndex = 17;
            lblDOB.Text = "Date of Birth";
            // 
            // lblPetName
            // 
            lblPetName.AutoSize = true;
            lblPetName.Location = new Point(14, 152);
            lblPetName.Name = "lblPetName";
            lblPetName.Size = new Size(68, 19);
            lblPetName.TabIndex = 14;
            lblPetName.Text = "Pet Name";
            // 
            // lblPartnerName
            // 
            lblPartnerName.AutoSize = true;
            lblPartnerName.Location = new Point(14, 200);
            lblPartnerName.Name = "lblPartnerName";
            lblPartnerName.Size = new Size(94, 19);
            lblPartnerName.TabIndex = 15;
            lblPartnerName.Text = "Partner Name";
            // 
            // lblFavouriteFilm
            // 
            lblFavouriteFilm.AutoSize = true;
            lblFavouriteFilm.Location = new Point(14, 248);
            lblFavouriteFilm.Name = "lblFavouriteFilm";
            lblFavouriteFilm.Size = new Size(95, 19);
            lblFavouriteFilm.TabIndex = 16;
            lblFavouriteFilm.Text = "Favourite Film";
            // 
            // lblSecondName
            // 
            lblSecondName.AutoSize = true;
            lblSecondName.Location = new Point(14, 104);
            lblSecondName.Name = "lblSecondName";
            lblSecondName.Size = new Size(93, 19);
            lblSecondName.TabIndex = 13;
            lblSecondName.Text = "Second Name";
            // 
            // lblCurrentTown
            // 
            lblCurrentTown.AutoSize = true;
            lblCurrentTown.Location = new Point(14, 346);
            lblCurrentTown.Name = "lblCurrentTown";
            lblCurrentTown.Size = new Size(92, 19);
            lblCurrentTown.TabIndex = 18;
            lblCurrentTown.Text = "Current Town";
            // 
            // lblFavouriteFood
            // 
            lblFavouriteFood.AutoSize = true;
            lblFavouriteFood.Location = new Point(14, 394);
            lblFavouriteFood.Name = "lblFavouriteFood";
            lblFavouriteFood.Size = new Size(101, 19);
            lblFavouriteFood.TabIndex = 19;
            lblFavouriteFood.Text = "Favourite Food";
            // 
            // txtKeywordInput
            // 
            txtKeywordInput.Location = new Point(263, 200);
            txtKeywordInput.Name = "txtKeywordInput";
            txtKeywordInput.PlaceholderText = "Enter keyword";
            txtKeywordInput.Size = new Size(150, 25);
            txtKeywordInput.TabIndex = 20;
            // 
            // btnAddKeyword
            // 
            btnAddKeyword.Location = new Point(423, 200);
            btnAddKeyword.Name = "btnAddKeyword";
            btnAddKeyword.Size = new Size(100, 25);
            btnAddKeyword.TabIndex = 1;
            btnAddKeyword.Text = "Add Keyword";
            btnAddKeyword.Click += BtnAddKeyword_Click;
            // 
            // lstKeywords
            // 
            lstKeywords.ItemHeight = 17;
            lstKeywords.Location = new Point(263, 247);
            lstKeywords.Name = "lstKeywords";
            lstKeywords.Size = new Size(260, 191);
            lstKeywords.TabIndex = 2;
            // 
            // CreateDictionaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(800, 500);
            Controls.Add(txtKeywordInput);
            Controls.Add(btnAddKeyword);
            Controls.Add(lstKeywords);
            Controls.Add(lblFavouriteFood);
            Controls.Add(lblCurrentTown);
            Controls.Add(lblSecondName);
            Controls.Add(txtFavouriteFood);
            Controls.Add(txtCurrentTown);
            Controls.Add(txtSecondName);
            Controls.Add(lblFavouriteFilm);
            Controls.Add(lblPartnerName);
            Controls.Add(lblPetName);
            Controls.Add(lblDOB);
            Controls.Add(lblName);
            Controls.Add(btnGenerateDictionary1);
            Controls.Add(txtFavouriteFilm);
            Controls.Add(txtPartnerName);
            Controls.Add(txtPetName);
            Controls.Add(maskedTxtDOB);
            Controls.Add(txtName);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            Name = "CreateDictionaryForm";
            Text = "Create Dictionary";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}