namespace IntunePackagingTool
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.txtSrcDir = new System.Windows.Forms.TextBox();
            this.btnSelectSrcDir = new System.Windows.Forms.Button();
            this.btnSelectInstaller = new System.Windows.Forms.Button();
            this.txtInstaller = new System.Windows.Forms.TextBox();
            this.btnSelectOutput = new System.Windows.Forms.Button();
            this.txtOutDir = new System.Windows.Forms.TextBox();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.lblInstructionsHead = new System.Windows.Forms.Label();
            this.lblOne = new System.Windows.Forms.Label();
            this.lblTwo = new System.Windows.Forms.Label();
            this.lblThree = new System.Windows.Forms.Label();
            this.lblFour = new System.Windows.Forms.Label();
            this.btnBuildPackage = new System.Windows.Forms.Button();
            this.txtConsoleOutput = new System.Windows.Forms.TextBox();
            this.btnOpenOutDir = new System.Windows.Forms.Button();
            this.chkRenamePackageFile = new System.Windows.Forms.CheckBox();
            this.txtRenameFile = new System.Windows.Forms.TextBox();
            this.label_generic = new System.Windows.Forms.Label();
            this.lblExpectedFileName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSrcDir
            // 
            this.txtSrcDir.Location = new System.Drawing.Point(11, 193);
            this.txtSrcDir.Name = "txtSrcDir";
            this.txtSrcDir.Size = new System.Drawing.Size(273, 20);
            this.txtSrcDir.TabIndex = 0;
            // 
            // btnSelectSrcDir
            // 
            this.btnSelectSrcDir.Location = new System.Drawing.Point(290, 191);
            this.btnSelectSrcDir.Name = "btnSelectSrcDir";
            this.btnSelectSrcDir.Size = new System.Drawing.Size(87, 23);
            this.btnSelectSrcDir.TabIndex = 1;
            this.btnSelectSrcDir.Text = "Select Src Dir";
            this.btnSelectSrcDir.UseVisualStyleBackColor = true;
            this.btnSelectSrcDir.Click += new System.EventHandler(this.btnSelectSrcDir_Click);
            // 
            // btnSelectInstaller
            // 
            this.btnSelectInstaller.Location = new System.Drawing.Point(290, 224);
            this.btnSelectInstaller.Name = "btnSelectInstaller";
            this.btnSelectInstaller.Size = new System.Drawing.Size(87, 23);
            this.btnSelectInstaller.TabIndex = 3;
            this.btnSelectInstaller.Text = "Select Installer";
            this.btnSelectInstaller.UseVisualStyleBackColor = true;
            this.btnSelectInstaller.Click += new System.EventHandler(this.btnSelectInstaller_Click);
            // 
            // txtInstaller
            // 
            this.txtInstaller.Location = new System.Drawing.Point(11, 226);
            this.txtInstaller.Name = "txtInstaller";
            this.txtInstaller.Size = new System.Drawing.Size(273, 20);
            this.txtInstaller.TabIndex = 2;
            this.txtInstaller.TextChanged += new System.EventHandler(this.txtInstaller_TextChanged);
            // 
            // btnSelectOutput
            // 
            this.btnSelectOutput.Location = new System.Drawing.Point(290, 257);
            this.btnSelectOutput.Name = "btnSelectOutput";
            this.btnSelectOutput.Size = new System.Drawing.Size(87, 23);
            this.btnSelectOutput.TabIndex = 5;
            this.btnSelectOutput.Text = "Select Out Dir";
            this.btnSelectOutput.UseVisualStyleBackColor = true;
            this.btnSelectOutput.Click += new System.EventHandler(this.btnSelectOutput_Click);
            // 
            // txtOutDir
            // 
            this.txtOutDir.Location = new System.Drawing.Point(11, 259);
            this.txtOutDir.Name = "txtOutDir";
            this.txtOutDir.Size = new System.Drawing.Size(273, 20);
            this.txtOutDir.TabIndex = 4;
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyRight.Location = new System.Drawing.Point(103, 424);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(198, 12);
            this.lblCopyRight.TabIndex = 6;
            this.lblCopyRight.Text = "Copyright © 2021 jParnell - All Rights Reserved";
            // 
            // lblInstructionsHead
            // 
            this.lblInstructionsHead.AutoSize = true;
            this.lblInstructionsHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructionsHead.Location = new System.Drawing.Point(149, 13);
            this.lblInstructionsHead.Name = "lblInstructionsHead";
            this.lblInstructionsHead.Size = new System.Drawing.Size(90, 16);
            this.lblInstructionsHead.TabIndex = 7;
            this.lblInstructionsHead.Text = "Instructions:";
            // 
            // lblOne
            // 
            this.lblOne.Location = new System.Drawing.Point(12, 36);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(365, 30);
            this.lblOne.TabIndex = 8;
            this.lblOne.Text = "1. Click the button to select your source directory that contains all your packag" +
    "e files.";
            // 
            // lblTwo
            // 
            this.lblTwo.Location = new System.Drawing.Point(12, 73);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(365, 32);
            this.lblTwo.TabIndex = 9;
            this.lblTwo.Text = "2. Click the button to select the primary installer file, be that MSI, executable" +
    ", or script.";
            // 
            // lblThree
            // 
            this.lblThree.Location = new System.Drawing.Point(12, 112);
            this.lblThree.Name = "lblThree";
            this.lblThree.Size = new System.Drawing.Size(365, 32);
            this.lblThree.TabIndex = 10;
            this.lblThree.Text = "3. Click the button to select the directory that the .intunewin package file will" +
    " be output to.";
            // 
            // lblFour
            // 
            this.lblFour.Location = new System.Drawing.Point(12, 151);
            this.lblFour.Name = "lblFour";
            this.lblFour.Size = new System.Drawing.Size(365, 32);
            this.lblFour.TabIndex = 11;
            this.lblFour.Text = "4. Click the \"Build Package\" button to build the .intunewin package file. Upload " +
    "that file to your MEM instance.";
            // 
            // btnBuildPackage
            // 
            this.btnBuildPackage.Location = new System.Drawing.Point(151, 375);
            this.btnBuildPackage.Name = "btnBuildPackage";
            this.btnBuildPackage.Size = new System.Drawing.Size(87, 39);
            this.btnBuildPackage.TabIndex = 12;
            this.btnBuildPackage.Text = "Build Package";
            this.btnBuildPackage.UseVisualStyleBackColor = true;
            this.btnBuildPackage.Click += new System.EventHandler(this.btnBuildPackage_Click);
            // 
            // txtConsoleOutput
            // 
            this.txtConsoleOutput.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtConsoleOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.txtConsoleOutput.Location = new System.Drawing.Point(413, 13);
            this.txtConsoleOutput.Multiline = true;
            this.txtConsoleOutput.Name = "txtConsoleOutput";
            this.txtConsoleOutput.Size = new System.Drawing.Size(814, 353);
            this.txtConsoleOutput.TabIndex = 13;
            // 
            // btnOpenOutDir
            // 
            this.btnOpenOutDir.Location = new System.Drawing.Point(290, 285);
            this.btnOpenOutDir.Name = "btnOpenOutDir";
            this.btnOpenOutDir.Size = new System.Drawing.Size(87, 23);
            this.btnOpenOutDir.TabIndex = 14;
            this.btnOpenOutDir.Text = "Open Out Dir";
            this.btnOpenOutDir.UseVisualStyleBackColor = true;
            this.btnOpenOutDir.Click += new System.EventHandler(this.btnOpenOutDir_Click);
            // 
            // chkRenamePackageFile
            // 
            this.chkRenamePackageFile.AutoSize = true;
            this.chkRenamePackageFile.Location = new System.Drawing.Point(11, 328);
            this.chkRenamePackageFile.Name = "chkRenamePackageFile";
            this.chkRenamePackageFile.Size = new System.Drawing.Size(205, 17);
            this.chkRenamePackageFile.TabIndex = 15;
            this.chkRenamePackageFile.Text = "Rename package file after building to:";
            this.chkRenamePackageFile.UseVisualStyleBackColor = true;
            this.chkRenamePackageFile.CheckedChanged += new System.EventHandler(this.chkRenamePackageFile_CheckedChanged);
            // 
            // txtRenameFile
            // 
            this.txtRenameFile.Location = new System.Drawing.Point(11, 351);
            this.txtRenameFile.Name = "txtRenameFile";
            this.txtRenameFile.Size = new System.Drawing.Size(273, 20);
            this.txtRenameFile.TabIndex = 16;
            // 
            // label_generic
            // 
            this.label_generic.AutoSize = true;
            this.label_generic.Location = new System.Drawing.Point(12, 290);
            this.label_generic.Name = "label_generic";
            this.label_generic.Size = new System.Drawing.Size(105, 13);
            this.label_generic.TabIndex = 17;
            this.label_generic.Text = "Expected File Name:";
            // 
            // lblExpectedFileName
            // 
            this.lblExpectedFileName.AutoSize = true;
            this.lblExpectedFileName.Location = new System.Drawing.Point(12, 306);
            this.lblExpectedFileName.Name = "lblExpectedFileName";
            this.lblExpectedFileName.Size = new System.Drawing.Size(35, 13);
            this.lblExpectedFileName.TabIndex = 18;
            this.lblExpectedFileName.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = ".intunewin";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 447);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblExpectedFileName);
            this.Controls.Add(this.label_generic);
            this.Controls.Add(this.txtRenameFile);
            this.Controls.Add(this.chkRenamePackageFile);
            this.Controls.Add(this.btnOpenOutDir);
            this.Controls.Add(this.txtConsoleOutput);
            this.Controls.Add(this.btnBuildPackage);
            this.Controls.Add(this.lblFour);
            this.Controls.Add(this.lblThree);
            this.Controls.Add(this.lblTwo);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.lblInstructionsHead);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.btnSelectOutput);
            this.Controls.Add(this.txtOutDir);
            this.Controls.Add(this.btnSelectInstaller);
            this.Controls.Add(this.txtInstaller);
            this.Controls.Add(this.btnSelectSrcDir);
            this.Controls.Add(this.txtSrcDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.Text = "Intune Packaging Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.Load += new System.EventHandler(this.formMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSrcDir;
        private System.Windows.Forms.Button btnSelectSrcDir;
        private System.Windows.Forms.Button btnSelectInstaller;
        private System.Windows.Forms.TextBox txtInstaller;
        private System.Windows.Forms.Button btnSelectOutput;
        private System.Windows.Forms.TextBox txtOutDir;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.Label lblInstructionsHead;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.Label lblThree;
        private System.Windows.Forms.Label lblFour;
        private System.Windows.Forms.Button btnBuildPackage;
        private System.Windows.Forms.TextBox txtConsoleOutput;
        private System.Windows.Forms.Button btnOpenOutDir;
        private System.Windows.Forms.CheckBox chkRenamePackageFile;
        private System.Windows.Forms.TextBox txtRenameFile;
        private System.Windows.Forms.Label label_generic;
        private System.Windows.Forms.Label lblExpectedFileName;
        private System.Windows.Forms.Label label2;
    }
}

