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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuNav = new System.Windows.Forms.TabControl();
            this.tab0 = new System.Windows.Forms.TabPage();
            this.navBox1 = new System.Windows.Forms.PictureBox();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.navBox2 = new System.Windows.Forms.PictureBox();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btCalculateTravelTime = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.tbPlace = new System.Windows.Forms.TextBox();
            this.nudPrepTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.navBox3 = new System.Windows.Forms.PictureBox();
            this.menuNav.SuspendLayout();
            this.tab0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBox1)).BeginInit();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBox2)).BeginInit();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrepTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuNav
            // 
            this.menuNav.Controls.Add(this.tab0);
            this.menuNav.Controls.Add(this.tab1);
            this.menuNav.Controls.Add(this.tab2);
            this.menuNav.Location = new System.Drawing.Point(-6, -22);
            this.menuNav.Name = "menuNav";
            this.menuNav.SelectedIndex = 0;
            this.menuNav.Size = new System.Drawing.Size(376, 628);
            this.menuNav.TabIndex = 0;
            // 
            // tab0
            // 
            this.tab0.Controls.Add(this.navBox1);
            this.tab0.Location = new System.Drawing.Point(4, 22);
            this.tab0.Name = "tab0";
            this.tab0.Size = new System.Drawing.Size(368, 602);
            this.tab0.TabIndex = 0;
            this.tab0.UseVisualStyleBackColor = true;
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
            this.tab1.Controls.Add(this.navBox2);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(368, 602);
            this.tab1.TabIndex = 1;
            this.tab1.UseVisualStyleBackColor = true;
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
            this.tab2.Controls.Add(this.pictureBox2);
            this.tab2.Controls.Add(this.pictureBox1);
            this.tab2.Controls.Add(this.btCalculateTravelTime);
            this.tab2.Controls.Add(this.lbInfo);
            this.tab2.Controls.Add(this.tbPlace);
            this.tab2.Controls.Add(this.nudPrepTime);
            this.tab2.Controls.Add(this.label2);
            this.tab2.Controls.Add(this.label1);
            this.tab2.Controls.Add(this.navBox3);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Size = new System.Drawing.Size(368, 602);
            this.tab2.TabIndex = 2;
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SparkyTheSmartClock.Properties.Resources.clock;
            this.pictureBox2.Location = new System.Drawing.Point(223, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SparkyTheSmartClock.Properties.Resources.home;
            this.pictureBox1.Location = new System.Drawing.Point(70, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btCalculateTravelTime
            // 
            this.btCalculateTravelTime.Location = new System.Drawing.Point(48, 266);
            this.btCalculateTravelTime.Name = "btCalculateTravelTime";
            this.btCalculateTravelTime.Size = new System.Drawing.Size(264, 23);
            this.btCalculateTravelTime.TabIndex = 7;
            this.btCalculateTravelTime.Text = "Show travels";
            this.btCalculateTravelTime.UseVisualStyleBackColor = true;
            this.btCalculateTravelTime.Click += new System.EventHandler(this.btCalculateTravelTime_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.Location = new System.Drawing.Point(48, 304);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(264, 251);
            this.lbInfo.TabIndex = 6;
            // 
            // tbPlace
            // 
            this.tbPlace.Location = new System.Drawing.Point(48, 228);
            this.tbPlace.Name = "tbPlace";
            this.tbPlace.Size = new System.Drawing.Size(100, 20);
            this.tbPlace.TabIndex = 5;
            // 
            // nudPrepTime
            // 
            this.nudPrepTime.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPrepTime.Location = new System.Drawing.Point(223, 228);
            this.nudPrepTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPrepTime.Name = "nudPrepTime";
            this.nudPrepTime.Size = new System.Drawing.Size(64, 20);
            this.nudPrepTime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(171, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time (in minutes) from getting out of your bed to arrive at the train station:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Living place:";
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
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 604);
            this.Controls.Add(this.menuNav);
            this.Name = "main";
            this.Text = "Sparky App";
            this.menuNav.ResumeLayout(false);
            this.tab0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBox1)).EndInit();
            this.tab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBox2)).EndInit();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPlace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCalculateTravelTime;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

