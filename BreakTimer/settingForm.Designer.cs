namespace BreakTimer
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.hTimerTextBox = new System.Windows.Forms.TextBox();
            this.mTimerTextbox = new System.Windows.Forms.TextBox();
            this.sTimerTextBox = new System.Windows.Forms.TextBox();
            this.hours_label = new System.Windows.Forms.Label();
            this.minutes_label = new System.Windows.Forms.Label();
            this.seconds_label = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sBreakTextBox = new System.Windows.Forms.TextBox();
            this.hBreakTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mBreakTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.startupCheck = new System.Windows.Forms.CheckBox();
            this.isForcedBreak = new System.Windows.Forms.CheckBox();
            this.isPlaySound = new System.Windows.Forms.CheckBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // hTimerTextBox
            // 
            this.hTimerTextBox.Location = new System.Drawing.Point(11, 37);
            this.hTimerTextBox.Name = "hTimerTextBox";
            this.hTimerTextBox.Size = new System.Drawing.Size(53, 20);
            this.hTimerTextBox.TabIndex = 0;
            // 
            // mTimerTextbox
            // 
            this.mTimerTextbox.Location = new System.Drawing.Point(70, 37);
            this.mTimerTextbox.Name = "mTimerTextbox";
            this.mTimerTextbox.Size = new System.Drawing.Size(53, 20);
            this.mTimerTextbox.TabIndex = 1;
            // 
            // sTimerTextBox
            // 
            this.sTimerTextBox.Location = new System.Drawing.Point(129, 37);
            this.sTimerTextBox.Name = "sTimerTextBox";
            this.sTimerTextBox.Size = new System.Drawing.Size(53, 20);
            this.sTimerTextBox.TabIndex = 2;
            // 
            // hours_label
            // 
            this.hours_label.AutoSize = true;
            this.hours_label.Location = new System.Drawing.Point(8, 21);
            this.hours_label.Name = "hours_label";
            this.hours_label.Size = new System.Drawing.Size(35, 13);
            this.hours_label.TabIndex = 1;
            this.hours_label.Text = "Hours";
            // 
            // minutes_label
            // 
            this.minutes_label.AutoSize = true;
            this.minutes_label.Location = new System.Drawing.Point(67, 21);
            this.minutes_label.Name = "minutes_label";
            this.minutes_label.Size = new System.Drawing.Size(44, 13);
            this.minutes_label.TabIndex = 1;
            this.minutes_label.Text = "Minutes";
            // 
            // seconds_label
            // 
            this.seconds_label.AutoSize = true;
            this.seconds_label.Location = new System.Drawing.Point(126, 21);
            this.seconds_label.Name = "seconds_label";
            this.seconds_label.Size = new System.Drawing.Size(47, 13);
            this.seconds_label.TabIndex = 1;
            this.seconds_label.Text = "Seconds";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(66, 279);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sTimerTextBox);
            this.groupBox1.Controls.Add(this.hTimerTextBox);
            this.groupBox1.Controls.Add(this.mTimerTextbox);
            this.groupBox1.Controls.Add(this.seconds_label);
            this.groupBox1.Controls.Add(this.hours_label);
            this.groupBox1.Controls.Add(this.minutes_label);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 76);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Timer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sBreakTextBox);
            this.groupBox2.Controls.Add(this.hBreakTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.mBreakTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 75);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Break Timer";
            // 
            // sBreakTextBox
            // 
            this.sBreakTextBox.Location = new System.Drawing.Point(135, 37);
            this.sBreakTextBox.Name = "sBreakTextBox";
            this.sBreakTextBox.Size = new System.Drawing.Size(53, 20);
            this.sBreakTextBox.TabIndex = 2;
            // 
            // hBreakTextBox
            // 
            this.hBreakTextBox.Location = new System.Drawing.Point(17, 37);
            this.hBreakTextBox.Name = "hBreakTextBox";
            this.hBreakTextBox.Size = new System.Drawing.Size(53, 20);
            this.hBreakTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minutes";
            // 
            // mBreakTextBox
            // 
            this.mBreakTextBox.Location = new System.Drawing.Point(76, 37);
            this.mBreakTextBox.Name = "mBreakTextBox";
            this.mBreakTextBox.Size = new System.Drawing.Size(53, 20);
            this.mBreakTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Seconds";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.startupCheck);
            this.groupBox3.Controls.Add(this.isForcedBreak);
            this.groupBox3.Controls.Add(this.isPlaySound);
            this.groupBox3.Location = new System.Drawing.Point(13, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 97);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Break / Alert";
            // 
            // startupCheck
            // 
            this.startupCheck.AutoSize = true;
            this.startupCheck.Location = new System.Drawing.Point(9, 65);
            this.startupCheck.Name = "startupCheck";
            this.startupCheck.Size = new System.Drawing.Size(116, 17);
            this.startupCheck.TabIndex = 1;
            this.startupCheck.Text = "Launch On Startup";
            this.startupCheck.UseVisualStyleBackColor = true;
            // 
            // isForcedBreak
            // 
            this.isForcedBreak.AutoSize = true;
            this.isForcedBreak.Checked = true;
            this.isForcedBreak.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isForcedBreak.Location = new System.Drawing.Point(9, 42);
            this.isForcedBreak.Name = "isForcedBreak";
            this.isForcedBreak.Size = new System.Drawing.Size(116, 17);
            this.isForcedBreak.TabIndex = 0;
            this.isForcedBreak.Text = "Unbreakable Break";
            this.isForcedBreak.UseVisualStyleBackColor = true;
            // 
            // isPlaySound
            // 
            this.isPlaySound.AutoSize = true;
            this.isPlaySound.Checked = true;
            this.isPlaySound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isPlaySound.Location = new System.Drawing.Point(9, 19);
            this.isPlaySound.Name = "isPlaySound";
            this.isPlaySound.Size = new System.Drawing.Size(79, 17);
            this.isPlaySound.TabIndex = 0;
            this.isPlaySound.Text = "Play Sound";
            this.isPlaySound.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(145, 279);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // SettingForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(232, 310);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox hTimerTextBox;
        private System.Windows.Forms.TextBox mTimerTextbox;
        private System.Windows.Forms.TextBox sTimerTextBox;
        private System.Windows.Forms.Label hours_label;
        private System.Windows.Forms.Label minutes_label;
        private System.Windows.Forms.Label seconds_label;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox sBreakTextBox;
        private System.Windows.Forms.TextBox hBreakTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mBreakTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox isForcedBreak;
        private System.Windows.Forms.CheckBox isPlaySound;
        private System.Windows.Forms.CheckBox startupCheck;
        private System.Windows.Forms.Button cancelBtn;
    }
}