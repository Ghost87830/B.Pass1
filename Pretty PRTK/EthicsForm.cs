using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pretty_PRTK
{
    public partial class EthicsForm : Form
    {
        public EthicsForm()
        {

            InitializeComponent();
        }





        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (checkBoxAgree.Checked)
            {
                this.DialogResult = DialogResult.OK; // Close the form and indicate user has agreed
                this.Close();
            }
            else
            {
                MessageBox.Show("You must agree to the ethical use terms before proceeding.", "Agreement Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 14); 
            label1.ForeColor = Color.White; 
        }



    }
}
