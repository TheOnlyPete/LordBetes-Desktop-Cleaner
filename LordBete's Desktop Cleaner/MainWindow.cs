using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.Diagnostics;
using Microsoft.WindowsAPICodePack.Dialogs;



namespace LordBete_s_Desktop_Cleaner
{
    public partial class LordBetesDirectoryCleaner : Form
    {
        private readonly CommonOpenFileDialog dialog = new CommonOpenFileDialog();
        private readonly DirectoryManager dm = DirectoryManager.GetInstance();
        bool allowTick = false;
        int FileCount => FileManager.TotalFileCount(dm._directoryObject);
        public LordBetesDirectoryCleaner()
        {
            dm.cleaner = this;
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if(File.Exists(FileManager._programDataFolder + FileManager._auditDirectory + FileManager._fileHistoryAudit))
            {
                FileInfo fs = new FileInfo(FileManager._programDataFolder + FileManager._auditDirectory + FileManager._fileHistoryAudit);
                long fileSizeInMB = fs.Length / (1024 * 1024);
               Console.WriteLine(fileSizeInMB + "Test");
                if(fileSizeInMB > 5)                
                    File.Delete(FileManager._programDataFolder + FileManager._auditDirectory + FileManager._fileHistoryAudit);
                
            }
            InitializeComponent();
            
            progressBar.Maximum = FileCount;
            InitialiseDirectories();
            dm.directoryCleaner = this;
            progressBar.Visible = true;
            timer1.Interval = (1 * 500);
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            btnAuditLog.Visible = false;
            SetUpToolTips();           
            SpindleAnimHandler(false);
        }

        public void SetUpToolTips()
        {
            tltipBrowse.SetToolTip(btnDirectoryA, "Browse");
            tltipBrowse.SetToolTip(btnDirectoryB, "Browse");
            tltipClean.SetToolTip(btnCleanDirectory, "Organise Files into target folder");
            tltipMinimise.SetToolTip(btnMinimise, "Minimise");
            tltipClose.SetToolTip(btnClose, "Close");
            tltipSettings.SetToolTip(Btn_Settings, "Settings");
        }

        public void InitialiseDirectories()
        {
            txtDirToClean.Text = dm._directoryObject.sourceDirectory;
            txtDirTarget.Text = dm._directoryObject.targetDirectory;
        }

        //Browse Directory to clean
        private void btnClickMe_Click(object sender, EventArgs e)
        {
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                dm._directoryObject.sourceDirectory = dialog.FileName;
            txtDirToClean.Text = dm._directoryObject.sourceDirectory;

        }

        //Browse Target Directory
        private void btnTargetDirectory_Click(object sender, EventArgs e)
        {
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                dm._directoryObject.targetDirectory = dialog.FileName;
            txtDirTarget.Text = dm._directoryObject.targetDirectory;
        }

        //Update Directory to clean path
        private void txtDirToClean_TextChanged(object sender, EventArgs e)
        {
            dm._directoryObject.sourceDirectory = txtDirToClean.Text;
        }

        //Update Target Directory path 
        private void txtDirTarget_TextChanged(object sender, EventArgs e)
        {
            dm._directoryObject.targetDirectory = txtDirTarget.Text;
        }

        //Clean Directories
        private void btnCleanDirectory_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            SpindleAnimHandler(true);
            allowTick = true;

            var threadParameters = new System.Threading.ThreadStart(delegate { dm.CleanDirectory(); }); // Create a new thread to do the cleaning so the main thread is free
            var thread2 = new System.Threading.Thread(threadParameters);
            thread2.Start();

        }

        //Update progress bar over time
        private void timer1_Tick(object sender, EventArgs e)
        {
   


            if (allowTick)
            {
                if (progressBar.Maximum < dm.value)
                    progressBar.Maximum = dm.value + 1;
                progressBar.Value = dm.value;
                progressBar.Refresh();

                if (dm.Finished)
                    Finished();                   
            }

        }


        public void Finished()
        {
            allowTick = false;
            progressBar.Maximum = 1;
            progressBar.Value = progressBar.Maximum;
            progressBar.Refresh();
            SpindleAnimHandler(false);
            string message = "Finished!";
            MessageBox.Show(message);
            btnAuditLog.Visible = true;

        }
        //Minise Application
        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Close Application
        private void btnClose_Click(object sender, EventArgs e)
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

        private void btnAuditLog_Click(object sender, EventArgs e)
        {
            if(File.Exists(FileManager._programDataFolder + FileManager._auditDirectory + FileManager._fileHistoryAudit))
                Process.Start(FileManager._programDataFolder + FileManager._auditDirectory + FileManager._fileHistoryAudit);
            else
            {
                string message = "No Audit File Found.";
                MessageBox.Show(message);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            string title = "LordBete's Directory Organiser";
            string usage = "To Use: \n 1, Choose a directory you would like to organise \n 2, Choose a directory to put the organised files into \n 3, Clean! \n 4, Profit!";
            string settings = "\n\nTo set new default directories, click the settings icon and set the default directories then press the save icon! \n\nTo change the file types detected by this software or their destination folder, go to settings > Edit File Types";
            string footer = "\n\nCreated by LordBete#0001";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(usage + settings + footer, title, buttons);
        }
        public void SpindleAnimHandler(bool enabled)
        {
            spindleL.Enabled = enabled;
            spindleR.Enabled = enabled;

        }
        private void Btn_Settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (dm.cleanerSettings == null)            
                dm.cleanerSettings = new LordBetesDirectoryCleanerSettings();
            
            dm.cleanerSettings.Show();
            dm.cleanerSettings.Location = new Point(this.Location.X, this.Location.Y);


        }

        private void LordBetesDirectoryCleaner_DoubleClick(object sender, EventArgs e)
        {

                this.WindowState = FormWindowState.Normal;
            
        }
    }



}
