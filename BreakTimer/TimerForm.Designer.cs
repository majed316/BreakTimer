namespace BreakTimer
{
    partial class TimerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideWhenMinimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchMinimizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchOnStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutBreakTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tryMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showTheTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.takeBreakableBreakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeUnBreakableBreakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.startTheTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseTheTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopTheTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.preferencesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.seconds_label = new System.Windows.Forms.Label();
            this.minutes_seperator = new System.Windows.Forms.Label();
            this.minutes_label = new System.Windows.Forms.Label();
            this.hours_seperator = new System.Windows.Forms.Label();
            this.hours_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timerStartButton = new System.Windows.Forms.Button();
            this.timerPauseButton = new System.Windows.Forms.Button();
            this.timerStopButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip.SuspendLayout();
            this.tryMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(454, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideWhenMinimizeToolStripMenuItem,
            this.launchMinimizedToolStripMenuItem,
            this.launchOnStartupToolStripMenuItem,
            this.toolStripSeparator1,
            this.preferencesToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // hideWhenMinimizeToolStripMenuItem
            // 
            this.hideWhenMinimizeToolStripMenuItem.Name = "hideWhenMinimizeToolStripMenuItem";
            this.hideWhenMinimizeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.hideWhenMinimizeToolStripMenuItem.Text = "Hide When Minimized";
            this.hideWhenMinimizeToolStripMenuItem.Click += new System.EventHandler(this.hideWhenMinimizeToolStripMenuItem_Click);
            // 
            // launchMinimizedToolStripMenuItem
            // 
            this.launchMinimizedToolStripMenuItem.Name = "launchMinimizedToolStripMenuItem";
            this.launchMinimizedToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.launchMinimizedToolStripMenuItem.Text = "Launch Minimized";
            this.launchMinimizedToolStripMenuItem.Click += new System.EventHandler(this.launchMinimizedToolStripMenuItem_Click);
            // 
            // launchOnStartupToolStripMenuItem
            // 
            this.launchOnStartupToolStripMenuItem.Checked = true;
            this.launchOnStartupToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.launchOnStartupToolStripMenuItem.Name = "launchOnStartupToolStripMenuItem";
            this.launchOnStartupToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.launchOnStartupToolStripMenuItem.Text = "Launch On Startup";
            this.launchOnStartupToolStripMenuItem.Click += new System.EventHandler(this.launchOnStartupToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+P";
            this.preferencesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences...";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdateToolStripMenuItem,
            this.toolStripSeparator6,
            this.aboutBreakTimerToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutBreakTimerToolStripMenuItem
            // 
            this.aboutBreakTimerToolStripMenuItem.Name = "aboutBreakTimerToolStripMenuItem";
            this.aboutBreakTimerToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.aboutBreakTimerToolStripMenuItem.Text = "About Break Timer...";
            this.aboutBreakTimerToolStripMenuItem.Click += new System.EventHandler(this.aboutBreakTimerToolStripMenuItem_Click);
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.checkForUpdateToolStripMenuItem.Text = "Check For Update...";
            this.checkForUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdateToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.tryMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // tryMenuStrip
            // 
            this.tryMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTheTimerToolStripMenuItem,
            this.toolStripSeparator5,
            this.takeBreakableBreakToolStripMenuItem,
            this.takeUnBreakableBreakToolStripMenuItem,
            this.toolStripSeparator3,
            this.startTheTimerToolStripMenuItem,
            this.pauseTheTimerToolStripMenuItem,
            this.stopTheTimerToolStripMenuItem,
            this.toolStripSeparator4,
            this.preferencesToolStripMenuItem1,
            this.aboutToolStrip,
            this.exitToolStrip});
            this.tryMenuStrip.Name = "contextMenuStrip1";
            this.tryMenuStrip.Size = new System.Drawing.Size(201, 220);
            // 
            // showTheTimerToolStripMenuItem
            // 
            this.showTheTimerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTheTimerToolStripMenuItem.Name = "showTheTimerToolStripMenuItem";
            this.showTheTimerToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.showTheTimerToolStripMenuItem.Text = "Show/Hide Timer";
            this.showTheTimerToolStripMenuItem.Click += new System.EventHandler(this.showTheTimerToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(197, 6);
            // 
            // takeBreakableBreakToolStripMenuItem
            // 
            this.takeBreakableBreakToolStripMenuItem.Name = "takeBreakableBreakToolStripMenuItem";
            this.takeBreakableBreakToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.takeBreakableBreakToolStripMenuItem.Text = "Take Breakable Break";
            this.takeBreakableBreakToolStripMenuItem.Click += new System.EventHandler(this.takeBreakableBreakToolStripMenuItem_Click);
            // 
            // takeUnBreakableBreakToolStripMenuItem
            // 
            this.takeUnBreakableBreakToolStripMenuItem.Name = "takeUnBreakableBreakToolStripMenuItem";
            this.takeUnBreakableBreakToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.takeUnBreakableBreakToolStripMenuItem.Text = "Take UnBreakable Break";
            this.takeUnBreakableBreakToolStripMenuItem.Click += new System.EventHandler(this.takeUnBreakableBreakToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(197, 6);
            // 
            // startTheTimerToolStripMenuItem
            // 
            this.startTheTimerToolStripMenuItem.Name = "startTheTimerToolStripMenuItem";
            this.startTheTimerToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.startTheTimerToolStripMenuItem.Text = "Start Timer";
            this.startTheTimerToolStripMenuItem.Click += new System.EventHandler(this.startTheTimerToolStripMenuItem_Click);
            // 
            // pauseTheTimerToolStripMenuItem
            // 
            this.pauseTheTimerToolStripMenuItem.Name = "pauseTheTimerToolStripMenuItem";
            this.pauseTheTimerToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.pauseTheTimerToolStripMenuItem.Text = "Pause Timer";
            this.pauseTheTimerToolStripMenuItem.Click += new System.EventHandler(this.pauseTheTimerToolStripMenuItem_Click);
            // 
            // stopTheTimerToolStripMenuItem
            // 
            this.stopTheTimerToolStripMenuItem.Name = "stopTheTimerToolStripMenuItem";
            this.stopTheTimerToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.stopTheTimerToolStripMenuItem.Text = "Stop Timer";
            this.stopTheTimerToolStripMenuItem.Click += new System.EventHandler(this.stopTheTimerToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(197, 6);
            // 
            // preferencesToolStripMenuItem1
            // 
            this.preferencesToolStripMenuItem1.Name = "preferencesToolStripMenuItem1";
            this.preferencesToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.preferencesToolStripMenuItem1.Text = "Preferences...";
            this.preferencesToolStripMenuItem1.Click += new System.EventHandler(this.preferencesToolStripMenuItem1_Click);
            // 
            // aboutToolStrip
            // 
            this.aboutToolStrip.Name = "aboutToolStrip";
            this.aboutToolStrip.Size = new System.Drawing.Size(200, 22);
            this.aboutToolStrip.Text = "About...";
            this.aboutToolStrip.Click += new System.EventHandler(this.aboutToolStrip_Click);
            // 
            // exitToolStrip
            // 
            this.exitToolStrip.Name = "exitToolStrip";
            this.exitToolStrip.Size = new System.Drawing.Size(200, 22);
            this.exitToolStrip.Text = "Exit";
            this.exitToolStrip.Click += new System.EventHandler(this.exitToolStrip_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // seconds_label
            // 
            this.seconds_label.AutoSize = true;
            this.seconds_label.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds_label.Location = new System.Drawing.Point(279, 0);
            this.seconds_label.Name = "seconds_label";
            this.seconds_label.Size = new System.Drawing.Size(76, 56);
            this.seconds_label.TabIndex = 1;
            this.seconds_label.Text = "00";
            // 
            // minutes_seperator
            // 
            this.minutes_seperator.AutoSize = true;
            this.minutes_seperator.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes_seperator.Location = new System.Drawing.Point(223, 0);
            this.minutes_seperator.Name = "minutes_seperator";
            this.minutes_seperator.Size = new System.Drawing.Size(50, 56);
            this.minutes_seperator.TabIndex = 2;
            this.minutes_seperator.Text = ":";
            // 
            // minutes_label
            // 
            this.minutes_label.AutoSize = true;
            this.minutes_label.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes_label.Location = new System.Drawing.Point(141, 0);
            this.minutes_label.Name = "minutes_label";
            this.minutes_label.Size = new System.Drawing.Size(76, 56);
            this.minutes_label.TabIndex = 4;
            this.minutes_label.Text = "00";
            // 
            // hours_seperator
            // 
            this.hours_seperator.AutoSize = true;
            this.hours_seperator.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_seperator.Location = new System.Drawing.Point(85, 0);
            this.hours_seperator.Name = "hours_seperator";
            this.hours_seperator.Size = new System.Drawing.Size(50, 56);
            this.hours_seperator.TabIndex = 0;
            this.hours_seperator.Text = ":";
            // 
            // hours_label
            // 
            this.hours_label.AutoSize = true;
            this.hours_label.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_label.Location = new System.Drawing.Point(3, 0);
            this.hours_label.Name = "hours_label";
            this.hours_label.Size = new System.Drawing.Size(76, 56);
            this.hours_label.TabIndex = 3;
            this.hours_label.Text = "00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 93);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time Remaining";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.hours_label);
            this.flowLayoutPanel1.Controls.Add(this.hours_seperator);
            this.flowLayoutPanel1.Controls.Add(this.minutes_label);
            this.flowLayoutPanel1.Controls.Add(this.minutes_seperator);
            this.flowLayoutPanel1.Controls.Add(this.seconds_label);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(371, 66);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // timerStartButton
            // 
            this.timerStartButton.Location = new System.Drawing.Point(33, 19);
            this.timerStartButton.Name = "timerStartButton";
            this.timerStartButton.Size = new System.Drawing.Size(75, 23);
            this.timerStartButton.TabIndex = 3;
            this.timerStartButton.Text = "Start";
            this.timerStartButton.UseVisualStyleBackColor = true;
            this.timerStartButton.Click += new System.EventHandler(this.timerStartButton_Click);
            // 
            // timerPauseButton
            // 
            this.timerPauseButton.Enabled = false;
            this.timerPauseButton.Location = new System.Drawing.Point(171, 19);
            this.timerPauseButton.Name = "timerPauseButton";
            this.timerPauseButton.Size = new System.Drawing.Size(75, 23);
            this.timerPauseButton.TabIndex = 4;
            this.timerPauseButton.Text = "Pause";
            this.timerPauseButton.UseVisualStyleBackColor = true;
            this.timerPauseButton.Click += new System.EventHandler(this.timerPauseButton_Click);
            // 
            // timerStopButton
            // 
            this.timerStopButton.Enabled = false;
            this.timerStopButton.Location = new System.Drawing.Point(318, 19);
            this.timerStopButton.Name = "timerStopButton";
            this.timerStopButton.Size = new System.Drawing.Size(75, 23);
            this.timerStopButton.TabIndex = 5;
            this.timerStopButton.Text = "Stop";
            this.timerStopButton.UseVisualStyleBackColor = true;
            this.timerStopButton.Click += new System.EventHandler(this.timerStopButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.timerStartButton);
            this.groupBox2.Controls.Add(this.timerPauseButton);
            this.groupBox2.Controls.Add(this.timerStopButton);
            this.groupBox2.Location = new System.Drawing.Point(13, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 54);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(179, 6);
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 190);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "TimerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Break Timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimerForm_FormClosing);
            this.Load += new System.EventHandler(this.TimerForm_Load);
            this.SizeChanged += new System.EventHandler(this.TimerForm_SizeChanged);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tryMenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideWhenMinimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem launchMinimizedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem launchOnStartupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutBreakTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private System.Windows.Forms.Label hours_label;
        private System.Windows.Forms.Label hours_seperator;
        private System.Windows.Forms.Label minutes_label;
        private System.Windows.Forms.Label minutes_seperator;
        private System.Windows.Forms.Label seconds_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip tryMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStrip;
        private System.Windows.Forms.ToolStripMenuItem takeBreakableBreakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeUnBreakableBreakToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem startTheTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseTheTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopTheTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTheTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Button timerStartButton;
        private System.Windows.Forms.Button timerPauseButton;
        private System.Windows.Forms.Button timerStopButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}

