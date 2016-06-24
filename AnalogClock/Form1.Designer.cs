namespace AnalogClock {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.xClock1 = new Clock.xClock();
            ((System.ComponentModel.ISupportInitialize)(this.xClock1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.Transparent;
            this.txtTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTime.Font = new System.Drawing.Font("Stencil Std", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.White;
            this.txtTime.Location = new System.Drawing.Point(0, 315);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(324, 78);
            this.txtTime.TabIndex = 1;
            this.txtTime.Text = "00:00:00 AM";
            this.txtTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // xClock1
            // 
            this.xClock1.BackColor = System.Drawing.Color.Transparent;
            this.xClock1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xClock1.ClockSize = 300;
            this.xClock1.GradEnd = System.Drawing.Color.Gray;
            this.xClock1.GradStart = System.Drawing.Color.Black;
            this.xClock1.HandColor = System.Drawing.Color.White;
            this.xClock1.Image = ((System.Drawing.Image)(resources.GetObject("xClock1.Image")));
            this.xClock1.InnerBorderColor = System.Drawing.Color.Black;
            this.xClock1.Location = new System.Drawing.Point(12, 12);
            this.xClock1.MajorHashColor = System.Drawing.Color.Red;
            this.xClock1.MinorHashColor = System.Drawing.Color.Black;
            this.xClock1.Name = "xClock1";
            this.xClock1.NumbersColor = System.Drawing.Color.White;
            this.xClock1.SecondHandColor = System.Drawing.Color.Purple;
            this.xClock1.ShowMajorHash = true;
            this.xClock1.ShowMinorHash = true;
            this.xClock1.ShowNumbers = true;
            this.xClock1.ShowSecondHand = true;
            this.xClock1.Size = new System.Drawing.Size(302, 302);
            this.xClock1.TabIndex = 2;
            this.xClock1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(324, 393);
            this.Controls.Add(this.xClock1);
            this.Controls.Add(this.txtTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Clock Demo";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.xClock1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.Timer timer1;
        private Clock.xClock xClock1;
    }
}