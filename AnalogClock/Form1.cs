﻿using System;
using System.Windows.Forms;

namespace AnalogClock {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            txtTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
