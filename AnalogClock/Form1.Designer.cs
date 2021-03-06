﻿namespace AnalogClock {
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
            this.xClock7 = new Clock.xClock();
            this.xClock6 = new Clock.xClock();
            this.xClock5 = new Clock.xClock();
            this.xClock4 = new Clock.xClock();
            this.xClock3 = new Clock.xClock();
            this.xClock2 = new Clock.xClock();
            this.xClock1 = new Clock.xClock();
            ((System.ComponentModel.ISupportInitialize)(this.xClock7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xClock6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xClock5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xClock4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xClock3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xClock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xClock1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTime.Font = new System.Drawing.Font("Stencil Std", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.White;
            this.txtTime.Location = new System.Drawing.Point(0, 328);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(793, 60);
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
            // xClock7
            // 
            this.xClock7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.xClock7.ClockSize = 150;
            this.xClock7.CustomHour = 0;
            this.xClock7.CustomMinute = 0;
            this.xClock7.CustomSecond = 0;
            this.xClock7.GradEnd = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.xClock7.GradStart = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.xClock7.HandColor = System.Drawing.Color.White;
            this.xClock7.Image = ((System.Drawing.Image)(resources.GetObject("xClock7.Image")));
            this.xClock7.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.xClock7.isCustomTime = false;
            this.xClock7.Location = new System.Drawing.Point(630, 162);
            this.xClock7.MajorHashColor = System.Drawing.Color.Red;
            this.xClock7.MinorHashColor = System.Drawing.Color.Black;
            this.xClock7.Name = "xClock7";
            this.xClock7.NumberFont = new System.Drawing.Font("Arial", 10F);
            this.xClock7.NumbersColor = System.Drawing.Color.White;
            this.xClock7.SecondHandColor = System.Drawing.Color.Red;
            this.xClock7.ShowMajorHash = false;
            this.xClock7.ShowMinorHash = false;
            this.xClock7.ShowNumbers = true;
            this.xClock7.ShowSecondHand = true;
            this.xClock7.Size = new System.Drawing.Size(150, 150);
            this.xClock7.TabIndex = 8;
            this.xClock7.TabStop = false;
            this.xClock7.TimeZone = 0;
            // 
            // xClock6
            // 
            this.xClock6.BorderColor = System.Drawing.Color.Transparent;
            this.xClock6.ClockSize = 150;
            this.xClock6.CustomHour = 0;
            this.xClock6.CustomMinute = 0;
            this.xClock6.CustomSecond = 0;
            this.xClock6.GradEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.xClock6.GradStart = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.xClock6.HandColor = System.Drawing.Color.White;
            this.xClock6.Image = ((System.Drawing.Image)(resources.GetObject("xClock6.Image")));
            this.xClock6.InnerBorderColor = System.Drawing.Color.RosyBrown;
            this.xClock6.isCustomTime = false;
            this.xClock6.Location = new System.Drawing.Point(318, 12);
            this.xClock6.MajorHashColor = System.Drawing.Color.Red;
            this.xClock6.MinorHashColor = System.Drawing.Color.Black;
            this.xClock6.Name = "xClock6";
            this.xClock6.NumberFont = new System.Drawing.Font("Arial", 10F);
            this.xClock6.NumbersColor = System.Drawing.Color.White;
            this.xClock6.SecondHandColor = System.Drawing.Color.Red;
            this.xClock6.ShowMajorHash = false;
            this.xClock6.ShowMinorHash = false;
            this.xClock6.ShowNumbers = false;
            this.xClock6.ShowSecondHand = true;
            this.xClock6.Size = new System.Drawing.Size(150, 150);
            this.xClock6.TabIndex = 7;
            this.xClock6.TabStop = false;
            this.xClock6.TimeZone = 8;
            // 
            // xClock5
            // 
            this.xClock5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.xClock5.ClockSize = 150;
            this.xClock5.CustomHour = 0;
            this.xClock5.CustomMinute = 0;
            this.xClock5.CustomSecond = 0;
            this.xClock5.GradEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.xClock5.GradStart = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.xClock5.HandColor = System.Drawing.Color.White;
            this.xClock5.Image = ((System.Drawing.Image)(resources.GetObject("xClock5.Image")));
            this.xClock5.InnerBorderColor = System.Drawing.Color.Firebrick;
            this.xClock5.isCustomTime = false;
            this.xClock5.Location = new System.Drawing.Point(318, 162);
            this.xClock5.MajorHashColor = System.Drawing.Color.Red;
            this.xClock5.MinorHashColor = System.Drawing.Color.Black;
            this.xClock5.Name = "xClock5";
            this.xClock5.NumberFont = new System.Drawing.Font("Arial", 10F);
            this.xClock5.NumbersColor = System.Drawing.Color.White;
            this.xClock5.SecondHandColor = System.Drawing.Color.Green;
            this.xClock5.ShowMajorHash = false;
            this.xClock5.ShowMinorHash = false;
            this.xClock5.ShowNumbers = false;
            this.xClock5.ShowSecondHand = true;
            this.xClock5.Size = new System.Drawing.Size(150, 150);
            this.xClock5.TabIndex = 6;
            this.xClock5.TabStop = false;
            this.xClock5.TimeZone = 0;
            // 
            // xClock4
            // 
            this.xClock4.BorderColor = System.Drawing.Color.Transparent;
            this.xClock4.ClockSize = 150;
            this.xClock4.CustomHour = 0;
            this.xClock4.CustomMinute = 0;
            this.xClock4.CustomSecond = 0;
            this.xClock4.GradEnd = System.Drawing.Color.LightSkyBlue;
            this.xClock4.GradStart = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.xClock4.HandColor = System.Drawing.Color.White;
            this.xClock4.Image = ((System.Drawing.Image)(resources.GetObject("xClock4.Image")));
            this.xClock4.InnerBorderColor = System.Drawing.Color.White;
            this.xClock4.isCustomTime = false;
            this.xClock4.Location = new System.Drawing.Point(630, 12);
            this.xClock4.MajorHashColor = System.Drawing.Color.Red;
            this.xClock4.MinorHashColor = System.Drawing.Color.Black;
            this.xClock4.Name = "xClock4";
            this.xClock4.NumberFont = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xClock4.NumbersColor = System.Drawing.Color.Black;
            this.xClock4.SecondHandColor = System.Drawing.Color.Red;
            this.xClock4.ShowMajorHash = false;
            this.xClock4.ShowMinorHash = false;
            this.xClock4.ShowNumbers = false;
            this.xClock4.ShowSecondHand = false;
            this.xClock4.Size = new System.Drawing.Size(150, 150);
            this.xClock4.TabIndex = 5;
            this.xClock4.TabStop = false;
            this.xClock4.TimeZone = 2;
            // 
            // xClock3
            // 
            this.xClock3.BorderColor = System.Drawing.Color.Black;
            this.xClock3.ClockSize = 150;
            this.xClock3.CustomHour = 12;
            this.xClock3.CustomMinute = 0;
            this.xClock3.CustomSecond = 0;
            this.xClock3.GradEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.xClock3.GradStart = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xClock3.HandColor = System.Drawing.Color.Black;
            this.xClock3.Image = ((System.Drawing.Image)(resources.GetObject("xClock3.Image")));
            this.xClock3.InnerBorderColor = System.Drawing.Color.White;
            this.xClock3.isCustomTime = true;
            this.xClock3.Location = new System.Drawing.Point(474, 162);
            this.xClock3.MajorHashColor = System.Drawing.Color.White;
            this.xClock3.MinorHashColor = System.Drawing.Color.Black;
            this.xClock3.Name = "xClock3";
            this.xClock3.NumberFont = new System.Drawing.Font("Arial", 10F);
            this.xClock3.NumbersColor = System.Drawing.Color.White;
            this.xClock3.SecondHandColor = System.Drawing.Color.Cyan;
            this.xClock3.ShowMajorHash = true;
            this.xClock3.ShowMinorHash = false;
            this.xClock3.ShowNumbers = false;
            this.xClock3.ShowSecondHand = true;
            this.xClock3.Size = new System.Drawing.Size(150, 150);
            this.xClock3.TabIndex = 4;
            this.xClock3.TabStop = false;
            this.xClock3.TimeZone = 3;
            // 
            // xClock2
            // 
            this.xClock2.BorderColor = System.Drawing.Color.Transparent;
            this.xClock2.ClockSize = 150;
            this.xClock2.CustomHour = 5;
            this.xClock2.CustomMinute = 45;
            this.xClock2.CustomSecond = 0;
            this.xClock2.GradEnd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.xClock2.GradStart = System.Drawing.Color.Blue;
            this.xClock2.HandColor = System.Drawing.Color.White;
            this.xClock2.Image = ((System.Drawing.Image)(resources.GetObject("xClock2.Image")));
            this.xClock2.InnerBorderColor = System.Drawing.Color.Black;
            this.xClock2.isCustomTime = false;
            this.xClock2.Location = new System.Drawing.Point(474, 12);
            this.xClock2.MajorHashColor = System.Drawing.Color.Red;
            this.xClock2.MinorHashColor = System.Drawing.Color.Black;
            this.xClock2.Name = "xClock2";
            this.xClock2.NumberFont = new System.Drawing.Font("Arial", 10F);
            this.xClock2.NumbersColor = System.Drawing.Color.White;
            this.xClock2.SecondHandColor = System.Drawing.Color.Red;
            this.xClock2.ShowMajorHash = false;
            this.xClock2.ShowMinorHash = false;
            this.xClock2.ShowNumbers = false;
            this.xClock2.ShowSecondHand = true;
            this.xClock2.Size = new System.Drawing.Size(150, 150);
            this.xClock2.TabIndex = 3;
            this.xClock2.TabStop = false;
            this.xClock2.TimeZone = 0;
            // 
            // xClock1
            // 
            this.xClock1.BackColor = System.Drawing.Color.Transparent;
            this.xClock1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xClock1.ClockSize = 300;
            this.xClock1.CustomHour = 0;
            this.xClock1.CustomMinute = 0;
            this.xClock1.CustomSecond = 0;
            this.xClock1.GradEnd = System.Drawing.Color.Gray;
            this.xClock1.GradStart = System.Drawing.Color.Black;
            this.xClock1.HandColor = System.Drawing.Color.White;
            this.xClock1.Image = ((System.Drawing.Image)(resources.GetObject("xClock1.Image")));
            this.xClock1.InnerBorderColor = System.Drawing.Color.Black;
            this.xClock1.isCustomTime = false;
            this.xClock1.Location = new System.Drawing.Point(9, 12);
            this.xClock1.MajorHashColor = System.Drawing.Color.White;
            this.xClock1.MinorHashColor = System.Drawing.Color.Gray;
            this.xClock1.Name = "xClock1";
            this.xClock1.NumberFont = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xClock1.NumbersColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.xClock1.SecondHandColor = System.Drawing.Color.Red;
            this.xClock1.ShowMajorHash = true;
            this.xClock1.ShowMinorHash = true;
            this.xClock1.ShowNumbers = true;
            this.xClock1.ShowSecondHand = true;
            this.xClock1.Size = new System.Drawing.Size(300, 300);
            this.xClock1.TabIndex = 2;
            this.xClock1.TabStop = false;
            this.xClock1.TimeZone = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(793, 388);
            this.Controls.Add(this.xClock7);
            this.Controls.Add(this.xClock6);
            this.Controls.Add(this.xClock5);
            this.Controls.Add(this.xClock4);
            this.Controls.Add(this.xClock3);
            this.Controls.Add(this.xClock2);
            this.Controls.Add(this.xClock1);
            this.Controls.Add(this.txtTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Clock Demo";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.xClock7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xClock6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xClock5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xClock4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xClock3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xClock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xClock1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.Timer timer1;
        private Clock.xClock xClock1;
        private Clock.xClock xClock2;
        private Clock.xClock xClock3;
        private Clock.xClock xClock4;
        private Clock.xClock xClock5;
        private Clock.xClock xClock6;
        private Clock.xClock xClock7;
    }
}