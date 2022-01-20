﻿namespace LiveResults.Client
{
    partial class OEForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OEForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtZeroTime = new System.Windows.Forms.TextBox();
            this.lblZeroTime = new System.Windows.Forms.Label();
            this.lblFormatInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtOEDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompID = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.fsWatcherOS = new System.IO.FileSystemWatcher();
            this.label4 = new System.Windows.Forms.Label();
            this.chkUploadStarttimes = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.chkAutoCreateRadioControls = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsWatcherOS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtZeroTime);
            this.groupBox1.Controls.Add(this.lblZeroTime);
            this.groupBox1.Controls.Add(this.lblFormatInfo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbFormat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtExtension);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtOEDirectory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(622, 360);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // txtZeroTime
            // 
            this.txtZeroTime.Location = new System.Drawing.Point(318, 310);
            this.txtZeroTime.Margin = new System.Windows.Forms.Padding(6);
            this.txtZeroTime.Name = "txtZeroTime";
            this.txtZeroTime.Size = new System.Drawing.Size(288, 31);
            this.txtZeroTime.TabIndex = 12;
            // 
            // lblZeroTime
            // 
            this.lblZeroTime.AutoSize = true;
            this.lblZeroTime.Location = new System.Drawing.Point(14, 315);
            this.lblZeroTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblZeroTime.Name = "lblZeroTime";
            this.lblZeroTime.Size = new System.Drawing.Size(290, 25);
            this.lblZeroTime.TabIndex = 13;
            this.lblZeroTime.Text = "Event ZeroTime (HH:MM:SS)";
            // 
            // lblFormatInfo
            // 
            this.lblFormatInfo.Location = new System.Drawing.Point(14, 260);
            this.lblFormatInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFormatInfo.Name = "lblFormatInfo";
            this.lblFormatInfo.Size = new System.Drawing.Size(596, 94);
            this.lblFormatInfo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Format";
            // 
            // cmbFormat
            // 
            this.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Location = new System.Drawing.Point(20, 213);
            this.cmbFormat.Margin = new System.Windows.Forms.Padding(6);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(586, 33);
            this.cmbFormat.TabIndex = 9;
            this.cmbFormat.SelectedIndexChanged += new System.EventHandler(this.cmbFormat_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(555, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Exportfile extension (fileextension to monitor in directory)";
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(20, 144);
            this.txtExtension.Margin = new System.Windows.Forms.Padding(6);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(220, 31);
            this.txtExtension.TabIndex = 7;
            this.txtExtension.Text = "*.xml";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(548, 67);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOEDirectory
            // 
            this.txtOEDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOEDirectory.Location = new System.Drawing.Point(20, 69);
            this.txtOEDirectory.Margin = new System.Windows.Forms.Padding(6);
            this.txtOEDirectory.Name = "txtOEDirectory";
            this.txtOEDirectory.Size = new System.Drawing.Size(512, 31);
            this.txtOEDirectory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exportdirectory";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(24, 452);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1148, 354);
            this.listBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 377);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "Start upload";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(658, 62);
            this.listBox2.Margin = new System.Windows.Forms.Padding(6);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(498, 129);
            this.listBox2.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 371);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "CompetitionID";
            // 
            // txtCompID
            // 
            this.txtCompID.Location = new System.Drawing.Point(24, 402);
            this.txtCompID.Margin = new System.Windows.Forms.Padding(6);
            this.txtCompID.Name = "txtCompID";
            this.txtCompID.Size = new System.Drawing.Size(144, 31);
            this.txtCompID.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(512, 377);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 60);
            this.button3.TabIndex = 6;
            this.button3.Text = "Stop upload";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fsWatcherOS
            // 
            this.fsWatcherOS.EnableRaisingEvents = true;
            this.fsWatcherOS.Filter = "*.csv.emma";
            this.fsWatcherOS.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.fsWatcherOS.SynchronizingObject = this;
            this.fsWatcherOS.Changed += new System.IO.FileSystemEventHandler(this.fsWatcherOS_Changed);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(658, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Servers";
            // 
            // chkUploadStarttimes
            // 
            this.chkUploadStarttimes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkUploadStarttimes.AutoSize = true;
            this.chkUploadStarttimes.Checked = true;
            this.chkUploadStarttimes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUploadStarttimes.Location = new System.Drawing.Point(667, 206);
            this.chkUploadStarttimes.Margin = new System.Windows.Forms.Padding(6);
            this.chkUploadStarttimes.Name = "chkUploadStarttimes";
            this.chkUploadStarttimes.Size = new System.Drawing.Size(211, 29);
            this.chkUploadStarttimes.TabIndex = 10;
            this.chkUploadStarttimes.Text = "Upload starttimes";
            this.chkUploadStarttimes.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(776, 377);
            this.button4.Margin = new System.Windows.Forms.Padding(6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(384, 63);
            this.button4.TabIndex = 11;
            this.button4.Text = "Copy log to clipboard";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // chkAutoCreateRadioControls
            // 
            this.chkAutoCreateRadioControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAutoCreateRadioControls.AutoSize = true;
            this.chkAutoCreateRadioControls.Checked = true;
            this.chkAutoCreateRadioControls.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoCreateRadioControls.Location = new System.Drawing.Point(664, 250);
            this.chkAutoCreateRadioControls.Margin = new System.Windows.Forms.Padding(6);
            this.chkAutoCreateRadioControls.Name = "chkAutoCreateRadioControls";
            this.chkAutoCreateRadioControls.Size = new System.Drawing.Size(368, 29);
            this.chkAutoCreateRadioControls.TabIndex = 12;
            this.chkAutoCreateRadioControls.Text = "Automatically create radiocontrols";
            this.chkAutoCreateRadioControls.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 371);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "AgregateID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 403);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 31);
            this.textBox1.TabIndex = 14;
            // 
            // OEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 854);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkAutoCreateRadioControls);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.chkUploadStarttimes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtCompID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "OEForm";
            this.Text = "LiveResults Client, UploadClient (powered by O-Results)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OEForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsWatcherOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOEDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtCompID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.IO.FileSystemWatcher fsWatcherOS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkUploadStarttimes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.Label lblFormatInfo;
        private System.Windows.Forms.TextBox txtZeroTime;
        private System.Windows.Forms.Label lblZeroTime;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox chkAutoCreateRadioControls;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}
