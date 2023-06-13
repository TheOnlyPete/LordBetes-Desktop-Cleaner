
namespace LordBete_s_Desktop_Cleaner
{
    partial class LordBetesDirectoryCleanerSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LordBetesDirectoryCleanerSettings));
            this.btn_back = new System.Windows.Forms.Button();
            this.Dir_DefaultSource = new System.Windows.Forms.TextBox();
            this.Dir_DefaultTarget = new System.Windows.Forms.TextBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.BtnViewFileObjects = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnDirectorySource = new System.Windows.Forms.Button();
            this.BtnDirectoryTarget = new System.Windows.Forms.Button();
            this.TxtFolderName = new System.Windows.Forms.TextBox();
            this.TxtFileTypes = new System.Windows.Forms.TextBox();
            this.comboBox_Types = new System.Windows.Forms.ComboBox();
            this.Btn_CreateNewFileObject = new System.Windows.Forms.Button();
            this.tltipCreateNewFilter = new System.Windows.Forms.ToolTip(this.components);
            this.tltipBrowseSource = new System.Windows.Forms.ToolTip(this.components);
            this.TltipBrowseTarget = new System.Windows.Forms.ToolTip(this.components);
            this.tltipSave = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_Question_Directory = new System.Windows.Forms.Button();
            this.Btn_Question_FileTypes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Tltip_Help = new System.Windows.Forms.ToolTip(this.components);
            this.Tltip_EditJson = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = global::LordBete_s_Desktop_Cleaner.Properties.Resources.btn_backarrow;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(34, 31);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = " ";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Dir_DefaultSource
            // 
            this.Dir_DefaultSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dir_DefaultSource.Location = new System.Drawing.Point(202, 164);
            this.Dir_DefaultSource.Name = "Dir_DefaultSource";
            this.Dir_DefaultSource.Size = new System.Drawing.Size(492, 23);
            this.Dir_DefaultSource.TabIndex = 10;
            this.Dir_DefaultSource.Text = "//Paste  Directory to organise or Browse ->";
            this.Dir_DefaultSource.TextChanged += new System.EventHandler(this.Dir_DefaultSource_TextChanged);
            // 
            // Dir_DefaultTarget
            // 
            this.Dir_DefaultTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dir_DefaultTarget.Location = new System.Drawing.Point(202, 215);
            this.Dir_DefaultTarget.Name = "Dir_DefaultTarget";
            this.Dir_DefaultTarget.Size = new System.Drawing.Size(492, 23);
            this.Dir_DefaultTarget.TabIndex = 11;
            this.Dir_DefaultTarget.Text = "//Paste  Directory for organised files or Browse ->";
            this.Dir_DefaultTarget.TextChanged += new System.EventHandler(this.Dir_DefaultTarget_TextChanged);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveSettings.BackgroundImage = global::LordBete_s_Desktop_Cleaner.Properties.Resources.save_icon_win_98;
            this.btnSaveSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveSettings.FlatAppearance.BorderSize = 0;
            this.btnSaveSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSaveSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveSettings.Location = new System.Drawing.Point(882, 506);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(19, 20);
            this.btnSaveSettings.TabIndex = 12;
            this.btnSaveSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // BtnViewFileObjects
            // 
            this.BtnViewFileObjects.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnViewFileObjects.BackColor = System.Drawing.Color.Transparent;
            this.BtnViewFileObjects.BackgroundImage = global::LordBete_s_Desktop_Cleaner.Properties.Resources.Button_thin_border;
            this.BtnViewFileObjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnViewFileObjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnViewFileObjects.FlatAppearance.BorderSize = 0;
            this.BtnViewFileObjects.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(135)))), ((int)(((byte)(154)))));
            this.BtnViewFileObjects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(135)))), ((int)(((byte)(154)))));
            this.BtnViewFileObjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViewFileObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewFileObjects.Location = new System.Drawing.Point(202, 411);
            this.BtnViewFileObjects.Name = "BtnViewFileObjects";
            this.BtnViewFileObjects.Size = new System.Drawing.Size(183, 30);
            this.BtnViewFileObjects.TabIndex = 13;
            this.BtnViewFileObjects.Text = "Edit Json";
            this.BtnViewFileObjects.UseVisualStyleBackColor = false;
            this.BtnViewFileObjects.Click += new System.EventHandler(this.BtnViewFileObjects_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(66, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Default Target:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(66, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Default Source:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Settings";
            // 
            // BtnDirectorySource
            // 
            this.BtnDirectorySource.BackColor = System.Drawing.Color.Transparent;
            this.BtnDirectorySource.BackgroundImage = global::LordBete_s_Desktop_Cleaner.Properties.Resources.browse_icon_dithered1;
            this.BtnDirectorySource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDirectorySource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDirectorySource.FlatAppearance.BorderSize = 0;
            this.BtnDirectorySource.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(135)))), ((int)(((byte)(154)))));
            this.BtnDirectorySource.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(135)))), ((int)(((byte)(154)))));
            this.BtnDirectorySource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDirectorySource.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnDirectorySource.Location = new System.Drawing.Point(700, 164);
            this.BtnDirectorySource.Name = "BtnDirectorySource";
            this.BtnDirectorySource.Size = new System.Drawing.Size(23, 23);
            this.BtnDirectorySource.TabIndex = 19;
            this.BtnDirectorySource.UseVisualStyleBackColor = false;
            this.BtnDirectorySource.Click += new System.EventHandler(this.BtnDirectorySource_Click);
            // 
            // BtnDirectoryTarget
            // 
            this.BtnDirectoryTarget.BackColor = System.Drawing.Color.Transparent;
            this.BtnDirectoryTarget.BackgroundImage = global::LordBete_s_Desktop_Cleaner.Properties.Resources.browse_icon_dithered1;
            this.BtnDirectoryTarget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDirectoryTarget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDirectoryTarget.FlatAppearance.BorderSize = 0;
            this.BtnDirectoryTarget.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(135)))), ((int)(((byte)(154)))));
            this.BtnDirectoryTarget.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(135)))), ((int)(((byte)(154)))));
            this.BtnDirectoryTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDirectoryTarget.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnDirectoryTarget.Location = new System.Drawing.Point(700, 215);
            this.BtnDirectoryTarget.Name = "BtnDirectoryTarget";
            this.BtnDirectoryTarget.Size = new System.Drawing.Size(23, 23);
            this.BtnDirectoryTarget.TabIndex = 20;
            this.BtnDirectoryTarget.UseVisualStyleBackColor = false;
            this.BtnDirectoryTarget.Click += new System.EventHandler(this.BtnDirectoryTarget_Click);
            // 
            // TxtFolderName
            // 
            this.TxtFolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFolderName.Location = new System.Drawing.Point(202, 319);
            this.TxtFolderName.Name = "TxtFolderName";
            this.TxtFolderName.Size = new System.Drawing.Size(492, 23);
            this.TxtFolderName.TabIndex = 24;
            this.TxtFolderName.Text = "\\Directory";
            this.TxtFolderName.TextChanged += new System.EventHandler(this.TxtFolderName_TextChanged);
            // 
            // TxtFileTypes
            // 
            this.TxtFileTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFileTypes.Location = new System.Drawing.Point(202, 369);
            this.TxtFileTypes.Name = "TxtFileTypes";
            this.TxtFileTypes.Size = new System.Drawing.Size(492, 23);
            this.TxtFileTypes.TabIndex = 25;
            this.TxtFileTypes.Text = "File Types";
            this.TxtFileTypes.TextChanged += new System.EventHandler(this.TxtFileTypes_TextChanged);
            // 
            // comboBox_Types
            // 
            this.comboBox_Types.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Types.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Types.FormattingEnabled = true;
            this.comboBox_Types.Items.AddRange(new object[] {
            "Testing123"});
            this.comboBox_Types.Location = new System.Drawing.Point(202, 256);
            this.comboBox_Types.Name = "comboBox_Types";
            this.comboBox_Types.Size = new System.Drawing.Size(188, 21);
            this.comboBox_Types.TabIndex = 26;
            this.comboBox_Types.SelectedIndexChanged += new System.EventHandler(this.comboBox_Types_SelectedIndexChanged);
            // 
            // Btn_CreateNewFileObject
            // 
            this.Btn_CreateNewFileObject.BackColor = System.Drawing.Color.Transparent;
            this.Btn_CreateNewFileObject.BackgroundImage = global::LordBete_s_Desktop_Cleaner.Properties.Resources.Btn_NewItem;
            this.Btn_CreateNewFileObject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_CreateNewFileObject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CreateNewFileObject.FlatAppearance.BorderSize = 0;
            this.Btn_CreateNewFileObject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_CreateNewFileObject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_CreateNewFileObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CreateNewFileObject.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_CreateNewFileObject.Location = new System.Drawing.Point(396, 256);
            this.Btn_CreateNewFileObject.Name = "Btn_CreateNewFileObject";
            this.Btn_CreateNewFileObject.Size = new System.Drawing.Size(26, 21);
            this.Btn_CreateNewFileObject.TabIndex = 27;
            this.Btn_CreateNewFileObject.UseVisualStyleBackColor = false;
            this.Btn_CreateNewFileObject.Click += new System.EventHandler(this.Btn_CreateNewFileObject_Click);
            // 
            // Btn_Question_Directory
            // 
            this.Btn_Question_Directory.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Question_Directory.BackgroundImage = global::LordBete_s_Desktop_Cleaner.Properties.Resources.Btn_Questionmark1;
            this.Btn_Question_Directory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Question_Directory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Question_Directory.FlatAppearance.BorderSize = 0;
            this.Btn_Question_Directory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Question_Directory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Question_Directory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Question_Directory.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Question_Directory.Location = new System.Drawing.Point(696, 319);
            this.Btn_Question_Directory.Name = "Btn_Question_Directory";
            this.Btn_Question_Directory.Size = new System.Drawing.Size(21, 21);
            this.Btn_Question_Directory.TabIndex = 28;
            this.Btn_Question_Directory.UseVisualStyleBackColor = false;
            this.Btn_Question_Directory.Click += new System.EventHandler(this.Btn_Question_Directory_Click);
            // 
            // Btn_Question_FileTypes
            // 
            this.Btn_Question_FileTypes.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Question_FileTypes.BackgroundImage = global::LordBete_s_Desktop_Cleaner.Properties.Resources.Btn_Questionmark;
            this.Btn_Question_FileTypes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Question_FileTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Question_FileTypes.FlatAppearance.BorderSize = 0;
            this.Btn_Question_FileTypes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Question_FileTypes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Question_FileTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Question_FileTypes.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Question_FileTypes.Location = new System.Drawing.Point(696, 370);
            this.Btn_Question_FileTypes.Name = "Btn_Question_FileTypes";
            this.Btn_Question_FileTypes.Size = new System.Drawing.Size(21, 21);
            this.Btn_Question_FileTypes.TabIndex = 29;
            this.Btn_Question_FileTypes.UseVisualStyleBackColor = false;
            this.Btn_Question_FileTypes.Click += new System.EventHandler(this.Btn_Question_FileTypes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(66, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Filters:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(66, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Folder:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(66, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "File Types:";
            // 
            // LordBetesDirectoryCleanerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 538);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Question_FileTypes);
            this.Controls.Add(this.Btn_Question_Directory);
            this.Controls.Add(this.Btn_CreateNewFileObject);
            this.Controls.Add(this.comboBox_Types);
            this.Controls.Add(this.TxtFileTypes);
            this.Controls.Add(this.TxtFolderName);
            this.Controls.Add(this.BtnDirectoryTarget);
            this.Controls.Add(this.BtnDirectorySource);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnViewFileObjects);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.Dir_DefaultTarget);
            this.Controls.Add(this.Dir_DefaultSource);
            this.Controls.Add(this.btn_back);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(913, 538);
            this.Name = "LordBetesDirectoryCleanerSettings";
            this.Text = "LordBete\'s Directory Organiser Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox Dir_DefaultSource;
        private System.Windows.Forms.TextBox Dir_DefaultTarget;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button BtnViewFileObjects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnDirectorySource;
        private System.Windows.Forms.Button BtnDirectoryTarget;
        private System.Windows.Forms.TextBox TxtFolderName;
        private System.Windows.Forms.TextBox TxtFileTypes;
        private System.Windows.Forms.ComboBox comboBox_Types;
        private System.Windows.Forms.Button Btn_CreateNewFileObject;
        private System.Windows.Forms.ToolTip tltipCreateNewFilter;
        private System.Windows.Forms.ToolTip tltipBrowseSource;
        private System.Windows.Forms.ToolTip TltipBrowseTarget;
        private System.Windows.Forms.ToolTip tltipSave;
        private System.Windows.Forms.Button Btn_Question_Directory;
        private System.Windows.Forms.Button Btn_Question_FileTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip Tltip_Help;
        private System.Windows.Forms.ToolTip Tltip_EditJson;
    }
}