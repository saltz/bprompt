namespace SparkyTheSmartClock
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
            this.pbClock = new System.Windows.Forms.PictureBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.tbPlace = new System.Windows.Forms.TextBox();
            this.nudPrepTime = new System.Windows.Forms.NumericUpDown();
            this.lbTimeToGetOutOfBed = new System.Windows.Forms.Label();
            this.lbLivingPlace = new System.Windows.Forms.Label();
            this.navBox3 = new System.Windows.Forms.PictureBox();
            this.TimeAlliveTimer = new System.Windows.Forms.Timer(this.components);
            this.menuNav.SuspendLayout();
            this.tab0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBox1)).BeginInit();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBox2)).BeginInit();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrepTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuNav
            // 
            this.menuNav.Controls.Add(this.tab0);
            this.menuNav.Controls.Add(this.tab1);
            this.menuNav.Controls.Add(this.tab2);
            this.menuNav.Location = new System.Drawing.Point(-6, 1);
            this.menuNav.Name = "menuNav";
            this.menuNav.SelectedIndex = 0;
            this.menuNav.Size = new System.Drawing.Size(376, 605);
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
            this.tab0.Size = new System.Drawing.Size(368, 579);
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
            this.pbTrain.Image = global::SparkyTheSmartClock.Properties.Resources.train;
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
            this.lbCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountdown.ForeColor = System.Drawing.Color.White;
            this.lbCountdown.Location = new System.Drawing.Point(52, 130);
            this.lbCountdown.Name = "lbCountdown";
            this.lbCountdown.Size = new System.Drawing.Size(264, 77);
            this.lbCountdown.TabIndex = 11;
            this.lbCountdown.Text = "00:00";
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
            this.btCalculateTravelTime.Location = new System.Drawing.Point(116, 279);
            this.btCalculateTravelTime.Name = "btCalculateTravelTime";
            this.btCalculateTravelTime.Size = new System.Drawing.Size(131, 23);
            this.btCalculateTravelTime.TabIndex = 9;
            this.btCalculateTravelTime.Text = "Show travel info";
            this.btCalculateTravelTime.UseVisualStyleBackColor = true;
            this.btCalculateTravelTime.Click += new System.EventHandler(this.btCalculateTravelTime_Click);
            // 
            // navBox1
            // 
            this.navBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("navBox1.BackgroundImage")));
            this.navBox1.Location = new System.Drawing.Point(2, 0);
            this.navBox1.Name = "navBox1";
            this.navBox1.Size = new System.Drawing.Size(365, 85);
            this.navBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.tab1.Size = new System.Drawing.Size(368, 579);
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
            this.navBox2.BackgroundImage = global::SparkyTheSmartClock.Properties.Resources.navbar_calander;
            this.navBox2.Location = new System.Drawing.Point(2, 0);
            this.navBox2.Name = "navBox2";
            this.navBox2.Size = new System.Drawing.Size(365, 85);
            this.navBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.navBox2.TabIndex = 1;
            this.navBox2.TabStop = false;
            this.navBox2.Click += new System.EventHandler(this.NavClick);
            this.navBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveCapture);
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.pbClock);
            this.tab2.Controls.Add(this.pbHome);
            this.tab2.Controls.Add(this.tbPlace);
            this.tab2.Controls.Add(this.nudPrepTime);
            this.tab2.Controls.Add(this.lbTimeToGetOutOfBed);
            this.tab2.Controls.Add(this.lbLivingPlace);
            this.tab2.Controls.Add(this.navBox3);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Size = new System.Drawing.Size(368, 579);
            this.tab2.TabIndex = 2;
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // pbClock
            // 
            this.pbClock.Image = global::SparkyTheSmartClock.Properties.Resources.clock;
            this.pbClock.Location = new System.Drawing.Point(218, 171);
            this.pbClock.Name = "pbClock";
            this.pbClock.Size = new System.Drawing.Size(64, 60);
            this.pbClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClock.TabIndex = 9;
            this.pbClock.TabStop = false;
            // 
            // pbHome
            // 
            this.pbHome.Image = global::SparkyTheSmartClock.Properties.Resources.home;
            this.pbHome.Location = new System.Drawing.Point(70, 171);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(61, 60);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHome.TabIndex = 8;
            this.pbHome.TabStop = false;
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
            1000,
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
            // navBox3
            // 
            this.navBox3.BackgroundImage = global::SparkyTheSmartClock.Properties.Resources.Navbar_nav;
            this.navBox3.Location = new System.Drawing.Point(2, 0);
            this.navBox3.Name = "navBox3";
            this.navBox3.Size = new System.Drawing.Size(365, 85);
            this.navBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.navBox3.TabIndex = 1;
            this.navBox3.TabStop = false;
            this.navBox3.Click += new System.EventHandler(this.NavClick);
            this.navBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveCapture);
            // 
            // TimeAlliveTimer
            // 
            this.TimeAlliveTimer.Interval = 1000;
            this.TimeAlliveTimer.Tick += new System.EventHandler(this.TickTock);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 604);
            this.Controls.Add(this.menuNav);
            this.MaximumSize = new System.Drawing.Size(376, 643);
            this.Name = "main";
            this.Text = "Sparky App";
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
            ((System.ComponentModel.ISupportInitialize)(this.pbClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrepTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBox3)).EndInit();
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
    }
}

