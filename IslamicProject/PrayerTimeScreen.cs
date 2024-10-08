using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IslamicProject
{
    public partial class PrayerTimeScreen : Form
    {

       

        private DateTime CurrentTime = DateTime.Now;
        private DateTime AlFagerTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 4, 41, 0);
        private DateTime NoonTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 34, 0);
        private DateTime AlAsrTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 11, 0);
        private DateTime AlMagrabTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 59, 0);
        private DateTime AlEschaTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 20, 29, 0);
        private TimeSpan remmaningtime = new TimeSpan(0, 0, 0);

        public PrayerTimeScreen()
        {
            InitializeComponent();
            SetRoundedCornersToPicturs(pictureBox1, 30);
            
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

        private void PrayerTimeScreen_Load(object sender, EventArgs e)
        {           

            timer.Start();
            WhoseNext();
           
        }
      
        private void WhoseNext()
        {

           
            if(CurrentTime < AlFagerTime)
            {
                lbNextPrayer.Text = "الفجر";
                lbRemainng.Text = ": الوقت المتبقي لأذان الفجر";
                remmaningtime = AlFagerTime.Subtract(CurrentTime);          
            }

            else if(CurrentTime < NoonTime) 
            {
                lbNextPrayer.Text = "الظهر";
                lbRemainng.Text = ": الوقت المتبقي لأذان الظهر";
                remmaningtime = NoonTime.Subtract(CurrentTime);                
            }

            else if(CurrentTime < AlAsrTime)
            {
                lbNextPrayer.Text = "العصر";
                lbRemainng.Text = ": الوقت المتبقي لأذان العصر";
                remmaningtime = AlAsrTime.Subtract(CurrentTime);
            }

            else if(CurrentTime < AlMagrabTime)
            {
                lbNextPrayer.Text = "المغرب";
                lbRemainng.Text = ": الوقت المتبقي لأذان المغرب";
                remmaningtime = AlMagrabTime.Subtract(CurrentTime);
            }

            else if(CurrentTime < AlEschaTime)
            {
                lbNextPrayer.Text = "العشاء";
                lbRemainng.Text = ": الوقت المتبقي لأذان العشاء";
                remmaningtime = AlEschaTime.Subtract(CurrentTime);
            }
            else
            {
                lbNextPrayer.Text = "الفجر";
                lbRemainng.Text = ": الوقت المتبقي لأذان الفجر";
                DateTime alfager = AlFagerTime.AddDays(1);

                remmaningtime = alfager.Subtract(CurrentTime);

            }

            lbRemmaningTime.Text = remmaningtime.ToString(@"hh\:mm\:ss");
        }

        private void ShowNotify(string CurrentPrayer)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "صلاة" +" "+ CurrentPrayer;
            notifyIcon1.BalloonTipText = "حان وقت آذان صلاة"+" "+ CurrentPrayer;
            notifyIcon1.ShowBalloonTip(1000);

        }       
        private void timer_Tick(object sender, EventArgs e)
        {
            CurrentTime = CurrentTime.AddSeconds(1);
            lbCurrentTime.Text = CurrentTime.ToString("HH:mm:ss tt", CultureInfo.InvariantCulture);

            remmaningtime = remmaningtime.Subtract(new TimeSpan(0, 0, 1));

            lbRemmaningTime.Text = remmaningtime.ToString(@"hh\:mm\:ss");

            if (lbRemmaningTime.Text == "00:00:00")
            {
                string CurrentPrayer = lbNextPrayer.Text;
                WhoseNext();
                ShowNotify(CurrentPrayer);

            }
        }

        private void PrayerTimeScreen_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.Black;
            Pen pen = new Pen(color);

            pen.Width = 2;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Square;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Square;

            e.Graphics.DrawLine(pen, 600, 200, 1150, 200);
        }
    }
}
