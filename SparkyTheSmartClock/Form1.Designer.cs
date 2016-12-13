namespace SparkyTheSmartClock
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuNav = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabSchedule = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabNav = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuNav.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuNav
            // 
            this.menuNav.Controls.Add(this.tabHome);
            this.menuNav.Controls.Add(this.tabSchedule);
            this.menuNav.Controls.Add(this.tabNav);
            this.menuNav.Location = new System.Drawing.Point(-6, -22);
            this.menuNav.Name = "menuNav";
            this.menuNav.SelectedIndex = 0;
            this.menuNav.Size = new System.Drawing.Size(376, 628);
            this.menuNav.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.pictureBox1);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(368, 568);
            this.tabHome.TabIndex = 0;
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.NavClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveCapture);
            // 
            // tabSchedule
            // 
            this.tabSchedule.Controls.Add(this.pictureBox2);
            this.tabSchedule.Location = new System.Drawing.Point(4, 22);
            this.tabSchedule.Name = "tabSchedule";
            this.tabSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabSchedule.Size = new System.Drawing.Size(368, 568);
            this.tabSchedule.TabIndex = 1;
            this.tabSchedule.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SparkyTheSmartClock.Properties.Resources.navbar_calander;
            this.pictureBox2.Location = new System.Drawing.Point(2, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(365, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.NavClick);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveCapture);
            // 
            // tabNav
            // 
            this.tabNav.Controls.Add(this.pictureBox3);
            this.tabNav.Location = new System.Drawing.Point(4, 22);
            this.tabNav.Name = "tabNav";
            this.tabNav.Size = new System.Drawing.Size(368, 602);
            this.tabNav.TabIndex = 2;
            this.tabNav.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::SparkyTheSmartClock.Properties.Resources.Navbar_nav;
            this.pictureBox3.Location = new System.Drawing.Point(2, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(365, 85);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.NavClick);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveCapture);
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
            this.tabHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menuNav;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabSchedule;
        private System.Windows.Forms.TabPage tabNav;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

