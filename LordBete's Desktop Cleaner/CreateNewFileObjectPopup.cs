using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LordBete_s_Desktop_Cleaner
{
    public partial class CreateNewFileObjectPopup : Form
    {
        private DirectoryManager dm = DirectoryManager.GetInstance();

        public CreateNewFileObjectPopup()
        {
            InitializeComponent();
        }

        private void BtnSaveFileObject_Click(object sender, EventArgs e)
        {
            if(TxtNewName.Text != "" && TxtNewDefaultLocation.Text != "" && TxtNewFileTypes.Text != "")
            {
                FileObject FO = new FileObject()
                {
                    Name = TxtNewName.Text,
                    DefaultLocation = TxtNewDefaultLocation.Text,
                    FileTypes = Utilities.CleanArrayFromString(TxtNewFileTypes.Text)
                };
                dm.Filters.Add(FO);
                // dm.settings.SetComboBoxSelectionToLast();
                dm.settings.UpdateComboBox(FO.Name);

                string title = "New Filter";
                string message = "New Filter Created!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)                
                    this.Close();
                
            }
            else
            {
                string title = "Missing data";
                string message = "You can't save with missing data!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons);
            }



        }

        private void BtnCloseNewFileObjectWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Make window moveable
        protected override void WndProc(ref Message m)
        {

            base.WndProc(ref m);

            if (m.Msg == 0x00A3) // WM_NCLBUTTONDBLCLK            
                this.WindowState = FormWindowState.Normal;

            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
    }
}
