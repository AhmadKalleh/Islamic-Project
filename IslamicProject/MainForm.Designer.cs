namespace IslamicProject
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
            this.lbhome = new System.Windows.Forms.Label();
            this.lbPrayerTime = new System.Windows.Forms.Label();
            this.lbDhikr = new System.Windows.Forms.Label();
            this.lbPrayerBeads = new System.Windows.Forms.Label();
            this.lbQuran = new System.Windows.Forms.Label();
            this.plMain = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lbhome
            // 
            this.lbhome.AutoSize = true;
            this.lbhome.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbhome.Location = new System.Drawing.Point(1196, 47);
            this.lbhome.Name = "lbhome";
            this.lbhome.Size = new System.Drawing.Size(208, 36);
            this.lbhome.TabIndex = 1;
            this.lbhome.Text = "الصفحة الرئيسية";
            this.lbhome.Click += new System.EventHandler(this.lbhome_Click);
            // 
            // lbPrayerTime
            // 
            this.lbPrayerTime.AutoSize = true;
            this.lbPrayerTime.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrayerTime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbPrayerTime.Location = new System.Drawing.Point(1003, 47);
            this.lbPrayerTime.Name = "lbPrayerTime";
            this.lbPrayerTime.Size = new System.Drawing.Size(187, 36);
            this.lbPrayerTime.TabIndex = 2;
            this.lbPrayerTime.Text = "مواقيت الصلاة";
            this.lbPrayerTime.Click += new System.EventHandler(this.lbPrayerTime_Click);
            // 
            // lbDhikr
            // 
            this.lbDhikr.AutoSize = true;
            this.lbDhikr.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDhikr.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbDhikr.Location = new System.Drawing.Point(899, 47);
            this.lbDhikr.Name = "lbDhikr";
            this.lbDhikr.Size = new System.Drawing.Size(84, 36);
            this.lbDhikr.TabIndex = 3;
            this.lbDhikr.Text = "الأذكار";
            this.lbDhikr.Click += new System.EventHandler(this.lbDhikr_Click);
            // 
            // lbPrayerBeads
            // 
            this.lbPrayerBeads.AutoSize = true;
            this.lbPrayerBeads.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrayerBeads.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbPrayerBeads.Location = new System.Drawing.Point(768, 47);
            this.lbPrayerBeads.Name = "lbPrayerBeads";
            this.lbPrayerBeads.Size = new System.Drawing.Size(105, 36);
            this.lbPrayerBeads.TabIndex = 4;
            this.lbPrayerBeads.Text = "التسبيح";
            this.lbPrayerBeads.Click += new System.EventHandler(this.lbPrayerBeads_Click);
            // 
            // lbQuran
            // 
            this.lbQuran.AutoSize = true;
            this.lbQuran.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuran.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbQuran.Location = new System.Drawing.Point(653, 47);
            this.lbQuran.Name = "lbQuran";
            this.lbQuran.Size = new System.Drawing.Size(81, 36);
            this.lbQuran.TabIndex = 5;
            this.lbQuran.Text = "القرأن";
            this.lbQuran.Click += new System.EventHandler(this.lbQuran_Click);
            // 
            // plMain
            // 
            this.plMain.Location = new System.Drawing.Point(1, 129);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1428, 627);
            this.plMain.TabIndex = 6;
            // 
            // pbClose
            // 
            this.pbClose.BackgroundImage = global::IslamicProject.Properties.Resources.close;
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbClose.Location = new System.Drawing.Point(23, 12);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(49, 46);
            this.pbClose.TabIndex = 7;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1428, 757);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.lbQuran);
            this.Controls.Add(this.lbPrayerBeads);
            this.Controls.Add(this.lbDhikr);
            this.Controls.Add(this.lbPrayerTime);
            this.Controls.Add(this.lbhome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbhome;
        private System.Windows.Forms.Label lbPrayerTime;
        private System.Windows.Forms.Label lbDhikr;
        private System.Windows.Forms.Label lbPrayerBeads;
        private System.Windows.Forms.Label lbQuran;
        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.PictureBox pbClose;
    }
}

