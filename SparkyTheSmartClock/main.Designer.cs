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
            this.navBox3 = new System.Windows.Forms.PictureBox();
            this.menuNav.SuspendLayout();
            this.tab0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBox1)).BeginInit();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBox2)).BeginInit();
            this.tab2.SuspendLayout();
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
            this.tab2.Controls.Add(this.navBox3);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Size = new System.Drawing.Size(368, 602);
            this.tab2.TabIndex = 2;
            this.tab2.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 604);
            this.Controls.Add(this.menuNav);
            this.Name = "Form1";
            this.Text = "Sparky App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuNav.ResumeLayout(false);
            this.tab0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBox1)).EndInit();
            this.tab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBox2)).EndInit();
            this.tab2.ResumeLayout(false);
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
    }
}

