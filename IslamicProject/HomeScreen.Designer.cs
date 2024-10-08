namespace IslamicProject
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.lbAddlecationDetails = new System.Windows.Forms.Label();
            this.lbIntroduction = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAddlecationDetails
            // 
            this.lbAddlecationDetails.Font = new System.Drawing.Font("LBC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddlecationDetails.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lbAddlecationDetails.Location = new System.Drawing.Point(823, 371);
            this.lbAddlecationDetails.Name = "lbAddlecationDetails";
            this.lbAddlecationDetails.Size = new System.Drawing.Size(520, 138);
            this.lbAddlecationDetails.TabIndex = 16;
            this.lbAddlecationDetails.Text = resources.GetString("lbAddlecationDetails.Text");
            this.lbAddlecationDetails.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbIntroduction
            // 
            this.lbIntroduction.Font = new System.Drawing.Font("LBC", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntroduction.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbIntroduction.Location = new System.Drawing.Point(825, 16);
            this.lbIntroduction.Name = "lbIntroduction";
            this.lbIntroduction.Size = new System.Drawing.Size(546, 350);
            this.lbIntroduction.TabIndex = 15;
            this.lbIntroduction.Text = "جزاكم الله خيرا";
            this.lbIntroduction.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::IslamicProject.Properties.Resources.Mosque_online_service_rafiki;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(55, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(722, 541);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1428, 590);
            this.Controls.Add(this.lbAddlecationDetails);
            this.Controls.Add(this.lbIntroduction);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbAddlecationDetails;
        private System.Windows.Forms.Label lbIntroduction;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}