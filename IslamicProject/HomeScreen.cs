using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IslamicProject
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
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

    }
}
