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

    public partial class LordBetesDirectoryCleanerSettings : Form
    {
        private DirectoryManager dm = DirectoryManager.GetInstance();
        CommonOpenFileDialog dialog = new CommonOpenFileDialog();
        bool txtBoxesUpdatable = false;
        bool dataSaved = true;
        string sourceDir = "";
        string targetDir = "";
        string targetFolder = "";
        string fileTypes = "";


        public LordBetesDirectoryCleanerSettings()
        {
            InitializeComponent();
            InitialiseComboBox();
            SetupToolTips();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            dm.cleanerSettings = this;
            dm.settings = this;
            SetComboBoxSelectionToLast();
            Dir_DefaultSource.Text = dm._directoryObject.sourceDirectory;
            Dir_DefaultTarget.Text = dm._directoryObject.targetDirectory;
        }

        public void InitialiseComboBox()
        {
            comboBox_Types.Items.Clear();
            foreach (FileObject fo in dm.Filters)
            {
                comboBox_Types.Items.Add(fo.Name);
            }
           
            if(comboBox_Types.Items.Count > 0)
                comboBox_Types.SelectedIndex = 0;

        }

        public void UpdateComboBox(string name)
        {
            comboBox_Types.Items.Add(name);
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            if (!dataSaved)
            {
                string message = "Do you want to exit without saving changes?";
                string title = "Exit Without Saving";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    ReturnToMainWindow();
                }
            }
            else
            {
                ReturnToMainWindow();
            }



        }

        public void ReturnToMainWindow()
        {
            this.Hide();
            dm.directoryCleaner.Location = new Point(this.Location.X, this.Location.Y);
            dm.directoryCleaner.Show();
        }
        public void SetupToolTips()
        {
            tltipCreateNewFilter.SetToolTip(Btn_CreateNewFileObject, "Create New Filter");
            tltipBrowseSource.SetToolTip(BtnDirectorySource, "Browse");
            TltipBrowseTarget.SetToolTip(BtnDirectoryTarget, "Browse");
            tltipSave.SetToolTip(btnSaveSettings, "Save");
            Tltip_Help.SetToolTip(Btn_Question_Directory, "Help");
            Tltip_Help.SetToolTip(Btn_Question_FileTypes, "Help");
            Tltip_EditJson.SetToolTip(BtnViewFileObjects, "Opens a Json file containing all filters");
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        //Save Directories Popup
        public void SaveChanges()
        {
            string message = "Do you want to save your changes?";
            string title = "Save Changes";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                dataSaved = true;
                dm.UpdateJsonObjects();

                dm._directoryObject.sourceDirectory = sourceDir;
                dm._directoryObject.targetDirectory = targetDir;
                dm.cleaner.InitialiseDirectories();
                UpdateSelectedFilter();
                dm.UpdateJsonObjects();
            }
        }

        private void BtnViewFileObjects_Click(object sender, EventArgs e)
        {
            Process.Start(FileManager._programDataFolder + FileManager._ConfigFolder + FileManager._filtersJsonFile);
        }

        private void BtnDirectorySource_Click(object sender, EventArgs e)
        {
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                dm._directoryObject.sourceDirectory = dialog.FileName;
            Dir_DefaultSource.Text = dm._directoryObject.sourceDirectory;
        }

        private void BtnDirectoryTarget_Click(object sender, EventArgs e)
        {
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                dm._directoryObject.targetDirectory = dialog.FileName;
            Dir_DefaultTarget.Text = dm._directoryObject.targetDirectory;
        }

        private void Dir_DefaultSource_TextChanged(object sender, EventArgs e)
        {
            dataSaved = false;
            sourceDir = Dir_DefaultSource.Text;
        }

        private void Dir_DefaultTarget_TextChanged(object sender, EventArgs e)
        {
            dataSaved = false;
            targetDir = Dir_DefaultTarget.Text;
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

        private void comboBox_Types_SelectedIndexChanged(object sender, EventArgs e)//Show selected item
        {
            dataSaved = true;//The data isn't actually saved, I'm just setting this so that the pop up doesn't show when you press the back button
            DisplayFileObject();
            targetFolder = TxtFolderName.Text;
            fileTypes = TxtFileTypes.Text;

        }

        public void DisplayFileObject()
        {
            txtBoxesUpdatable = false;

            for (int i = 0; i < dm.Filters.Count; i++)
            {
                if (dm.Filters[i].Name == comboBox_Types.SelectedItem.ToString())
                {
                    TxtFolderName.Text = dm.Filters[i].DefaultLocation;

                    TxtFileTypes.Text = String.Join(", ", dm.Filters[i].FileTypes);

                }
            }

            txtBoxesUpdatable = true;
        }

        public void UpdateSelectedFilter()
        {
            for (int i = 0; i < dm.Filters.Count; i++) //The FileObjects shown in the drop down
            {
                if (dm.Filters[i].Name == comboBox_Types.SelectedItem.ToString())
                {
                    dm.Filters[i].DefaultLocation = targetFolder;
                    dm.Filters[i].FileTypes = Utilities.CleanArrayFromString(fileTypes);
                }
            }
        }

        public void SetComboBoxSelectionToLast()
        {
            comboBox_Types.SelectedItem = comboBox_Types.Items.Count - 1;
        }
        private void TxtFolderName_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxesUpdatable)
            {
                dataSaved = false;
                targetFolder = TxtFolderName.Text;
            }
        }

        private void TxtFileTypes_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxesUpdatable)
            {
                dataSaved = false;
                fileTypes = TxtFileTypes.Text;
            }
        }

        private void Btn_CreateNewFileObject_Click(object sender, EventArgs e)
        {
            CreateNewFileObjectPopup createNewFileObjectPopup = new CreateNewFileObjectPopup();
            createNewFileObjectPopup.Show();
            createNewFileObjectPopup.Location = new Point(this.Location.X, this.Location.Y);

            //UpdateJsonFile
        }

        private void Btn_Question_Directory_Click(object sender, EventArgs e)
        {
            string message = "Here you can set the name of the folder that the files will be moved to." + "\n" 
                + "Please ensure your folder name starts with a backslash " + "(\\)" + "\n\n" + "Example:" + " " + @"""" + "\\Pictures" + @"""";
            string title = "Directory";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons);
        }

        private void Btn_Question_FileTypes_Click(object sender, EventArgs e)
        {
            string message = "Here you can change the file types that will be detected by the software. \n" + "Please Separate each file type by comma (,). Spaces are optional.\n\nExample: " + @"""" + "png, jpg, gif" + @"""";
            string title = "File Types";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons);
        }
    }
}
