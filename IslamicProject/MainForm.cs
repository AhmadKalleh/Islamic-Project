using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IslamicProject
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

       
        private void loadform(Form form)
        {
            if(this.plMain.Controls.Count > 0)
            {
                this.plMain.Controls.Clear();
            }

            
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            this.plMain.Controls.Add(form);
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lbhome.Font = new Font(lbPrayerTime.Font, FontStyle.Bold | FontStyle.Underline);

            loadform(new HomeScreen());

        }

        void SetRoundedCornersToPicturs(PictureBox pictureBox, int cornerRadius)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            gp.AddArc(pictureBox.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            gp.AddArc(pictureBox.Width - cornerRadius, pictureBox.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            gp.AddArc(0, pictureBox.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            gp.CloseFigure();

            pictureBox.Region = new Region(gp);
        }
        private void SetRoundedCornersToForm()
        {
            int radius = 30; // نصف قطر الزوايا الدائرية
            GraphicsPath path = new GraphicsPath();

            // إضافة مستطيل بزوايا دائرية إلى المسار
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path); // تعيين المنطقة المحددة للمسار
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetRoundedCornersToForm(); // إعادة تعيين الزوايا عند تغيير حجم النموذج
            
        }      
        
          
        private void ChangeFontStyle(Label label,bool BoldAndUnderline = false)
        {
            if (BoldAndUnderline)
            {
                label.Font = new Font(lbPrayerTime.Font, FontStyle.Underline | FontStyle.Bold);
            }
            else
            {
                label.Font = new Font(lbPrayerTime.Font, FontStyle.Bold);
            }
        }
      
       

        private void Ununderline(Label label)
        {
            ChangeFontStyle(label, false);
        }
        private void lbhome_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(lbhome, true);
            Ununderline(lbDhikr);
            Ununderline(lbPrayerBeads);
            Ununderline(lbPrayerTime);
            Ununderline(lbQuran);

            loadform(new HomeScreen());

        }

       
        private void lbPrayerTime_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(lbPrayerTime, true);
            Ununderline(lbhome);
            Ununderline(lbDhikr);
            Ununderline(lbPrayerBeads);
            Ununderline(lbQuran);

            loadform(new PrayerTimeScreen());

        }

        private void lbDhikr_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(lbDhikr, true);
            Ununderline(lbhome);
            Ununderline(lbPrayerTime);
            Ununderline(lbPrayerBeads);
            Ununderline(lbQuran);

            loadform(new DhikrScreen());
        }

        private void lbPrayerBeads_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(lbPrayerBeads, true);
            Ununderline(lbhome);
            Ununderline(lbPrayerTime);
            Ununderline(lbDhikr);
            Ununderline(lbQuran);

            loadform(new PrayerBeadsScreen());
        }

        private void lbQuran_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(lbQuran, true);
            Ununderline(lbhome);
            Ununderline(lbPrayerTime);
            Ununderline(lbDhikr);
            Ununderline(lbPrayerBeads);

            loadform(new QuranScreen());
        }

        
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

