
namespace LordBete_s_Desktop_Cleaner
{
    partial class LordBetesDirectoryCleaner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LordBetesDirectoryCleaner));
            this.btnDirectoryA = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDirectoryB = new System.Windows.Forms.Button();
            this.btnCleanDirectory = new System.Windows.Forms.Button();
            this.txtDirTarget = new System.Windows.Forms.TextBox();
            this.txtDirToClean = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimise = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAuditLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tltipBrowse = new System.Windows.Forms.ToolTip(this.components);
            this.tltipSave = new System.Windows.Forms.ToolTip(this.components);
            this.tltipClean = new System.Windows.Forms.ToolTip(this.components);
            this.tltipMinimise = new System.Windows.Forms.ToolTip(this.components);
            this.tltipClose = new System.Windows.Forms.ToolTip(this.components);
            this.btnAbout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.spindleR = new System.Windows.Forms.PictureBox();
            this.spindleL = new System.Windows.Forms.PictureBox();
            this.tltipAuditLog = new System.Windows.Forms.ToolTip(this.components);
            this.tltipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_Settings = new System.Windows.Forms.Button();
            this.tltipSettings = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spindleR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spindleL)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDirectoryA
            // 
            this.btnDirectoryA.BackColor = System.Drawing.Color.Transparent;
            this.btnDirectoryA.BackgroundImage = global::LordBete_s_Desktop_Cleaner.Properties.Resources.browse_icon_dithered1;
            this.btnDirectoryA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDirectoryA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDirectoryA.FlatAppearance.BorderSize = 0;
            this.btnDirectoryA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(135)))), ((int)(((byte)(154)))));
            this.btnDirectoryA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(135)))), ((int)(((byte)(154)))));
            this.btnDirectoryA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectoryA.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDirectoryA.Location = new System.Drawing.Point(697, 163);
            this.btnDirectoryA.Name = "btnDirectoryA";
            this.btnDirectoryA.Size = new System.Drawing.Size(23, 23);
            this.btnDirectoryA.TabIndex = 0;
            this.btnDirectoryA.UseVisualStyleBackColor = false;
            this.btnDirectoryA.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Location = new System.Drawing.Point(398, 331);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(0, 14);
            this.lblHelloWorld.TabIndex = 1;
            // 
            // btnDirectoryB
            // 
            this.btnDirectoryB.BackColor = System.Drawing.Color.Transparent;
            this.btnDirectoryB.BackgroundImage = global::LordBete_s_Desktop_Cleaner.Properties.Resources.browse_icon_dithered1;
            this.btnDirectoryB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDirectoryB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDirectoryB.FlatAppearance.BorderSize = 0;
            this.btnDirectoryB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(135)))), ((int)(((byte)(154)))));
            this.btnDirectoryB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(135)))), ((int)(((byte)(154)))));
            this.btnDirectoryB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectoryB.Location = new System.Drawing.Point(697, 212);
            this.btnDirectoryB.Name = "btnDirectoryB";
            this.btnDirectoryB.Size = new System.Drawing.Size(23, 25);
            this.btnDirectoryB.TabIndex = 5;
            this.btnDirectoryB.UseVisualStyleBackColor = false;
            this.btnDirectoryB.Click += new System.EventHandler(this.btnTargetDirectory_Click);
            // 
            // btnCleanDirectory
            // 
            this.btnCleanDirectory.BackColor = System.Drawing.Color.Transparent;
            this.btnCleanDirectory.BackgroundImage = global::LordBete_s_Desktop_Cleaner.Properties.Resources.Button_thin_border;
            this.btnCleanDirectory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCleanDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCleanDirectory.FlatAppearance.BorderSize = 0;
            this.btnCleanDirectory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(135)))), ((int)(((byte)(154)))));
            this.btnCleanDirectory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(135)))), ((int)(((byte)(154)))));
            this.btnCleanDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleanDirectory.Location = new System.Drawing.Point(364, 434);
            this.btnCleanDirectory.Name = "btnCleanDirectory";
            this.btnCleanDirectory.Size = new System.Drawing.Size(183, 30);
            this.btnCleanDirectory.TabIndex = 7;
            this.btnCleanDirectory.Text = "Clean";
            this.btnCleanDirectory.UseVisualStyleBackColor = false;
            this.btnCleanDirectory.Click += new System.EventHandler(this.btnCleanDirectory_Click);
            // 
            // txtDirTarget
            // 
            this.txtDirTarget.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDirTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirTarget.Location = new System.Drawing.Point(211, 222);
            this.txtDirTarget.Name = "txtDirTarget";
            this.txtDirTarget.Size = new System.Drawing.Size(480, 15);
            this.txtDirTarget.TabIndex = 10;
            this.txtDirTarget.Text = "//Paste  Directory for organised files or Browse ->";
            this.txtDirTarget.TextChanged += new System.EventHandler(this.txtDirTarget_TextChanged);
            // 
            // txtDirToClean
            // 
            this.txtDirToClean.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDirToClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirToClean.Location = new System.Drawing.Point(211, 170);
            this.txtDirToClean.Name = "txtDirToClean";
            this.txtDirToClean.Size = new System.Drawing.Size(480, 16);
            this.txtDirToClean.TabIndex = 9;
            this.txtDirToClean.Text = "//Paste  Directory to organise or Browse ->";
            this.txtDirToClean.TextChanged += new System.EventHandler(this.txtDirToClean_TextChanged);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            this.progressBar.Location = new System.Drawing.Point(351, 521);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(210, 13);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::LordBete_s_Desktop_Cleaner.Properties.Resources.btn_close_sansserif;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(173)))), ((int)(((byte)(197)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(173)))), ((int)(((byte)(197)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(882, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(19, 20);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimise
            // 
            this.btnMinimise.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimise.BackgroundImage = global::LordBete_s_Desktop_Cleaner.Properties.Resources.btn_minimise_sansserif;
            this.btnMinimise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimise.FlatAppearance.BorderSize = 0;
            this.btnMinimise.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(173)))), ((int)(((byte)(197)))));
            this.btnMinimise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(173)))), ((int)(((byte)(197)))));
            this.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimise.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimise.Location = new System.Drawing.Point(857, 12);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Size = new System.Drawing.Size(19, 20);
            this.btnMinimise.TabIndex = 13;
            this.btnMinimise.UseVisualStyleBackColor = false;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAuditLog
            // 
            this.btnAuditLog.BackColor = System.Drawing.Color.Transparent;
            this.btnAuditLog.BackgroundImage = global::LordBete_s_Desktop_Cleaner.Properties.Resources.Button_thin_border;
            this.btnAuditLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAuditLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuditLog.FlatAppearance.BorderSize = 0;
            this.btnAuditLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(135)))), ((int)(((byte)(154)))));
            this.btnAuditLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(135)))), ((int)(((byte)(154)))));
            this.btnAuditLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuditLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuditLog.Location = new System.Drawing.Point(364, 470);
            this.btnAuditLog.Name = "btnAuditLog";
            this.btnAuditLog.Size = new System.Drawing.Size(183, 30);
            this.btnAuditLog.TabIndex = 15;
            this.btnAuditLog.Text = "Audit Log";
            this.btnAuditLog.UseVisualStyleBackColor = false;
            this.btnAuditLog.Click += new System.EventHandler(this.btnAuditLog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(865, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "v0.9";
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.BackgroundImage = global::LordBete_s_Desktop_Cleaner.Properties.Resources.Button_thin_border;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(173)))), ((int)(((byte)(197)))));
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(173)))), ((int)(((byte)(197)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(2, 514);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(66, 20);
            this.btnAbout.TabIndex = 17;
            this.btnAbout.Text = "Help";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(56, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Track 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(56, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Track 2:";
            // 
            // spindleR
            // 
            this.spindleR.BackColor = System.Drawing.Color.Transparent;
            this.spindleR.Image = global::LordBete_s_Desktop_Cleaner.Properties.Resources.Untitled_1;
            this.spindleR.Location = new System.Drawing.Point(596, 288);
            this.spindleR.Name = "spindleR";
            this.spindleR.Size = new System.Drawing.Size(77, 79);
            this.spindleR.TabIndex = 18;
            this.spindleR.TabStop = false;
            // 
            // spindleL
            // 
            this.spindleL.BackColor = System.Drawing.Color.Transparent;
            this.spindleL.Image = global::LordBete_s_Desktop_Cleaner.Properties.Resources.Untitled_1;
            this.spindleL.Location = new System.Drawing.Point(235, 288);
            this.spindleL.Name = "spindleL";
            this.spindleL.Size = new System.Drawing.Size(77, 79);
            this.spindleL.TabIndex = 18;
            this.spindleL.TabStop = false;
            // 
            // Btn_Settings
            // 
            this.Btn_Settings.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Settings.BackgroundImage = global::LordBete_s_Desktop_Cleaner.Properties.Resources.btn_Settings;
            this.Btn_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Settings.FlatAppearance.BorderSize = 0;
            this.Btn_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.Btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Settings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Settings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Settings.Location = new System.Drawing.Point(832, 12);
            this.Btn_Settings.Name = "Btn_Settings";
            this.Btn_Settings.Size = new System.Drawing.Size(19, 20);
            this.Btn_Settings.TabIndex = 19;
            this.Btn_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_Settings.UseVisualStyleBackColor = false;
            this.Btn_Settings.Click += new System.EventHandler(this.Btn_Settings_Click);
            // 
            // LordBetesDirectoryCleaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::LordBete_s_Desktop_Cleaner.Properties.Resources.frame_border_tape_09;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 538);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Settings);
            this.Controls.Add(this.spindleL);
            this.Controls.Add(this.spindleR);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.txtDirTarget);
            this.Controls.Add(this.btnDirectoryB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDirToClean);
            this.Controls.Add(this.btnDirectoryA);
            this.Controls.Add(this.btnAuditLog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimise);
            this.Controls.Add(this.btnCleanDirectory);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.progressBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Monosans", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(913, 538);
            this.MinimizeBox = false;
            this.Name = "LordBetesDirectoryCleaner";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "LordBete\'s Directory Organiser";
            this.DoubleClick += new System.EventHandler(this.LordBetesDirectoryCleaner_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.spindleR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spindleL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDirectoryA;
        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnDirectoryB;
        private System.Windows.Forms.Button btnCleanDirectory;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimise;
        private System.Windows.Forms.TextBox txtDirTarget;
        private System.Windows.Forms.TextBox txtDirToClean;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnAuditLog;
        private System.Windows.Forms.ToolTip tltipBrowse;
        private System.Windows.Forms.ToolTip tltipSave;
        private System.Windows.Forms.ToolTip tltipClean;
        private System.Windows.Forms.ToolTip tltipMinimise;
        private System.Windows.Forms.ToolTip tltipClose;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox spindleR;
        private System.Windows.Forms.PictureBox spindleL;
        private System.Windows.Forms.ToolTip tltipAuditLog;
        private System.Windows.Forms.ToolTip tltipHelp;
        private System.Windows.Forms.Button Btn_Settings;
        private System.Windows.Forms.ToolTip tltipSettings;
    }
}

