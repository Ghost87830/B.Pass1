namespace Pretty_PRTK
{
    partial class EthicsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EthicsForm));
            label1 = new Label();
            checkBoxAgree = new CheckBox();
            btnContinue = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(25, 20);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(731, 168);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // checkBoxAgree
            // 
            checkBoxAgree.AutoSize = true;
            checkBoxAgree.ForeColor = SystemColors.ControlLightLight;
            checkBoxAgree.Location = new Point(355, 368);
            checkBoxAgree.Name = "checkBoxAgree";
            checkBoxAgree.Size = new Size(219, 64);
            checkBoxAgree.TabIndex = 1;
            checkBoxAgree.Text = "I understand that misuse of this tool \r\nis not permitted and the developer\r\nassumes no resposnability for the\r\nmisuse of this tool.";
            checkBoxAgree.UseVisualStyleBackColor = true;
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(596, 368);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(192, 58);
            btnContinue.TabIndex = 2;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // EthicsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 60);
            ClientSize = new Size(800, 450);
            Controls.Add(btnContinue);
            Controls.Add(checkBoxAgree);
            Controls.Add(label1);
            Name = "EthicsForm";
            Text = "EthicsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox checkBoxAgree;
        private Button btnContinue;
        public Label label1;
    }
}