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

    
    public partial class DhikrScreen : Form
    {

       
        public DhikrScreen()
        {

            InitializeComponent();
            
        }

        private void btnDhikrAfterPrayer_Click(object sender, EventArgs e)
        {
            Form DhikrAfterPrayer = new DhikrAfterPrayer();
            DhikrAfterPrayer.Show();
        }

        private void btnDhikrEvening_Click(object sender, EventArgs e)
        {
            Form DhikrEvening = new DhikrEvening();
            DhikrEvening.Show();
        }

        private void btnDhikrAfterMorning_Click(object sender, EventArgs e)
        {
            Form DhikrAfterMorning = new DhikrAfterMorning();
            DhikrAfterMorning.Show();
        }

        private void btnDhikrToday_Click(object sender, EventArgs e)
        {
            Form DhikrToday = new DhikrSleep();
            DhikrToday.Show();
        }

        private void btnDhikrPrayer_Click(object sender, EventArgs e)
        {
            Form DhikrPrayer = new DhikrPrayer();
            DhikrPrayer.Show();
        }

        private void btnCompletingQuran_Click(object sender, EventArgs e)
        {
            Form CompletingQuran = new CompletingQuran();
            CompletingQuran.Show();
        }

        
    }
}
