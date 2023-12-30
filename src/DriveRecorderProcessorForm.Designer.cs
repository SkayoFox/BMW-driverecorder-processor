namespace DriveRecorderConverter
{
    partial class DriveRecorderProcessorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainFlowPanel = new FlowLayoutPanel();
            PathFlowPanel = new FlowLayoutPanel();
            FolderLabel = new Label();
            PathBox = new TextBox();
            PathChooseBtn = new Button();
            CamSelectGroup = new GroupBox();
            CamsFlowPanel = new FlowLayoutPanel();
            AllCamsRadio = new RadioButton();
            RearCamRadio = new RadioButton();
            FrontCamRadio = new RadioButton();
            StringsTablePanel = new TableLayoutPanel();
            CarNameBox = new TextBox();
            CarNameLabel = new Label();
            DriverNameBox = new TextBox();
            DriverNameLabel = new Label();
            ShowGroup = new GroupBox();
            ChecksTablePanel = new TableLayoutPanel();
            DriverNameCheck = new CheckBox();
            CarNameCheck = new CheckBox();
            SpeedCheck = new CheckBox();
            AccelCheck = new CheckBox();
            CamNameCheck = new CheckBox();
            DateTimeCheck = new CheckBox();
            LocationCheck = new CheckBox();
            InterpolateGroup = new GroupBox();
            InterpolateFlowPanel = new FlowLayoutPanel();
            InterpolateCheck = new CheckBox();
            InterpolateLabel = new Label();
            InterpolateCombo = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            FpsLabel = new Label();
            FpsCombo = new ComboBox();
            VideoGroup = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            TrimCheck = new CheckBox();
            SplitCheck = new CheckBox();
            FlipCheck = new CheckBox();
            ScaleCheck = new CheckBox();
            ScaleNum = new NumericUpDown();
            flowLayoutPanel5 = new FlowLayoutPanel();
            TrimFromLabel = new Label();
            TrimFromNum = new NumericUpDown();
            TrimFromSecondLabel = new Label();
            TrimToLabel = new Label();
            TrimToNum = new NumericUpDown();
            TrimToSecondLabel = new Label();
            extraGroup = new GroupBox();
            ExtraFlowPlanel = new FlowLayoutPanel();
            MphModeCheck = new CheckBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label2 = new Label();
            outputFileBox = new TextBox();
            StartBtn = new Button();
            pathChooseDlg = new FolderBrowserDialog();
            MainFlowPanel.SuspendLayout();
            PathFlowPanel.SuspendLayout();
            CamSelectGroup.SuspendLayout();
            CamsFlowPanel.SuspendLayout();
            StringsTablePanel.SuspendLayout();
            ShowGroup.SuspendLayout();
            ChecksTablePanel.SuspendLayout();
            InterpolateGroup.SuspendLayout();
            InterpolateFlowPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            VideoGroup.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ScaleNum).BeginInit();
            flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrimFromNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrimToNum).BeginInit();
            extraGroup.SuspendLayout();
            ExtraFlowPlanel.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // MainFlowPanel
            // 
            MainFlowPanel.AutoSize = true;
            MainFlowPanel.Controls.Add(PathFlowPanel);
            MainFlowPanel.Controls.Add(CamSelectGroup);
            MainFlowPanel.Controls.Add(StringsTablePanel);
            MainFlowPanel.Controls.Add(ShowGroup);
            MainFlowPanel.Controls.Add(InterpolateGroup);
            MainFlowPanel.Controls.Add(VideoGroup);
            MainFlowPanel.Controls.Add(extraGroup);
            MainFlowPanel.Controls.Add(StartBtn);
            MainFlowPanel.Dock = DockStyle.Fill;
            MainFlowPanel.FlowDirection = FlowDirection.TopDown;
            MainFlowPanel.Location = new Point(0, 0);
            MainFlowPanel.Name = "MainFlowPanel";
            MainFlowPanel.Size = new Size(951, 1048);
            MainFlowPanel.TabIndex = 0;
            // 
            // PathFlowPanel
            // 
            PathFlowPanel.AutoSize = true;
            PathFlowPanel.Controls.Add(FolderLabel);
            PathFlowPanel.Controls.Add(PathBox);
            PathFlowPanel.Controls.Add(PathChooseBtn);
            PathFlowPanel.Dock = DockStyle.Top;
            PathFlowPanel.Location = new Point(3, 3);
            PathFlowPanel.Name = "PathFlowPanel";
            PathFlowPanel.Size = new Size(401, 35);
            PathFlowPanel.TabIndex = 0;
            // 
            // FolderLabel
            // 
            FolderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            FolderLabel.AutoSize = true;
            FolderLabel.Location = new Point(3, 0);
            FolderLabel.Name = "FolderLabel";
            FolderLabel.Size = new Size(40, 35);
            FolderLabel.TabIndex = 0;
            FolderLabel.Text = "Path:";
            FolderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PathBox
            // 
            PathBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PathBox.Location = new Point(49, 3);
            PathBox.Name = "PathBox";
            PathBox.Size = new Size(300, 27);
            PathBox.TabIndex = 1;
            // 
            // PathChooseBtn
            // 
            PathChooseBtn.Location = new Point(355, 3);
            PathChooseBtn.Name = "PathChooseBtn";
            PathChooseBtn.Size = new Size(40, 29);
            PathChooseBtn.TabIndex = 2;
            PathChooseBtn.Text = "...";
            PathChooseBtn.UseVisualStyleBackColor = true;
            PathChooseBtn.Click += PathChooseBtn_Click;
            // 
            // CamSelectGroup
            // 
            CamSelectGroup.AutoSize = true;
            CamSelectGroup.Controls.Add(CamsFlowPanel);
            CamSelectGroup.Dock = DockStyle.Top;
            CamSelectGroup.Location = new Point(3, 44);
            CamSelectGroup.Name = "CamSelectGroup";
            CamSelectGroup.Size = new Size(401, 116);
            CamSelectGroup.TabIndex = 1;
            CamSelectGroup.TabStop = false;
            CamSelectGroup.Text = "Cameras";
            // 
            // CamsFlowPanel
            // 
            CamsFlowPanel.AutoSize = true;
            CamsFlowPanel.Controls.Add(AllCamsRadio);
            CamsFlowPanel.Controls.Add(RearCamRadio);
            CamsFlowPanel.Controls.Add(FrontCamRadio);
            CamsFlowPanel.Dock = DockStyle.Fill;
            CamsFlowPanel.FlowDirection = FlowDirection.TopDown;
            CamsFlowPanel.Location = new Point(3, 23);
            CamsFlowPanel.MinimumSize = new Size(0, 10);
            CamsFlowPanel.Name = "CamsFlowPanel";
            CamsFlowPanel.Size = new Size(395, 90);
            CamsFlowPanel.TabIndex = 0;
            // 
            // AllCamsRadio
            // 
            AllCamsRadio.AutoSize = true;
            AllCamsRadio.Location = new Point(3, 3);
            AllCamsRadio.Name = "AllCamsRadio";
            AllCamsRadio.Size = new Size(107, 24);
            AllCamsRadio.TabIndex = 3;
            AllCamsRadio.TabStop = true;
            AllCamsRadio.Text = "All cameras";
            AllCamsRadio.UseVisualStyleBackColor = true;
            // 
            // RearCamRadio
            // 
            RearCamRadio.AutoSize = true;
            RearCamRadio.Location = new Point(3, 33);
            RearCamRadio.Name = "RearCamRadio";
            RearCamRadio.Size = new Size(123, 24);
            RearCamRadio.TabIndex = 4;
            RearCamRadio.TabStop = true;
            RearCamRadio.Text = "Front and rear";
            RearCamRadio.UseVisualStyleBackColor = true;
            // 
            // FrontCamRadio
            // 
            FrontCamRadio.AutoSize = true;
            FrontCamRadio.Location = new Point(3, 63);
            FrontCamRadio.Name = "FrontCamRadio";
            FrontCamRadio.Size = new Size(96, 24);
            FrontCamRadio.TabIndex = 5;
            FrontCamRadio.TabStop = true;
            FrontCamRadio.Text = "Front only";
            FrontCamRadio.UseVisualStyleBackColor = true;
            // 
            // StringsTablePanel
            // 
            StringsTablePanel.AutoSize = true;
            StringsTablePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            StringsTablePanel.ColumnCount = 2;
            StringsTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            StringsTablePanel.ColumnStyles.Add(new ColumnStyle());
            StringsTablePanel.Controls.Add(CarNameBox, 1, 1);
            StringsTablePanel.Controls.Add(CarNameLabel, 0, 1);
            StringsTablePanel.Controls.Add(DriverNameBox, 1, 0);
            StringsTablePanel.Controls.Add(DriverNameLabel, 0, 0);
            StringsTablePanel.Dock = DockStyle.Top;
            StringsTablePanel.Location = new Point(3, 166);
            StringsTablePanel.Name = "StringsTablePanel";
            StringsTablePanel.RowCount = 2;
            StringsTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            StringsTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            StringsTablePanel.Size = new Size(401, 66);
            StringsTablePanel.TabIndex = 2;
            // 
            // CarNameBox
            // 
            CarNameBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CarNameBox.Location = new Point(103, 36);
            CarNameBox.Name = "CarNameBox";
            CarNameBox.Size = new Size(295, 27);
            CarNameBox.TabIndex = 7;
            // 
            // CarNameLabel
            // 
            CarNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CarNameLabel.AutoSize = true;
            CarNameLabel.Location = new Point(3, 33);
            CarNameLabel.Name = "CarNameLabel";
            CarNameLabel.Size = new Size(34, 33);
            CarNameLabel.TabIndex = 2;
            CarNameLabel.Text = "Car:";
            CarNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DriverNameBox
            // 
            DriverNameBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DriverNameBox.Location = new Point(103, 3);
            DriverNameBox.Name = "DriverNameBox";
            DriverNameBox.Size = new Size(295, 27);
            DriverNameBox.TabIndex = 6;
            // 
            // DriverNameLabel
            // 
            DriverNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            DriverNameLabel.AutoSize = true;
            DriverNameLabel.Location = new Point(3, 0);
            DriverNameLabel.Name = "DriverNameLabel";
            DriverNameLabel.Size = new Size(93, 33);
            DriverNameLabel.TabIndex = 1;
            DriverNameLabel.Text = "Driver name:";
            DriverNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ShowGroup
            // 
            ShowGroup.AutoSize = true;
            ShowGroup.Controls.Add(ChecksTablePanel);
            ShowGroup.Dock = DockStyle.Top;
            ShowGroup.Location = new Point(3, 238);
            ShowGroup.Name = "ShowGroup";
            ShowGroup.Size = new Size(401, 176);
            ShowGroup.TabIndex = 3;
            ShowGroup.TabStop = false;
            ShowGroup.Text = "Show";
            // 
            // ChecksTablePanel
            // 
            ChecksTablePanel.AutoSize = true;
            ChecksTablePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ChecksTablePanel.ColumnCount = 3;
            ChecksTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ChecksTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ChecksTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ChecksTablePanel.Controls.Add(DriverNameCheck, 2, 0);
            ChecksTablePanel.Controls.Add(CarNameCheck, 2, 1);
            ChecksTablePanel.Controls.Add(SpeedCheck, 2, 3);
            ChecksTablePanel.Controls.Add(AccelCheck, 2, 4);
            ChecksTablePanel.Controls.Add(CamNameCheck, 1, 2);
            ChecksTablePanel.Controls.Add(DateTimeCheck, 1, 4);
            ChecksTablePanel.Controls.Add(LocationCheck, 0, 4);
            ChecksTablePanel.Dock = DockStyle.Top;
            ChecksTablePanel.Location = new Point(3, 23);
            ChecksTablePanel.Name = "ChecksTablePanel";
            ChecksTablePanel.RowCount = 5;
            ChecksTablePanel.RowStyles.Add(new RowStyle());
            ChecksTablePanel.RowStyles.Add(new RowStyle());
            ChecksTablePanel.RowStyles.Add(new RowStyle());
            ChecksTablePanel.RowStyles.Add(new RowStyle());
            ChecksTablePanel.RowStyles.Add(new RowStyle());
            ChecksTablePanel.Size = new Size(395, 150);
            ChecksTablePanel.TabIndex = 3;
            // 
            // DriverNameCheck
            // 
            DriverNameCheck.AutoSize = true;
            DriverNameCheck.Location = new Point(265, 3);
            DriverNameCheck.Name = "DriverNameCheck";
            DriverNameCheck.Size = new Size(112, 24);
            DriverNameCheck.TabIndex = 8;
            DriverNameCheck.Text = "Driver name";
            DriverNameCheck.UseVisualStyleBackColor = true;
            // 
            // CarNameCheck
            // 
            CarNameCheck.AutoSize = true;
            CarNameCheck.Location = new Point(265, 33);
            CarNameCheck.Name = "CarNameCheck";
            CarNameCheck.Size = new Size(53, 24);
            CarNameCheck.TabIndex = 9;
            CarNameCheck.Text = "Car";
            CarNameCheck.UseVisualStyleBackColor = true;
            // 
            // SpeedCheck
            // 
            SpeedCheck.AutoSize = true;
            SpeedCheck.Location = new Point(265, 93);
            SpeedCheck.Name = "SpeedCheck";
            SpeedCheck.Size = new Size(73, 24);
            SpeedCheck.TabIndex = 11;
            SpeedCheck.Text = "Speed";
            SpeedCheck.UseVisualStyleBackColor = true;
            // 
            // AccelCheck
            // 
            AccelCheck.AutoSize = true;
            AccelCheck.Location = new Point(265, 123);
            AccelCheck.Name = "AccelCheck";
            AccelCheck.Size = new Size(114, 24);
            AccelCheck.TabIndex = 14;
            AccelCheck.Text = "Acceleration";
            AccelCheck.UseVisualStyleBackColor = true;
            // 
            // CamNameCheck
            // 
            CamNameCheck.AutoSize = true;
            CamNameCheck.Location = new Point(134, 63);
            CamNameCheck.Name = "CamNameCheck";
            CamNameCheck.Size = new Size(88, 24);
            CamNameCheck.TabIndex = 10;
            CamNameCheck.Text = "Cameras";
            CamNameCheck.UseVisualStyleBackColor = true;
            // 
            // DateTimeCheck
            // 
            DateTimeCheck.AutoSize = true;
            DateTimeCheck.Location = new Point(134, 123);
            DateTimeCheck.Name = "DateTimeCheck";
            DateTimeCheck.Size = new Size(114, 24);
            DateTimeCheck.TabIndex = 13;
            DateTimeCheck.Text = "Date + Time";
            DateTimeCheck.UseVisualStyleBackColor = true;
            // 
            // LocationCheck
            // 
            LocationCheck.AutoSize = true;
            LocationCheck.Location = new Point(3, 123);
            LocationCheck.Name = "LocationCheck";
            LocationCheck.Size = new Size(88, 24);
            LocationCheck.TabIndex = 12;
            LocationCheck.Text = "Location";
            LocationCheck.UseVisualStyleBackColor = true;
            // 
            // InterpolateGroup
            // 
            InterpolateGroup.AutoSize = true;
            InterpolateGroup.Controls.Add(InterpolateFlowPanel);
            InterpolateGroup.Dock = DockStyle.Top;
            InterpolateGroup.Location = new Point(3, 420);
            InterpolateGroup.Name = "InterpolateGroup";
            InterpolateGroup.Size = new Size(401, 150);
            InterpolateGroup.TabIndex = 5;
            InterpolateGroup.TabStop = false;
            InterpolateGroup.Text = "Interpolation";
            // 
            // InterpolateFlowPanel
            // 
            InterpolateFlowPanel.AutoSize = true;
            InterpolateFlowPanel.Controls.Add(InterpolateCheck);
            InterpolateFlowPanel.Controls.Add(InterpolateLabel);
            InterpolateFlowPanel.Controls.Add(InterpolateCombo);
            InterpolateFlowPanel.Controls.Add(flowLayoutPanel1);
            InterpolateFlowPanel.Dock = DockStyle.Fill;
            InterpolateFlowPanel.FlowDirection = FlowDirection.TopDown;
            InterpolateFlowPanel.Location = new Point(3, 23);
            InterpolateFlowPanel.MinimumSize = new Size(0, 10);
            InterpolateFlowPanel.Name = "InterpolateFlowPanel";
            InterpolateFlowPanel.Size = new Size(395, 124);
            InterpolateFlowPanel.TabIndex = 0;
            // 
            // InterpolateCheck
            // 
            InterpolateCheck.AutoSize = true;
            InterpolateCheck.Location = new Point(3, 3);
            InterpolateCheck.Name = "InterpolateCheck";
            InterpolateCheck.Size = new Size(76, 24);
            InterpolateCheck.TabIndex = 15;
            InterpolateCheck.Text = "Enable";
            InterpolateCheck.UseVisualStyleBackColor = true;
            InterpolateCheck.CheckedChanged += InterpolateCheck_CheckedChanged;
            // 
            // InterpolateLabel
            // 
            InterpolateLabel.AutoSize = true;
            InterpolateLabel.Location = new Point(3, 30);
            InterpolateLabel.Name = "InterpolateLabel";
            InterpolateLabel.Size = new Size(79, 20);
            InterpolateLabel.TabIndex = 5;
            InterpolateLabel.Text = "Algorithm:";
            // 
            // InterpolateCombo
            // 
            InterpolateCombo.Enabled = false;
            InterpolateCombo.FormattingEnabled = true;
            InterpolateCombo.Items.AddRange(new object[] { "tblend", "minterpolate" });
            InterpolateCombo.Location = new Point(3, 53);
            InterpolateCombo.Name = "InterpolateCombo";
            InterpolateCombo.Size = new Size(123, 28);
            InterpolateCombo.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(FpsLabel);
            flowLayoutPanel1.Controls.Add(FpsCombo);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(3, 87);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(123, 34);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // FpsLabel
            // 
            FpsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            FpsLabel.AutoSize = true;
            FpsLabel.Location = new Point(3, 0);
            FpsLabel.Name = "FpsLabel";
            FpsLabel.Size = new Size(35, 34);
            FpsLabel.TabIndex = 0;
            FpsLabel.Text = "FPS:";
            FpsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FpsCombo
            // 
            FpsCombo.Enabled = false;
            FpsCombo.FormattingEnabled = true;
            FpsCombo.Items.AddRange(new object[] { "30", "60", "120" });
            FpsCombo.Location = new Point(44, 3);
            FpsCombo.Name = "FpsCombo";
            FpsCombo.Size = new Size(74, 28);
            FpsCombo.TabIndex = 17;
            // 
            // VideoGroup
            // 
            VideoGroup.AutoSize = true;
            VideoGroup.Controls.Add(tableLayoutPanel1);
            VideoGroup.Dock = DockStyle.Top;
            VideoGroup.Location = new Point(3, 576);
            VideoGroup.Name = "VideoGroup";
            VideoGroup.Size = new Size(401, 161);
            VideoGroup.TabIndex = 7;
            VideoGroup.TabStop = false;
            VideoGroup.Text = "Video options";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(TrimCheck, 0, 1);
            tableLayoutPanel1.Controls.Add(SplitCheck, 0, 0);
            tableLayoutPanel1.Controls.Add(FlipCheck, 1, 0);
            tableLayoutPanel1.Controls.Add(ScaleCheck, 0, 2);
            tableLayoutPanel1.Controls.Add(ScaleNum, 1, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel5, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(395, 102);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // TrimCheck
            // 
            TrimCheck.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TrimCheck.AutoSize = true;
            TrimCheck.Location = new Point(3, 33);
            TrimCheck.Name = "TrimCheck";
            TrimCheck.Size = new Size(60, 33);
            TrimCheck.TabIndex = 20;
            TrimCheck.Text = "Trim";
            TrimCheck.UseVisualStyleBackColor = true;
            TrimCheck.CheckedChanged += TrimCheck_CheckedChanged;
            // 
            // SplitCheck
            // 
            SplitCheck.AutoSize = true;
            SplitCheck.Location = new Point(3, 3);
            SplitCheck.Name = "SplitCheck";
            SplitCheck.Size = new Size(102, 24);
            SplitCheck.TabIndex = 18;
            SplitCheck.Text = "Split video";
            SplitCheck.UseVisualStyleBackColor = true;
            // 
            // FlipCheck
            // 
            FlipCheck.AutoSize = true;
            FlipCheck.Location = new Point(121, 3);
            FlipCheck.Name = "FlipCheck";
            FlipCheck.Size = new Size(138, 24);
            FlipCheck.TabIndex = 19;
            FlipCheck.Text = "Flip rear camera";
            FlipCheck.UseVisualStyleBackColor = true;
            // 
            // ScaleCheck
            // 
            ScaleCheck.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ScaleCheck.AutoSize = true;
            ScaleCheck.Location = new Point(3, 72);
            ScaleCheck.Name = "ScaleCheck";
            ScaleCheck.Size = new Size(66, 27);
            ScaleCheck.TabIndex = 23;
            ScaleCheck.Text = "Scale";
            ScaleCheck.UseVisualStyleBackColor = true;
            ScaleCheck.CheckedChanged += ScaleCheck_CheckedChanged;
            // 
            // ScaleNum
            // 
            ScaleNum.Enabled = false;
            ScaleNum.Location = new Point(121, 72);
            ScaleNum.Name = "ScaleNum";
            ScaleNum.Size = new Size(48, 27);
            ScaleNum.TabIndex = 24;
            ScaleNum.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.Controls.Add(TrimFromLabel);
            flowLayoutPanel5.Controls.Add(TrimFromNum);
            flowLayoutPanel5.Controls.Add(TrimFromSecondLabel);
            flowLayoutPanel5.Controls.Add(TrimToLabel);
            flowLayoutPanel5.Controls.Add(TrimToNum);
            flowLayoutPanel5.Controls.Add(TrimToSecondLabel);
            flowLayoutPanel5.Location = new Point(121, 33);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(230, 33);
            flowLayoutPanel5.TabIndex = 16;
            // 
            // TrimFromLabel
            // 
            TrimFromLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TrimFromLabel.AutoSize = true;
            TrimFromLabel.Location = new Point(3, 0);
            TrimFromLabel.Name = "TrimFromLabel";
            TrimFromLabel.Size = new Size(41, 33);
            TrimFromLabel.TabIndex = 0;
            TrimFromLabel.Text = "from";
            TrimFromLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TrimFromNum
            // 
            TrimFromNum.Enabled = false;
            TrimFromNum.Location = new Point(50, 3);
            TrimFromNum.Name = "TrimFromNum";
            TrimFromNum.Size = new Size(50, 27);
            TrimFromNum.TabIndex = 21;
            // 
            // TrimFromSecondLabel
            // 
            TrimFromSecondLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TrimFromSecondLabel.AutoSize = true;
            TrimFromSecondLabel.Location = new Point(106, 0);
            TrimFromSecondLabel.Name = "TrimFromSecondLabel";
            TrimFromSecondLabel.Size = new Size(15, 33);
            TrimFromSecondLabel.TabIndex = 12;
            TrimFromSecondLabel.Text = "s";
            TrimFromSecondLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TrimToLabel
            // 
            TrimToLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TrimToLabel.AutoSize = true;
            TrimToLabel.Location = new Point(127, 0);
            TrimToLabel.Name = "TrimToLabel";
            TrimToLabel.Size = new Size(23, 33);
            TrimToLabel.TabIndex = 1;
            TrimToLabel.Text = "to";
            TrimToLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TrimToNum
            // 
            TrimToNum.Enabled = false;
            TrimToNum.Location = new Point(156, 3);
            TrimToNum.Name = "TrimToNum";
            TrimToNum.Size = new Size(50, 27);
            TrimToNum.TabIndex = 22;
            TrimToNum.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // TrimToSecondLabel
            // 
            TrimToSecondLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TrimToSecondLabel.AutoSize = true;
            TrimToSecondLabel.Location = new Point(212, 0);
            TrimToSecondLabel.Name = "TrimToSecondLabel";
            TrimToSecondLabel.Size = new Size(15, 33);
            TrimToSecondLabel.TabIndex = 13;
            TrimToSecondLabel.Text = "s";
            TrimToSecondLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // extraGroup
            // 
            extraGroup.AutoSize = true;
            extraGroup.Controls.Add(ExtraFlowPlanel);
            extraGroup.Dock = DockStyle.Top;
            extraGroup.Location = new Point(3, 743);
            extraGroup.Name = "extraGroup";
            extraGroup.Size = new Size(401, 95);
            extraGroup.TabIndex = 6;
            extraGroup.TabStop = false;
            extraGroup.Text = "Additional settings";
            // 
            // ExtraFlowPlanel
            // 
            ExtraFlowPlanel.AutoSize = true;
            ExtraFlowPlanel.Controls.Add(MphModeCheck);
            ExtraFlowPlanel.Controls.Add(flowLayoutPanel3);
            ExtraFlowPlanel.Dock = DockStyle.Fill;
            ExtraFlowPlanel.FlowDirection = FlowDirection.TopDown;
            ExtraFlowPlanel.Location = new Point(3, 23);
            ExtraFlowPlanel.MinimumSize = new Size(0, 10);
            ExtraFlowPlanel.Name = "ExtraFlowPlanel";
            ExtraFlowPlanel.Size = new Size(395, 69);
            ExtraFlowPlanel.TabIndex = 0;
            // 
            // MphModeCheck
            // 
            MphModeCheck.AutoSize = true;
            MphModeCheck.Location = new Point(3, 3);
            MphModeCheck.Name = "MphModeCheck";
            MphModeCheck.Size = new Size(122, 24);
            MphModeCheck.TabIndex = 25;
            MphModeCheck.Text = "mph and ft/s²";
            MphModeCheck.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(label2);
            flowLayoutPanel3.Controls.Add(outputFileBox);
            flowLayoutPanel3.Dock = DockStyle.Top;
            flowLayoutPanel3.Location = new Point(3, 33);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(389, 33);
            flowLayoutPanel3.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 33);
            label2.TabIndex = 0;
            label2.Text = "Output file name:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // outputFileBox
            // 
            outputFileBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            outputFileBox.Location = new Point(133, 3);
            outputFileBox.Name = "outputFileBox";
            outputFileBox.Size = new Size(253, 27);
            outputFileBox.TabIndex = 26;
            outputFileBox.Text = "output.mp4";
            // 
            // StartBtn
            // 
            StartBtn.Dock = DockStyle.Top;
            StartBtn.Location = new Point(3, 844);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(401, 29);
            StartBtn.TabIndex = 27;
            StartBtn.Text = "Process video";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // DriveRecorderProcessorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(951, 1048);
            Controls.Add(MainFlowPanel);
            MaximizeBox = false;
            Name = "DriveRecorderProcessorForm";
            Text = "BMW Drive recorder processor";
            Load += DriveRecorderConverterForm_Load;
            MainFlowPanel.ResumeLayout(false);
            MainFlowPanel.PerformLayout();
            PathFlowPanel.ResumeLayout(false);
            PathFlowPanel.PerformLayout();
            CamSelectGroup.ResumeLayout(false);
            CamSelectGroup.PerformLayout();
            CamsFlowPanel.ResumeLayout(false);
            CamsFlowPanel.PerformLayout();
            StringsTablePanel.ResumeLayout(false);
            StringsTablePanel.PerformLayout();
            ShowGroup.ResumeLayout(false);
            ShowGroup.PerformLayout();
            ChecksTablePanel.ResumeLayout(false);
            ChecksTablePanel.PerformLayout();
            InterpolateGroup.ResumeLayout(false);
            InterpolateGroup.PerformLayout();
            InterpolateFlowPanel.ResumeLayout(false);
            InterpolateFlowPanel.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            VideoGroup.ResumeLayout(false);
            VideoGroup.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ScaleNum).EndInit();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrimFromNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrimToNum).EndInit();
            extraGroup.ResumeLayout(false);
            extraGroup.PerformLayout();
            ExtraFlowPlanel.ResumeLayout(false);
            ExtraFlowPlanel.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel MainFlowPanel;
        private FlowLayoutPanel PathFlowPanel;
        private Label FolderLabel;
        private TextBox PathBox;
        private Button PathChooseBtn;
        private GroupBox CamSelectGroup;
        private FlowLayoutPanel CamsFlowPanel;
        private RadioButton AllCamsRadio;
        private RadioButton RearCamRadio;
        private RadioButton FrontCamRadio;
        private TableLayoutPanel StringsTablePanel;
        private TextBox DriverNameBox;
        private TextBox CarNameBox;
        private Label CarNameLabel;
        private Label DriverNameLabel;
        private GroupBox ShowGroup;
        private TableLayoutPanel ChecksTablePanel;
        private CheckBox DriverNameCheck;
        private CheckBox CamNameCheck;
        private CheckBox CarNameCheck;
        private CheckBox SpeedCheck;
        private CheckBox AccelCheck;
        private CheckBox DateTimeCheck;
        private CheckBox LocationCheck;
        private Button StartBtn;
        private FolderBrowserDialog pathChooseDlg;
        private GroupBox InterpolateGroup;
        private FlowLayoutPanel InterpolateFlowPanel;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private CheckBox InterpolateCheck;
        private ComboBox InterpolateCombo;
        private Label InterpolateLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label FpsLabel;
        private ComboBox FpsCombo;
        private GroupBox extraGroup;
        private FlowLayoutPanel ExtraFlowPlanel;
        private CheckBox MphModeCheck;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label2;
        private TextBox outputFileBox;
        private GroupBox VideoGroup;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox FlipCheck;
        private CheckBox TrimCheck;
        private CheckBox SplitCheck;
        private Label TrimFromLabel;
        private NumericUpDown TrimFromNum;
        private Label TrimFromSecondLabel;
        private Label TrimToLabel;
        private NumericUpDown TrimToNum;
        private Label TrimToSecondLabel;
        private CheckBox ScaleCheck;
        private NumericUpDown ScaleNum;
        private FlowLayoutPanel flowLayoutPanel5;
    }
}
