using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Clock {
    public class xClock : PictureBox {
        private Timer timer = new Timer();
        private int clocksize = 200;

        public xClock() {
            clocksize = 200;
            initComponent();
        }

        public xClock(int width) {
            clocksize = width;
            initComponent();
        }


        [Description("Set the clock's size"), Category("Clock")]
        public int ClockSize {
            get { return clocksize; }
            set {
                clocksize = value;

                Width = ClockSize;
                Height = ClockSize;
            }
        }

        [Description("Show numbers on the clock"), Category("Clock")]
        public bool ShowNumbers { get; set; } = true;

        [Description("Show major hash marks on the clock"), Category("Clock")]
        public bool ShowMajorHash { get; set; } = true;

        [Description("Show minor hash marks on the clock"), Category("Clock")]
        public bool ShowMinorHash { get; set; } = true;

        [Description("Show the second hand"), Category("Clock")]
        public bool ShowSecondHand { get; set; } = true;

        [Description("Hand Color"), Category("Clock")]
        public Color HandColor { get; set; } = Color.White;

        [Description("Second Hand Color"), Category("Clock")]
        public Color SecondHandColor { get; set; } = Color.Red;

        [Description("Numbers Color"), Category("Clock")]
        public Color NumbersColor { get; set; } = Color.White;

        [Description("Gradient Start"), Category("Clock")]
        public Color GradStart { get; set; } = Color.FromArgb(30, 30, 30);

        [Description("Gradient End"), Category("Clock")]
        public Color GradEnd { get; set; } = Color.FromArgb(200, 200, 200);

        [Description("Border Color"), Category("Clock")]
        public Color BorderColor { get; set; } = Color.FromArgb(20, 20, 20);

        [Description("Major Hash Color"), Category("Clock")]
        public Color MajorHashColor { get; set; } = Color.Red;

        [Description("Minor Hash Color"), Category("Clock")]
        public Color MinorHashColor { get; set; } = Color.Black;

        [Description("Inner Border Color"), Category("Clock")]
        public Color InnerBorderColor { get; set; } = Color.Black;

        // Set some things
        private void initComponent() {
            BorderStyle = BorderStyle.None;
            BackColor = Color.Transparent;
            Width = ClockSize;
            Height = ClockSize;
            Image = new Bitmap(ClockSize, ClockSize, PixelFormat.Format32bppArgb);

            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += onTick;
        }

        // Math Fun
        private Point getCoords(int value, int ticks, int handLength) {
            int centx = this.Width / 2;
            int centy = this.Height / 2;

            value = (360 / ticks) * value;

            if (value >= 0 && value <= 180) {
                return new Point(
                    (int)(centx + (handLength * Math.Sin(Math.PI * value / 180))),
                    (int)(centy - (handLength * Math.Cos(Math.PI * value / 180)))
                );
            } else {
                return new Point(
                    (int)(centx - (handLength * -Math.Sin(Math.PI * value / 180))),
                    (int)(centy - (handLength * Math.Cos(Math.PI * value / 180)))
                );
            }
        }

        private void onTick(object sender, EventArgs e) {
            int Hour = DateTime.Now.Hour * 5;
            int microHour = DateTime.Now.Minute / 12;
            int Minute = DateTime.Now.Minute;
            int Sec = DateTime.Now.Second;

            Point Center = new Point(ClockSize / 2, ClockSize / 2);
            Graphics g;

            // Set the Gradient
            LinearGradientBrush GBrush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(ClockSize, ClockSize),
                GradStart,
                GradEnd
            );

            // Maintain max resolution if the control gets bigger
            if (this.Image.Width != ClockSize || this.Image.Height != ClockSize) {
                this.Image = new Bitmap(ClockSize, ClockSize, PixelFormat.Format32bppArgb);
            }
            g = Graphics.FromImage(this.Image);

            // Make it nice and smooth
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.Transparent);

            // Draw border
            g.FillEllipse(new SolidBrush(BorderColor), new Rectangle(0, 0, ClockSize, ClockSize));

            // Draw hash marks
            for (int c = 1; c <= 60; c++) {
                if (c % 5 == 0) {
                    if (ShowMajorHash)
                        g.DrawLine(new Pen(MajorHashColor, 1), Center, getCoords(c, 60, (clocksize / 2) - 5));
                } else { 
                    if (ShowMinorHash)
                        g.DrawLine(new Pen(MinorHashColor, 1), Center, getCoords(c, 60, (clocksize / 2) - 5));
                }
            }

            // Draw tiny black inner ring
            g.FillEllipse(new SolidBrush(InnerBorderColor), new Rectangle(15, 15, ClockSize - 30, ClockSize - 30));

            // Fill
            g.FillEllipse(GBrush, new Rectangle(20, 20, ClockSize - 40, ClockSize - 40));

            // Draw Numbers
            if (ShowNumbers) { 
                for(int c = 1; c <= 60; c++) {
                    if (c % 5 == 0) {
                        Point pos = getCoords(c, 60, clocksize / 2 - 35);
                        StringFormat fmt = new StringFormat();
                        fmt.Alignment = StringAlignment.Center;
                        fmt.LineAlignment = StringAlignment.Center;

                        g.DrawString(
                            (c / 5).ToString(),
                            new Font("Arial", 10),
                            new SolidBrush(NumbersColor),
                            new RectangleF(pos.X - 15, pos.Y - 10, 30, 20),
                            fmt
                        );
                    }
                }
            }

            // Draw Hands
            g.DrawLine(new Pen(HandColor, 3), Center, getCoords(Hour + microHour, 60, (ClockSize / 2) - 70));
            g.DrawLine(new Pen(HandColor, 2), Center, getCoords(Minute, 60, (ClockSize / 2) - 50));
            if (ShowSecondHand) g.DrawLine(new Pen(SecondHandColor, 2), Center, getCoords(Sec, 60, (ClockSize / 2) - 50));

            this.Invalidate();
        }
    }
}
