﻿using System;
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
    public partial class DhikrAfterMorning : Form
    {
        public DhikrAfterMorning()
        {
            InitializeComponent();
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
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
