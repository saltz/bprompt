namespace bprompt
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuNav = new System.Windows.Forms.TabControl();
            this.tab0 = new System.Windows.Forms.TabPage();
            this.lbTransporter = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbDelayArrival = new System.Windows.Forms.Label();
            this.lbDelayDeparture = new System.Windows.Forms.Label();
            this.lbArrivalTrack = new System.Windows.Forms.Label();
            this.lbDepartureTrack = new System.Windows.Forms.Label();
            this.lbArrivalTime = new System.Windows.Forms.Label();
            this.lbDepartureTime = new System.Windows.Forms.Label();
            this.lbIntercitySprinter = new System.Windows.Forms.Label();
            this.pbTrain = new System.Windows.Forms.PictureBox();
            this.lbTravelTime = new System.Windows.Forms.Label();
            this.lbTransfer = new System.Windows.Forms.Label();
            this.lbCountdown = new System.Windows.Forms.Label();
            this.lbTimeLeaves = new System.Windows.Forms.Label();
            this.btCalculateTravelTime = new System.Windows.Forms.Button();
            this.navBox1 = new System.Windows.Forms.PictureBox();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblError = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.navBox2 = new System.Windows.Forms.PictureBox();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.btnSetSchoolAlarm = new System.Windows.Forms.Button();
            this.btnCurrentAlarms = new System.Windows.Forms.Button();
            this.btnConfirmAlarm = new System.Windows.Forms.Button();
            this.btnSetAlarm = new System.Windows.Forms.Button();
            this.btnAmPm = new System.Windows.Forms.Button();
            this.lbMinute = new System.Windows.Forms.Label();
            this.lbHour = new System.Windows.Forms.Label();
            this.tbPlace = new System.Windows.Forms.TextBox();
            this.nudPrepTime = new System.Windows.Forms.NumericUpDown();
            this.lbTimeToGetOutOfBed = new System.Windows.Forms.Label();
            this.lbLivingPlace = new System.Windows.Forms.Label();
            this.pbAlarm = new System.Windows.Forms.PictureBox();
            this.pbClock = new System.Windows.Forms.PictureBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.navBox3 = new System.Windows.Forms.PictureBox();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.tbConfigName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfigSave = new System.Windows.Forms.Button();
            this.tbConfigAdres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeAlliveTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeCheckAlarm = new System.Windows.Forms.Timer(this.components);
            this.TimeCountDown = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuNav.SuspendLayout();
            this.tab0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBox1)).BeginInit();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBox2)).BeginInit();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrepTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBox3)).BeginInit();
            this.tab3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuNav
            // 
            this.menuNav.Controls.Add(this.tab0);
            this.menuNav.Controls.Add(this.tab1);
            this.menuNav.Controls.Add(this.tab2);
            this.menuNav.Controls.Add(this.tab3);
            this.menuNav.Location = new System.Drawing.Point(-6, -22);
            this.menuNav.Name = "menuNav";
            this.menuNav.SelectedIndex = 0;
            this.menuNav.Size = new System.Drawing.Size(376, 628);
            this.menuNav.TabIndex = 0;
            // 
            // tab0
            // 
            this.tab0.Controls.Add(this.lbTransporter);
            this.tab0.Controls.Add(this.lbDate);
            this.tab0.Controls.Add(this.lbDelayArrival);
            this.tab0.Controls.Add(this.lbDelayDeparture);
            this.tab0.Controls.Add(this.lbArrivalTrack);
            this.tab0.Controls.Add(this.lbDepartureTrack);
            this.tab0.Controls.Add(this.lbArrivalTime);
            this.tab0.Controls.Add(this.lbDepartureTime);
            this.tab0.Controls.Add(this.lbIntercitySprinter);
            this.tab0.Controls.Add(this.pbTrain);
            this.tab0.Controls.Add(this.lbTravelTime);
            this.tab0.Controls.Add(this.lbTransfer);
            this.tab0.Controls.Add(this.lbCountdown);
            this.tab0.Controls.Add(this.lbTimeLeaves);
            this.tab0.Controls.Add(this.btCalculateTravelTime);
            this.tab0.Controls.Add(this.navBox1);
            this.tab0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.tab0.Location = new System.Drawing.Point(4, 22);
            this.tab0.Name = "tab0";
            this.tab0.Size = new System.Drawing.Size(368, 602);
            this.tab0.TabIndex = 0;
            this.tab0.UseVisualStyleBackColor = true;
            // 
            // lbTransporter
            // 
            this.lbTransporter.AutoSize = true;
            this.lbTransporter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransporter.Location = new System.Drawing.Point(170, 332);
            this.lbTransporter.Name = "lbTransporter";
            this.lbTransporter.Size = new System.Drawing.Size(81, 16);
            this.lbTransporter.TabIndex = 25;
            this.lbTransporter.Text = "Transporter:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(50, 386);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(40, 16);
            this.lbDate.TabIndex = 24;
            this.lbDate.Text = "Date:";
            // 
            // lbDelayArrival
            // 
            this.lbDelayArrival.AutoSize = true;
            this.lbDelayArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDelayArrival.ForeColor = System.Drawing.Color.Red;
            this.lbDelayArrival.Location = new System.Drawing.Point(50, 472);
            this.lbDelayArrival.Name = "lbDelayArrival";
            this.lbDelayArrival.Size = new System.Drawing.Size(48, 16);
            this.lbDelayArrival.TabIndex = 23;
            this.lbDelayArrival.Text = "+ .. min";
            this.lbDelayArrival.Visible = false;
            // 
            // lbDelayDeparture
            // 
            this.lbDelayDeparture.AutoSize = true;
            this.lbDelayDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDelayDeparture.ForeColor = System.Drawing.Color.Red;
            this.lbDelayDeparture.Location = new System.Drawing.Point(50, 433);
            this.lbDelayDeparture.Name = "lbDelayDeparture";
            this.lbDelayDeparture.Size = new System.Drawing.Size(48, 16);
            this.lbDelayDeparture.TabIndex = 22;
            this.lbDelayDeparture.Text = "+ .. min";
            this.lbDelayDeparture.Visible = false;
            // 
            // lbArrivalTrack
            // 
            this.lbArrivalTrack.AutoSize = true;
            this.lbArrivalTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArrivalTrack.Location = new System.Drawing.Point(266, 457);
            this.lbArrivalTrack.Name = "lbArrivalTrack";
            this.lbArrivalTrack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbArrivalTrack.Size = new System.Drawing.Size(43, 16);
            this.lbArrivalTrack.TabIndex = 21;
            this.lbArrivalTrack.Text = "Track";
            // 
            // lbDepartureTrack
            // 
            this.lbDepartureTrack.AutoSize = true;
            this.lbDepartureTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartureTrack.Location = new System.Drawing.Point(266, 418);
            this.lbDepartureTrack.Name = "lbDepartureTrack";
            this.lbDepartureTrack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbDepartureTrack.Size = new System.Drawing.Size(43, 16);
            this.lbDepartureTrack.TabIndex = 20;
            this.lbDepartureTrack.Text = "Track";
            // 
            // lbArrivalTime
            // 
            this.lbArrivalTime.AutoSize = true;
            this.lbArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArrivalTime.Location = new System.Drawing.Point(50, 457);
            this.lbArrivalTime.Name = "lbArrivalTime";
            this.lbArrivalTime.Size = new System.Drawing.Size(83, 16);
            this.lbArrivalTime.TabIndex = 19;
            this.lbArrivalTime.Text = "00:00 Station";
            // 
            // lbDepartureTime
            // 
            this.lbDepartureTime.AutoSize = true;
            this.lbDepartureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartureTime.Location = new System.Drawing.Point(50, 418);
            this.lbDepartureTime.Name = "lbDepartureTime";
            this.lbDepartureTime.Size = new System.Drawing.Size(83, 16);
            this.lbDepartureTime.TabIndex = 18;
            this.lbDepartureTime.Text = "00:00 Station";
            // 
            // lbIntercitySprinter
            // 
            this.lbIntercitySprinter.AutoSize = true;
            this.lbIntercitySprinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntercitySprinter.Location = new System.Drawing.Point(92, 332);
            this.lbIntercitySprinter.Name = "lbIntercitySprinter";
            this.lbIntercitySprinter.Size = new System.Drawing.Size(0, 16);
            this.lbIntercitySprinter.TabIndex = 17;
            // 
            // pbTrain
            // 
            this.pbTrain.Image = ((System.Drawing.Image)(resources.GetObject("pbTrain.Image")));
            this.pbTrain.Location = new System.Drawing.Point(53, 332);
            this.pbTrain.Name = "pbTrain";
            this.pbTrain.Size = new System.Drawing.Size(33, 35);
            this.pbTrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTrain.TabIndex = 16;
            this.pbTrain.TabStop = false;
            // 
            // lbTravelTime
            // 
            this.lbTravelTime.AutoSize = true;
            this.lbTravelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTravelTime.Location = new System.Drawing.Point(92, 352);
            this.lbTravelTime.Name = "lbTravelTime";
            this.lbTravelTime.Size = new System.Drawing.Size(78, 16);
            this.lbTravelTime.TabIndex = 13;
            this.lbTravelTime.Text = "Travel time:";
            // 
            // lbTransfer
            // 
            this.lbTransfer.AutoSize = true;
            this.lbTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransfer.Location = new System.Drawing.Point(188, 386);
            this.lbTransfer.Name = "lbTransfer";
            this.lbTransfer.Size = new System.Drawing.Size(61, 16);
            this.lbTransfer.TabIndex = 12;
            this.lbTransfer.Text = "Transfer:";
            // 
            // lbCountdown
            // 
            this.lbCountdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this.lbCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountdown.ForeColor = System.Drawing.Color.White;
            this.lbCountdown.Location = new System.Drawing.Point(32, 133);
            this.lbCountdown.Name = "lbCountdown";
            this.lbCountdown.Size = new System.Drawing.Size(300, 77);
            this.lbCountdown.TabIndex = 11;
            this.lbCountdown.Text = "00:00:00";
            this.lbCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTimeLeaves
            // 
            this.lbTimeLeaves.AutoSize = true;
            this.lbTimeLeaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeLeaves.Location = new System.Drawing.Point(87, 102);
            this.lbTimeLeaves.Name = "lbTimeLeaves";
            this.lbTimeLeaves.Size = new System.Drawing.Size(191, 20);
            this.lbTimeLeaves.TabIndex = 10;
            this.lbTimeLeaves.Text = "Time until the train leaves:";
            // 
            // btCalculateTravelTime
            // 
            this.btCalculateTravelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalculateTravelTime.Location = new System.Drawing.Point(109, 273);
            this.btCalculateTravelTime.Name = "btCalculateTravelTime";
            this.btCalculateTravelTime.Size = new System.Drawing.Size(142, 31);
            this.btCalculateTravelTime.TabIndex = 9;
            this.btCalculateTravelTime.Text = "Show Travel Info";
            this.btCalculateTravelTime.UseVisualStyleBackColor = true;
            this.btCalculateTravelTime.Click += new System.EventHandler(this.btCalculateTravelTime_Click);
            // 
            // navBox1
            // 
            this.navBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("navBox1.BackgroundImage")));
            this.navBox1.Image = global::bprompt.Properties.Resources.Navbar_main;
            this.navBox1.Location = new System.Drawing.Point(2, 0);
            this.navBox1.Name = "navBox1";
            this.navBox1.Size = new System.Drawing.Size(365, 80);
            this.navBox1.TabIndex = 0;
            this.navBox1.TabStop = false;
            this.navBox1.Click += new System.EventHandler(this.NavClick);
            this.navBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveCapture);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.listBox1);
            this.tab1.Controls.Add(this.lblError);
            this.tab1.Controls.Add(this.webBrowser);
            this.tab1.Controls.Add(this.navBox2);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(368, 602);
            this.tab1.TabIndex = 1;
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(14, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(330, 446);
            this.listBox1.TabIndex = 5;
            this.listBox1.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(14, 222);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(330, 150);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "Kon het rooster niet ophalen\r\ndoor gebrek aan rechten. :(\r\n\r\nherlaad deze tab om " +
    "het opnieuw\r\nte proberen.\r\n\r\n";
            this.lblError.Visible = false;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(0, 85);
            this.webBrowser.MaximumSize = new System.Drawing.Size(362, 494);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(362, 494);
            this.webBrowser.TabIndex = 2;
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser.Visible = false;
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.WebBrowserNavigated);
            // 
            // navBox2
            // 
            this.navBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("navBox2.BackgroundImage")));
            this.navBox2.Image = global::bprompt.Properties.Resources.Navbar_roster;
            this.navBox2.Location = new System.Drawing.Point(2, 0);
            this.navBox2.Name = "navBox2";
            this.navBox2.Size = new System.Drawing.Size(365, 80);
            this.navBox2.TabIndex = 1;
            this.navBox2.TabStop = false;
            this.navBox2.Click += new System.EventHandler(this.NavClick);
            this.navBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveCapture);
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.btnSetSchoolAlarm);
            this.tab2.Controls.Add(this.btnCurrentAlarms);
            this.tab2.Controls.Add(this.btnConfirmAlarm);
            this.tab2.Controls.Add(this.btnSetAlarm);
            this.tab2.Controls.Add(this.btnAmPm);
            this.tab2.Controls.Add(this.lbMinute);
            this.tab2.Controls.Add(this.lbHour);
            this.tab2.Controls.Add(this.tbPlace);
            this.tab2.Controls.Add(this.nudPrepTime);
            this.tab2.Controls.Add(this.lbTimeToGetOutOfBed);
            this.tab2.Controls.Add(this.lbLivingPlace);
            this.tab2.Controls.Add(this.pbAlarm);
            this.tab2.Controls.Add(this.pbClock);
            this.tab2.Controls.Add(this.pbHome);
            this.tab2.Controls.Add(this.navBox3);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Size = new System.Drawing.Size(368, 602);
            this.tab2.TabIndex = 2;
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // btnSetSchoolAlarm
            // 
            this.btnSetSchoolAlarm.Location = new System.Drawing.Point(186, 272);
            this.btnSetSchoolAlarm.Name = "btnSetSchoolAlarm";
            this.btnSetSchoolAlarm.Size = new System.Drawing.Size(124, 31);
            this.btnSetSchoolAlarm.TabIndex = 17;
            this.btnSetSchoolAlarm.Text = "Set School Alarm";
            this.btnSetSchoolAlarm.UseVisualStyleBackColor = true;
            this.btnSetSchoolAlarm.Click += new System.EventHandler(this.btnSetSchoolAlarm_Click);
            // 
            // btnCurrentAlarms
            // 
            this.btnCurrentAlarms.Location = new System.Drawing.Point(30, 490);
            this.btnCurrentAlarms.Name = "btnCurrentAlarms";
            this.btnCurrentAlarms.Size = new System.Drawing.Size(150, 39);
            this.btnCurrentAlarms.TabIndex = 16;
            this.btnCurrentAlarms.Text = "Current Alarms";
            this.btnCurrentAlarms.UseVisualStyleBackColor = true;
            this.btnCurrentAlarms.Click += new System.EventHandler(this.btnCurrentAlarms_Click);
            // 
            // btnConfirmAlarm
            // 
            this.btnConfirmAlarm.Location = new System.Drawing.Point(186, 490);
            this.btnConfirmAlarm.Name = "btnConfirmAlarm";
            this.btnConfirmAlarm.Size = new System.Drawing.Size(145, 39);
            this.btnConfirmAlarm.TabIndex = 15;
            this.btnConfirmAlarm.Text = "Confirm Alarm";
            this.btnConfirmAlarm.UseVisualStyleBackColor = true;
            this.btnConfirmAlarm.Click += new System.EventHandler(this.btnConfirmAlarm_Click);
            // 
            // btnSetAlarm
            // 
            this.btnSetAlarm.Location = new System.Drawing.Point(186, 392);
            this.btnSetAlarm.Name = "btnSetAlarm";
            this.btnSetAlarm.Size = new System.Drawing.Size(145, 39);
            this.btnSetAlarm.TabIndex = 14;
            this.btnSetAlarm.Text = "Confirm Hour";
            this.btnSetAlarm.UseVisualStyleBackColor = true;
            this.btnSetAlarm.Click += new System.EventHandler(this.btnSetAlarm_Click);
            // 
            // btnAmPm
            // 
            this.btnAmPm.Location = new System.Drawing.Point(281, 334);
            this.btnAmPm.Name = "btnAmPm";
            this.btnAmPm.Size = new System.Drawing.Size(50, 43);
            this.btnAmPm.TabIndex = 13;
            this.btnAmPm.Text = "AM";
            this.btnAmPm.UseVisualStyleBackColor = true;
            this.btnAmPm.Click += new System.EventHandler(this.AmPmClick);
            // 
            // lbMinute
            // 
            this.lbMinute.AutoSize = true;
            this.lbMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbMinute.Location = new System.Drawing.Point(246, 347);
            this.lbMinute.Name = "lbMinute";
            this.lbMinute.Size = new System.Drawing.Size(15, 16);
            this.lbMinute.TabIndex = 11;
            this.lbMinute.Text = "0";
            // 
            // lbHour
            // 
            this.lbHour.AutoSize = true;
            this.lbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbHour.Location = new System.Drawing.Point(202, 347);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(15, 16);
            this.lbHour.TabIndex = 10;
            this.lbHour.Text = "0";
            // 
            // tbPlace
            // 
            this.tbPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlace.Location = new System.Drawing.Point(48, 243);
            this.tbPlace.Name = "tbPlace";
            this.tbPlace.Size = new System.Drawing.Size(100, 22);
            this.tbPlace.TabIndex = 5;
            // 
            // nudPrepTime
            // 
            this.nudPrepTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrepTime.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPrepTime.Location = new System.Drawing.Point(218, 244);
            this.nudPrepTime.Maximum = new decimal(new int[] {
            230,
            0,
            0,
            0});
            this.nudPrepTime.Name = "nudPrepTime";
            this.nudPrepTime.Size = new System.Drawing.Size(64, 22);
            this.nudPrepTime.TabIndex = 4;
            // 
            // lbTimeToGetOutOfBed
            // 
            this.lbTimeToGetOutOfBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeToGetOutOfBed.Location = new System.Drawing.Point(174, 116);
            this.lbTimeToGetOutOfBed.Name = "lbTimeToGetOutOfBed";
            this.lbTimeToGetOutOfBed.Size = new System.Drawing.Size(157, 52);
            this.lbTimeToGetOutOfBed.TabIndex = 3;
            this.lbTimeToGetOutOfBed.Text = "Time (in minutes) from getting out of your bed to arrive at the train station:";
            // 
            // lbLivingPlace
            // 
            this.lbLivingPlace.AutoSize = true;
            this.lbLivingPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLivingPlace.Location = new System.Drawing.Point(51, 132);
            this.lbLivingPlace.Name = "lbLivingPlace";
            this.lbLivingPlace.Size = new System.Drawing.Size(92, 16);
            this.lbLivingPlace.TabIndex = 2;
            this.lbLivingPlace.Text = "   Living place:";
            // 
            // pbAlarm
            // 
            this.pbAlarm.Image = ((System.Drawing.Image)(resources.GetObject("pbAlarm.Image")));
            this.pbAlarm.Location = new System.Drawing.Point(30, 334);
            this.pbAlarm.Name = "pbAlarm";
            this.pbAlarm.Size = new System.Drawing.Size(150, 150);
            this.pbAlarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAlarm.TabIndex = 12;
            this.pbAlarm.TabStop = false;
            this.pbAlarm.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintClock);
            this.pbAlarm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownAlarm);
            this.pbAlarm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveAlarm);
            this.pbAlarm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpAlarm);
            // 
            // pbClock
            // 
            this.pbClock.Image = ((System.Drawing.Image)(resources.GetObject("pbClock.Image")));
            this.pbClock.Location = new System.Drawing.Point(218, 171);
            this.pbClock.Name = "pbClock";
            this.pbClock.Size = new System.Drawing.Size(64, 60);
            this.pbClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClock.TabIndex = 9;
            this.pbClock.TabStop = false;
            // 
            // pbHome
            // 
            this.pbHome.Image = ((System.Drawing.Image)(resources.GetObject("pbHome.Image")));
            this.pbHome.Location = new System.Drawing.Point(70, 171);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(61, 60);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHome.TabIndex = 8;
            this.pbHome.TabStop = false;
            // 
            // navBox3
            // 
            this.navBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("navBox3.BackgroundImage")));
            this.navBox3.Image = global::bprompt.Properties.Resources.Navbar_settings;
            this.navBox3.Location = new System.Drawing.Point(2, 0);
            this.navBox3.Name = "navBox3";
            this.navBox3.Size = new System.Drawing.Size(365, 80);
            this.navBox3.TabIndex = 1;
            this.navBox3.TabStop = false;
            this.navBox3.Click += new System.EventHandler(this.NavClick);
            this.navBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveCapture);
            // 
            // tab3
            // 
            this.tab3.Controls.Add(this.tbConfigName);
            this.tab3.Controls.Add(this.label3);
            this.tab3.Controls.Add(this.btnConfigSave);
            this.tab3.Controls.Add(this.tbConfigAdres);
            this.tab3.Controls.Add(this.label2);
            this.tab3.Controls.Add(this.label1);
            this.tab3.Location = new System.Drawing.Point(4, 22);
            this.tab3.Name = "tab3";
            this.tab3.Size = new System.Drawing.Size(368, 602);
            this.tab3.TabIndex = 3;
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // tbConfigName
            // 
            this.tbConfigName.Location = new System.Drawing.Point(114, 61);
            this.tbConfigName.Name = "tbConfigName";
            this.tbConfigName.Size = new System.Drawing.Size(100, 20);
            this.tbConfigName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "naam";
            // 
            // btnConfigSave
            // 
            this.btnConfigSave.Location = new System.Drawing.Point(122, 150);
            this.btnConfigSave.Name = "btnConfigSave";
            this.btnConfigSave.Size = new System.Drawing.Size(75, 23);
            this.btnConfigSave.TabIndex = 3;
            this.btnConfigSave.Text = "Save";
            this.btnConfigSave.UseVisualStyleBackColor = true;
            this.btnConfigSave.Click += new System.EventHandler(this.btnConfigSave_Click);
            // 
            // tbConfigAdres
            // 
            this.tbConfigAdres.Location = new System.Drawing.Point(114, 92);
            this.tbConfigAdres.Name = "tbConfigAdres";
            this.tbConfigAdres.Size = new System.Drawing.Size(100, 20);
            this.tbConfigAdres.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "adres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "bprompt";
            // 
            // TimeAlliveTimer
            // 
            this.TimeAlliveTimer.Interval = 1000;
            this.TimeAlliveTimer.Tick += new System.EventHandler(this.TickTock);
            // 
            // TimeCheckAlarm
            // 
            this.TimeCheckAlarm.Interval = 1000;
            this.TimeCheckAlarm.Tick += new System.EventHandler(this.AlarmCheck);
            // 
            // TimeCountDown
            // 
            this.TimeCountDown.Tick += new System.EventHandler(this.TimeCountDown_Tick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 604);
            this.Controls.Add(this.menuNav);
            this.MaximumSize = new System.Drawing.Size(376, 643);
            this.Name = "main";
            this.Text = "bprompt";
            this.menuNav.ResumeLayout(false);
            this.tab0.ResumeLayout(false);
            this.tab0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBox1)).EndInit();
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBox2)).EndInit();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrepTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBox3)).EndInit();
            this.tab3.ResumeLayout(false);
            this.tab3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menuNav;
        private System.Windows.Forms.TabPage tab0;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.PictureBox navBox1;
        private System.Windows.Forms.PictureBox navBox2;
        private System.Windows.Forms.PictureBox navBox3;
        private System.Windows.Forms.NumericUpDown nudPrepTime;
        private System.Windows.Forms.Label lbLivingPlace;
        private System.Windows.Forms.TextBox tbPlace;
        private System.Windows.Forms.Label lbTimeToGetOutOfBed;
        private System.Windows.Forms.PictureBox pbClock;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Button btCalculateTravelTime;
        private System.Windows.Forms.Label lbCountdown;
        private System.Windows.Forms.Label lbTimeLeaves;
        private System.Windows.Forms.Label lbTransfer;
        private System.Windows.Forms.Label lbTravelTime;
        private System.Windows.Forms.Label lbIntercitySprinter;
        private System.Windows.Forms.PictureBox pbTrain;
        private System.Windows.Forms.Label lbArrivalTrack;
        private System.Windows.Forms.Label lbDepartureTrack;
        private System.Windows.Forms.Label lbArrivalTime;
        private System.Windows.Forms.Label lbDepartureTime;
        private System.Windows.Forms.Label lbDelayArrival;
        private System.Windows.Forms.Label lbDelayDeparture;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTransporter;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer TimeAlliveTimer;
        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.Label lbMinute;
        private System.Windows.Forms.PictureBox pbAlarm;
        private System.Windows.Forms.Button btnAmPm;
        private System.Windows.Forms.Button btnSetAlarm;
        private System.Windows.Forms.Button btnConfirmAlarm;
        private System.Windows.Forms.Timer TimeCheckAlarm;
        private System.Windows.Forms.Button btnCurrentAlarms;
        private System.Windows.Forms.Timer TimeCountDown;
        private System.Windows.Forms.Button btnSetSchoolAlarm;
        private System.Windows.Forms.TabPage tab3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnConfigSave;
        private System.Windows.Forms.TextBox tbConfigAdres;
        private System.Windows.Forms.TextBox tbConfigName;
        private System.Windows.Forms.Label label3;
    }
}

