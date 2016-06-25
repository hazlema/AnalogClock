using System;
using System.Windows.Forms;

namespace AnalogClock {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            Random rnd = new Random();
            txtTime.Text = DateTime.Now.ToLongTimeString();

            DateTime fancy = new DateTime(1990, 1, 1, xClock3.CustomHour, xClock3.CustomMinute, xClock3.CustomSecond).AddMinutes(rnd.Next(1,20)).AddSeconds(5);
            xClock3.CustomHour = fancy.Hour;
            xClock3.CustomMinute = fancy.Minute;
            xClock3.CustomSecond = fancy.Second;
        }

        private void xClock2_Click(object sender, EventArgs e) {

        }
    }
}
