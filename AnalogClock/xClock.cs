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

        [Description("Number Font"), Category("Clock")]
        public Font NumberFont { get; set; } = new Font("Arial", 10);

        [Description("Use custom display times or the current time"), Category("Clock")]
        public bool isCustomTime { get; set; } = false;

        [Description("Set to a number"), Category("Clock")]
        public int CustomHour { get; set; } = 0;

        [Description("Set to a number"), Category("Clock")]
        public int CustomMinute { get; set; } = 0;

        [Description("Set to a number"), Category("Clock")]
        public int CustomSecond { get; set; } = 0;

        [Description("TimeZone offset in hours (ex. 5)"), Category("Clock")]
        public int TimeZone { get; set; } = 0;

        // Set some things
        private void initComponent() {
            Width = ClockSize;
            Height = ClockSize;
            Image = new Bitmap(ClockSize, ClockSize, PixelFormat.Format32bppArgb);

            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += onTick;
        }


        // Math Fun
        private Point findPoint(int value, int ticks, int handLength) {
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

        private void drawClock(DateTime Current) {
            drawClock(Current.Hour, Current.Minute, Current.Second);
        }

        private void drawClock(int hour, int min, int sec) {
            int Hour = hour * 5;
            int microHour = min / 12;
            int Minute = min;
            int Sec = sec;

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
                        g.DrawLine(new Pen(MajorHashColor, 1), Center, findPoint(c, 60, (clocksize / 2) - 5));
                } else {
                    if (ShowMinorHash)
                        g.DrawLine(new Pen(MinorHashColor, 1), Center, findPoint(c, 60, (clocksize / 2) - 5));
                }
            }

            // Draw tiny black inner ring
            g.FillEllipse(new SolidBrush(InnerBorderColor), new Rectangle(15, 15, ClockSize - 30, ClockSize - 30));

            // Fill
            g.FillEllipse(GBrush, new Rectangle(18, 18, ClockSize - 36, ClockSize - 36));

            // Draw Numbers
            if (ShowNumbers) {
                for (int c = 1; c <= 60; c++) {
                    if (c % 5 == 0) {
                        Point pos = findPoint(c, 60, clocksize / 2 - 35);
                        StringFormat fmt = new StringFormat();
                        fmt.Alignment = StringAlignment.Center;
                        fmt.LineAlignment = StringAlignment.Center;

                        g.DrawString(
                            (c / 5).ToString(),
                            NumberFont,
                            new SolidBrush(NumbersColor),
                            new RectangleF(pos.X - 20, pos.Y - 10, 40, 20),
                            fmt
                        );
                    }
                }
            }

            // Draw Hands
            g.DrawLine(new Pen(HandColor, 3), Center, findPoint(Hour + microHour, 60, (ClockSize / 16) * 3));
            g.DrawLine(new Pen(HandColor, 2), Center, findPoint(Minute, 60, (ClockSize / 16) * 5));
            if (ShowSecondHand)
                g.DrawLine(new Pen(SecondHandColor, 2), Center, findPoint(Sec, 60, (ClockSize / 16) * 5));

            this.Invalidate();
        }

        private void onTick(object sender, EventArgs e) {
            if (isCustomTime)
                drawClock(CustomHour, CustomMinute, CustomSecond);
            else
                drawClock(DateTime.Now.AddHours(TimeZone));
        }
    }
}
