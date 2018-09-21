namespace DayZServerTool
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.closeBtn = new FlatUI.FlatClose();
            this.minBtn = new FlatUI.FlatMini();
            this.exePath = new FlatUI.FlatTextBox();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.changeExeBtn = new FlatUI.FlatButton();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.serverCFG = new FlatUI.FlatTextBox();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.serverPort = new FlatUI.FlatTextBox();
            this.flatLabel4 = new FlatUI.FlatLabel();
            this.flatLabel5 = new FlatUI.FlatLabel();
            this.cpuCount = new FlatUI.FlatTextBox();
            this.flatLabel6 = new FlatUI.FlatLabel();
            this.bePath = new FlatUI.FlatTextBox();
            this.dologs = new FlatUI.FlatCheckBox();
            this.adminlog = new FlatUI.FlatCheckBox();
            this.freezecheck = new FlatUI.FlatCheckBox();
            this.netlog = new FlatUI.FlatCheckBox();
            this.noFilePatching = new FlatUI.FlatCheckBox();
            this.latestLog = new FlatUI.FlatButton();
            this.formSkin1 = new FlatUI.FormSkin();
            this.saveSettings = new FlatUI.FlatButton();
            this.startServer = new FlatUI.FlatButton();
            this.openLogsFolder = new FlatUI.FlatButton();
            this.modInput = new FlatUI.FlatTextBox();
            this.flatLabel7 = new FlatUI.FlatLabel();
            this.formSkin1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.closeBtn.Font = new System.Drawing.Font("Marlett", 10F);
            this.closeBtn.Location = new System.Drawing.Point(570, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(18, 18);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "flatClose1";
            this.closeBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // minBtn
            // 
            this.minBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minBtn.BackColor = System.Drawing.Color.White;
            this.minBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.minBtn.Font = new System.Drawing.Font("Marlett", 12F);
            this.minBtn.Location = new System.Drawing.Point(546, 12);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(18, 18);
            this.minBtn.TabIndex = 1;
            this.minBtn.Text = "flatMini1";
            this.minBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // exePath
            // 
            this.exePath.BackColor = System.Drawing.Color.Transparent;
            this.exePath.FocusOnHover = false;
            this.exePath.Location = new System.Drawing.Point(12, 77);
            this.exePath.MaxLength = 32767;
            this.exePath.Multiline = false;
            this.exePath.Name = "exePath";
            this.exePath.ReadOnly = true;
            this.exePath.Size = new System.Drawing.Size(456, 29);
            this.exePath.TabIndex = 3;
            this.exePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.exePath.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exePath.UseSystemPasswordChar = false;
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(12, 61);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(64, 13);
            this.flatLabel1.TabIndex = 4;
            this.flatLabel1.Text = "Path To Exe";
            // 
            // changeExeBtn
            // 
            this.changeExeBtn.BackColor = System.Drawing.Color.Transparent;
            this.changeExeBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(105)))), ((int)(((byte)(146)))));
            this.changeExeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeExeBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.changeExeBtn.Location = new System.Drawing.Point(474, 77);
            this.changeExeBtn.Name = "changeExeBtn";
            this.changeExeBtn.Rounded = false;
            this.changeExeBtn.Size = new System.Drawing.Size(114, 29);
            this.changeExeBtn.TabIndex = 5;
            this.changeExeBtn.Text = "Edit";
            this.changeExeBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.changeExeBtn.Click += new System.EventHandler(this.changeExeBtn_Click);
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(9, 120);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(95, 13);
            this.flatLabel2.TabIndex = 6;
            this.flatLabel2.Text = "Config File Name";
            // 
            // serverCFG
            // 
            this.serverCFG.BackColor = System.Drawing.Color.Transparent;
            this.serverCFG.FocusOnHover = false;
            this.serverCFG.Location = new System.Drawing.Point(12, 136);
            this.serverCFG.MaxLength = 32767;
            this.serverCFG.Multiline = false;
            this.serverCFG.Name = "serverCFG";
            this.serverCFG.ReadOnly = false;
            this.serverCFG.Size = new System.Drawing.Size(180, 29);
            this.serverCFG.TabIndex = 7;
            this.serverCFG.Text = "serverDZ.cfg";
            this.serverCFG.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.serverCFG.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.serverCFG.UseSystemPasswordChar = false;
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(206, 120);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(62, 13);
            this.flatLabel3.TabIndex = 8;
            this.flatLabel3.Text = "Server Port";
            // 
            // serverPort
            // 
            this.serverPort.BackColor = System.Drawing.Color.Transparent;
            this.serverPort.FocusOnHover = false;
            this.serverPort.Location = new System.Drawing.Point(209, 136);
            this.serverPort.MaxLength = 32767;
            this.serverPort.Multiline = false;
            this.serverPort.Name = "serverPort";
            this.serverPort.ReadOnly = false;
            this.serverPort.Size = new System.Drawing.Size(180, 29);
            this.serverPort.TabIndex = 9;
            this.serverPort.Text = "2302";
            this.serverPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.serverPort.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.serverPort.UseSystemPasswordChar = false;
            // 
            // flatLabel4
            // 
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(6, 304);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(43, 13);
            this.flatLabel4.TabIndex = 13;
            this.flatLabel4.Text = "Params";
            // 
            // flatLabel5
            // 
            this.flatLabel5.AutoSize = true;
            this.flatLabel5.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel5.ForeColor = System.Drawing.Color.White;
            this.flatLabel5.Location = new System.Drawing.Point(405, 120);
            this.flatLabel5.Name = "flatLabel5";
            this.flatLabel5.Size = new System.Drawing.Size(63, 13);
            this.flatLabel5.TabIndex = 18;
            this.flatLabel5.Text = "Cpu Count";
            // 
            // cpuCount
            // 
            this.cpuCount.BackColor = System.Drawing.Color.Transparent;
            this.cpuCount.FocusOnHover = false;
            this.cpuCount.Location = new System.Drawing.Point(408, 136);
            this.cpuCount.MaxLength = 32767;
            this.cpuCount.Multiline = false;
            this.cpuCount.Name = "cpuCount";
            this.cpuCount.ReadOnly = false;
            this.cpuCount.Size = new System.Drawing.Size(180, 29);
            this.cpuCount.TabIndex = 19;
            this.cpuCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cpuCount.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cpuCount.UseSystemPasswordChar = false;
            // 
            // flatLabel6
            // 
            this.flatLabel6.AutoSize = true;
            this.flatLabel6.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel6.ForeColor = System.Drawing.Color.White;
            this.flatLabel6.Location = new System.Drawing.Point(9, 177);
            this.flatLabel6.Name = "flatLabel6";
            this.flatLabel6.Size = new System.Drawing.Size(46, 13);
            this.flatLabel6.TabIndex = 20;
            this.flatLabel6.Text = "Be Path";
            // 
            // bePath
            // 
            this.bePath.BackColor = System.Drawing.Color.Transparent;
            this.bePath.FocusOnHover = false;
            this.bePath.Location = new System.Drawing.Point(9, 193);
            this.bePath.MaxLength = 32767;
            this.bePath.Multiline = false;
            this.bePath.Name = "bePath";
            this.bePath.ReadOnly = false;
            this.bePath.Size = new System.Drawing.Size(579, 29);
            this.bePath.TabIndex = 21;
            this.bePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bePath.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bePath.UseSystemPasswordChar = false;
            // 
            // dologs
            // 
            this.dologs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.dologs.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.dologs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(105)))), ((int)(((byte)(146)))));
            this.dologs.Checked = false;
            this.dologs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dologs.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dologs.Location = new System.Drawing.Point(9, 320);
            this.dologs.Name = "dologs";
            this.dologs.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.dologs.Size = new System.Drawing.Size(150, 22);
            this.dologs.TabIndex = 24;
            this.dologs.Text = "-dologs";
            // 
            // adminlog
            // 
            this.adminlog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.adminlog.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.adminlog.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(105)))), ((int)(((byte)(146)))));
            this.adminlog.Checked = false;
            this.adminlog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminlog.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.adminlog.Location = new System.Drawing.Point(194, 320);
            this.adminlog.Name = "adminlog";
            this.adminlog.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.adminlog.Size = new System.Drawing.Size(151, 22);
            this.adminlog.TabIndex = 25;
            this.adminlog.Text = "-adminlog";
            // 
            // freezecheck
            // 
            this.freezecheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.freezecheck.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.freezecheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(105)))), ((int)(((byte)(146)))));
            this.freezecheck.Checked = false;
            this.freezecheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.freezecheck.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.freezecheck.Location = new System.Drawing.Point(9, 348);
            this.freezecheck.Name = "freezecheck";
            this.freezecheck.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.freezecheck.Size = new System.Drawing.Size(150, 22);
            this.freezecheck.TabIndex = 26;
            this.freezecheck.Text = "-freezecheck";
            // 
            // netlog
            // 
            this.netlog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.netlog.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.netlog.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(105)))), ((int)(((byte)(146)))));
            this.netlog.Checked = false;
            this.netlog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.netlog.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.netlog.Location = new System.Drawing.Point(365, 320);
            this.netlog.Name = "netlog";
            this.netlog.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.netlog.Size = new System.Drawing.Size(151, 22);
            this.netlog.TabIndex = 27;
            this.netlog.Text = "-netlog";
            // 
            // noFilePatching
            // 
            this.noFilePatching.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.noFilePatching.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.noFilePatching.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(105)))), ((int)(((byte)(146)))));
            this.noFilePatching.Checked = false;
            this.noFilePatching.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noFilePatching.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.noFilePatching.Location = new System.Drawing.Point(194, 348);
            this.noFilePatching.Name = "noFilePatching";
            this.noFilePatching.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.noFilePatching.Size = new System.Drawing.Size(150, 22);
            this.noFilePatching.TabIndex = 28;
            this.noFilePatching.Text = "-noFilePatching";
            // 
            // latestLog
            // 
            this.latestLog.BackColor = System.Drawing.Color.Transparent;
            this.latestLog.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(105)))), ((int)(((byte)(146)))));
            this.latestLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.latestLog.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.latestLog.Location = new System.Drawing.Point(299, 398);
            this.latestLog.Name = "latestLog";
            this.latestLog.Rounded = false;
            this.latestLog.Size = new System.Drawing.Size(289, 32);
            this.latestLog.TabIndex = 30;
            this.latestLog.Text = "Open Latest RPT";
            this.latestLog.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.latestLog.Click += new System.EventHandler(this.latestLog_Click);
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.modInput);
            this.formSkin1.Controls.Add(this.flatLabel7);
            this.formSkin1.Controls.Add(this.saveSettings);
            this.formSkin1.Controls.Add(this.startServer);
            this.formSkin1.Controls.Add(this.latestLog);
            this.formSkin1.Controls.Add(this.openLogsFolder);
            this.formSkin1.Controls.Add(this.noFilePatching);
            this.formSkin1.Controls.Add(this.netlog);
            this.formSkin1.Controls.Add(this.freezecheck);
            this.formSkin1.Controls.Add(this.adminlog);
            this.formSkin1.Controls.Add(this.dologs);
            this.formSkin1.Controls.Add(this.bePath);
            this.formSkin1.Controls.Add(this.flatLabel6);
            this.formSkin1.Controls.Add(this.cpuCount);
            this.formSkin1.Controls.Add(this.flatLabel5);
            this.formSkin1.Controls.Add(this.flatLabel4);
            this.formSkin1.Controls.Add(this.serverPort);
            this.formSkin1.Controls.Add(this.flatLabel3);
            this.formSkin1.Controls.Add(this.serverCFG);
            this.formSkin1.Controls.Add(this.flatLabel2);
            this.formSkin1.Controls.Add(this.changeExeBtn);
            this.formSkin1.Controls.Add(this.flatLabel1);
            this.formSkin1.Controls.Add(this.exePath);
            this.formSkin1.Controls.Add(this.minBtn);
            this.formSkin1.Controls.Add(this.closeBtn);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(105)))), ((int)(((byte)(146)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(600, 480);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "DayZ Server Tool";
            // 
            // saveSettings
            // 
            this.saveSettings.BackColor = System.Drawing.Color.Transparent;
            this.saveSettings.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(105)))), ((int)(((byte)(146)))));
            this.saveSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveSettings.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.saveSettings.Location = new System.Drawing.Point(9, 436);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Rounded = false;
            this.saveSettings.Size = new System.Drawing.Size(284, 32);
            this.saveSettings.TabIndex = 32;
            this.saveSettings.Text = "Save Settings";
            this.saveSettings.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.saveSettings.Click += new System.EventHandler(this.saveSettings_Click);
            // 
            // startServer
            // 
            this.startServer.BackColor = System.Drawing.Color.Transparent;
            this.startServer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(105)))), ((int)(((byte)(146)))));
            this.startServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startServer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.startServer.Location = new System.Drawing.Point(299, 436);
            this.startServer.Name = "startServer";
            this.startServer.Rounded = false;
            this.startServer.Size = new System.Drawing.Size(289, 32);
            this.startServer.TabIndex = 31;
            this.startServer.Text = "Start Server";
            this.startServer.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.startServer.Click += new System.EventHandler(this.startServer_Click);
            // 
            // openLogsFolder
            // 
            this.openLogsFolder.BackColor = System.Drawing.Color.Transparent;
            this.openLogsFolder.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(105)))), ((int)(((byte)(146)))));
            this.openLogsFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openLogsFolder.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.openLogsFolder.Location = new System.Drawing.Point(9, 398);
            this.openLogsFolder.Name = "openLogsFolder";
            this.openLogsFolder.Rounded = false;
            this.openLogsFolder.Size = new System.Drawing.Size(284, 32);
            this.openLogsFolder.TabIndex = 29;
            this.openLogsFolder.Text = "Open Log Folder";
            this.openLogsFolder.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.openLogsFolder.Click += new System.EventHandler(this.openLogsFolder_Click);
            // 
            // modInput
            // 
            this.modInput.BackColor = System.Drawing.Color.Transparent;
            this.modInput.FocusOnHover = false;
            this.modInput.Location = new System.Drawing.Point(9, 254);
            this.modInput.MaxLength = 32767;
            this.modInput.Multiline = false;
            this.modInput.Name = "modInput";
            this.modInput.ReadOnly = false;
            this.modInput.Size = new System.Drawing.Size(579, 29);
            this.modInput.TabIndex = 34;
            this.modInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.modInput.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.modInput.UseSystemPasswordChar = false;
            // 
            // flatLabel7
            // 
            this.flatLabel7.AutoSize = true;
            this.flatLabel7.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel7.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel7.ForeColor = System.Drawing.Color.White;
            this.flatLabel7.Location = new System.Drawing.Point(9, 238);
            this.flatLabel7.Name = "flatLabel7";
            this.flatLabel7.Size = new System.Drawing.Size(31, 13);
            this.flatLabel7.TabIndex = 33;
            this.flatLabel7.Text = "Mod";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FlatClose closeBtn;
        private FlatUI.FlatMini minBtn;
        private FlatUI.FlatTextBox exePath;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatButton changeExeBtn;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatTextBox serverCFG;
        private FlatUI.FlatLabel flatLabel3;
        private FlatUI.FlatTextBox serverPort;
        private FlatUI.FlatLabel flatLabel4;
        private FlatUI.FlatLabel flatLabel5;
        private FlatUI.FlatTextBox cpuCount;
        private FlatUI.FlatLabel flatLabel6;
        private FlatUI.FlatTextBox bePath;
        private FlatUI.FlatCheckBox dologs;
        private FlatUI.FlatCheckBox adminlog;
        private FlatUI.FlatCheckBox freezecheck;
        private FlatUI.FlatCheckBox netlog;
        private FlatUI.FlatCheckBox noFilePatching;
        private FlatUI.FlatButton latestLog;
        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatButton openLogsFolder;
        private FlatUI.FlatButton startServer;
        private FlatUI.FlatButton saveSettings;
        private FlatUI.FlatTextBox modInput;
        private FlatUI.FlatLabel flatLabel7;
    }
}

