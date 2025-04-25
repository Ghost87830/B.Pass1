using System;
using System.Windows.Forms;

namespace Pretty_PRTK
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show EthicsForm first
            EthicsForm ethicsForm = new EthicsForm();
            DialogResult result = ethicsForm.ShowDialog();  // Show as modal and wait for user interaction

            // If the user agrees to the terms (i.e., closes the EthicsForm), then start Form1
            if (result == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
        }
    }
}
