namespace config2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblIniList = new System.Windows.Forms.Label();
            this.cbIniList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSerial = new System.Windows.Forms.Label();
            this.btnActivate = new System.Windows.Forms.Button();
            this.lblTextSerial = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblTextType = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 27);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(129, 13);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Path of configuration files:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(15, 44);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(474, 20);
            this.txtPath.TabIndex = 1;
            // 
            // lblIniList
            // 
            this.lblIniList.AutoSize = true;
            this.lblIniList.Location = new System.Drawing.Point(12, 91);
            this.lblIniList.Name = "lblIniList";
            this.lblIniList.Size = new System.Drawing.Size(138, 13);
            this.lblIniList.TabIndex = 2;
            this.lblIniList.Text = "Select an INI file to activate";
            // 
            // cbIniList
            // 
            this.cbIniList.FormattingEnabled = true;
            this.cbIniList.Location = new System.Drawing.Point(15, 107);
            this.cbIniList.Name = "cbIniList";
            this.cbIniList.Size = new System.Drawing.Size(474, 21);
            this.cbIniList.TabIndex = 3;
            this.cbIniList.SelectedIndexChanged += new System.EventHandler(this.cbIniList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSerial);
            this.groupBox1.Controls.Add(this.btnActivate);
            this.groupBox1.Controls.Add(this.lblTextSerial);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.cbIniList);
            this.groupBox1.Controls.Add(this.lblTextType);
            this.groupBox1.Controls.Add(this.lblPath);
            this.groupBox1.Controls.Add(this.lblIniList);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 172);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Configuration files ";
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(302, 146);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(10, 13);
            this.lblSerial.TabIndex = 3;
            this.lblSerial.Text = "-";
            // 
            // btnActivate
            // 
            this.btnActivate.Enabled = false;
            this.btnActivate.Location = new System.Drawing.Point(524, 107);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(75, 23);
            this.btnActivate.TabIndex = 5;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // lblTextSerial
            // 
            this.lblTextSerial.AutoSize = true;
            this.lblTextSerial.Location = new System.Drawing.Point(243, 146);
            this.lblTextSerial.Name = "lblTextSerial";
            this.lblTextSerial.Size = new System.Drawing.Size(53, 13);
            this.lblTextSerial.TabIndex = 1;
            this.lblTextSerial.Text = "Serial No:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(91, 146);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(10, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "-";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(524, 44);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblTextType
            // 
            this.lblTextType.AutoSize = true;
            this.lblTextType.Location = new System.Drawing.Point(12, 146);
            this.lblTextType.Name = "lblTextType";
            this.lblTextType.Size = new System.Drawing.Size(73, 13);
            this.lblTextType.TabIndex = 0;
            this.lblTextType.Text = "Scanner type:";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 200);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Configuration INI Changer Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblIniList;
        private System.Windows.Forms.ComboBox cbIniList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTextSerial;
        private System.Windows.Forms.Label lblTextType;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

