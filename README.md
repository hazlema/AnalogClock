# AnalogClock
![alt text](https://raw.githubusercontent.com/hazlema/AnalogClock/master/ClockControl.png "Customizable Analog Clock Control")
<br><br>
Properties yyou can change at Design Time:<br>

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
