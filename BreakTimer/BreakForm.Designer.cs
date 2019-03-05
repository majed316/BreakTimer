namespace BreakTimer
{
    partial class BreakForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BreakForm));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.hours_label = new System.Windows.Forms.Label();
            this.hours_seperator = new System.Windows.Forms.Label();
            this.minutes_label = new System.Windows.Forms.Label();
            this.minutes_seperator = new System.Windows.Forms.Label();
            this.seconds_label = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.hours_label);
            this.flowLayoutPanel2.Controls.Add(this.hours_seperator);
            this.flowLayoutPanel2.Controls.Add(this.minutes_label);
            this.flowLayoutPanel2.Controls.Add(this.minutes_seperator);
            this.flowLayoutPanel2.Controls.Add(this.seconds_label);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(37, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(352, 56);
            this.flowLayoutPanel2.TabIndex = 6;
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
            // hours_seperator
            // 
            this.hours_seperator.AutoSize = true;
            this.hours_seperator.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_seperator.Location = new System.Drawing.Point(82, 0);
            this.hours_seperator.Margin = new System.Windows.Forms.Padding(0);
            this.hours_seperator.Name = "hours_seperator";
            this.hours_seperator.Size = new System.Drawing.Size(50, 56);
            this.hours_seperator.TabIndex = 0;
            this.hours_seperator.Text = ":";
            // 
            // minutes_label
            // 
            this.minutes_label.AutoSize = true;
            this.minutes_label.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes_label.Location = new System.Drawing.Point(135, 0);
            this.minutes_label.Name = "minutes_label";
            this.minutes_label.Size = new System.Drawing.Size(76, 56);
            this.minutes_label.TabIndex = 4;
            this.minutes_label.Text = "00";
            // 
            // minutes_seperator
            // 
            this.minutes_seperator.AutoSize = true;
            this.minutes_seperator.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes_seperator.Location = new System.Drawing.Point(217, 0);
            this.minutes_seperator.Name = "minutes_seperator";
            this.minutes_seperator.Size = new System.Drawing.Size(50, 56);
            this.minutes_seperator.TabIndex = 2;
            this.minutes_seperator.Text = ":";
            // 
            // seconds_label
            // 
            this.seconds_label.AutoSize = true;
            this.seconds_label.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds_label.Location = new System.Drawing.Point(273, 0);
            this.seconds_label.Name = "seconds_label";
            this.seconds_label.Size = new System.Drawing.Size(76, 56);
            this.seconds_label.TabIndex = 1;
            this.seconds_label.Text = "00";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // BreakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 105);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BreakForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Break";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BreakForm_FormClosing);
            this.Load += new System.EventHandler(this.BreakForm_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label hours_label;
        private System.Windows.Forms.Label seconds_label;
        private System.Windows.Forms.Label hours_seperator;
        private System.Windows.Forms.Label minutes_seperator;
        private System.Windows.Forms.Label minutes_label;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}