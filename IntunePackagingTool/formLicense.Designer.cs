namespace IntunePackagingTool
{
    partial class formLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLicense));
            this.lblLicense = new System.Windows.Forms.Label();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.chkbxAgreeToLicense = new System.Windows.Forms.CheckBox();
            this.btnAgree = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicense.Location = new System.Drawing.Point(194, 9);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(164, 20);
            this.lblLicense.TabIndex = 0;
            this.lblLicense.Text = "License Agreement";
            // 
            // txtLicense
            // 
            this.txtLicense.Location = new System.Drawing.Point(12, 39);
            this.txtLicense.Multiline = true;
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(528, 252);
            this.txtLicense.TabIndex = 1;
            this.txtLicense.TabStop = false;
            this.txtLicense.Text = resources.GetString("txtLicense.Text");
            // 
            // chkbxAgreeToLicense
            // 
            this.chkbxAgreeToLicense.AutoSize = true;
            this.chkbxAgreeToLicense.Location = new System.Drawing.Point(187, 304);
            this.chkbxAgreeToLicense.Name = "chkbxAgreeToLicense";
            this.chkbxAgreeToLicense.Size = new System.Drawing.Size(178, 17);
            this.chkbxAgreeToLicense.TabIndex = 2;
            this.chkbxAgreeToLicense.Text = "I agree to the license agreement";
            this.chkbxAgreeToLicense.UseVisualStyleBackColor = true;
            // 
            // btnAgree
            // 
            this.btnAgree.Location = new System.Drawing.Point(239, 327);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Size = new System.Drawing.Size(75, 35);
            this.btnAgree.TabIndex = 3;
            this.btnAgree.Text = "Proceed";
            this.btnAgree.UseVisualStyleBackColor = true;
            this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnQuit.Location = new System.Drawing.Point(466, 327);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 35);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit w/o Accepting";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 345);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GNU GPL v2";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // formLicense
            // 
            this.AcceptButton = this.btnAgree;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 370);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnAgree);
            this.Controls.Add(this.chkbxAgreeToLicense);
            this.Controls.Add(this.txtLicense);
            this.Controls.Add(this.lblLicense);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formLicense";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "License";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.formLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.CheckBox chkbxAgreeToLicense;
        private System.Windows.Forms.Button btnAgree;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}