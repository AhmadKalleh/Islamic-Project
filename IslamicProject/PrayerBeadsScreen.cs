using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IslamicProject
{
    public partial class PrayerBeadsScreen : Form
    {
        public PrayerBeadsScreen()
        {
            InitializeComponent();
        }

        int IncreaseSobhanAlah = 0;
        int IncreaseAlhamdo = 0;
        int IncreaseLaElahElaAlah = 0;
        int IncreaseAlahAkbar = 0;
        int IncreaseSalatAlaAlNabe = 0;
        int IncreaseLaHawlWlaKoowaElaBelah = 0;
        int IncreaseAstagfarAlah = 0;
        int IncreaseRabeAgfarLe = 0;
        private void pbIncreaseSobhanAlah_Click(object sender, EventArgs e)
        {
            lbSobhanAlahCounter.Text = Convert.ToString(++IncreaseSobhanAlah); ;
        }

        private void pbResetSobhanAlahCounter_Click(object sender, EventArgs e)
        {
            lbSobhanAlahCounter.Text = "0";
        }

        private void pbIncreaseAlhamdoCounter_Click(object sender, EventArgs e)
        {
            lbAlhamdoCounter.Text = Convert.ToString(++IncreaseAlhamdo);
        }

        private void pbResetAlhamdoCounter_Click(object sender, EventArgs e)
        {
            lbAlhamdoCounter.Text = "0";
        }

        private void pbIncreaseLaElahElaAlahCounter_Click(object sender, EventArgs e)
        {
            lbLaElahElaAlahCounter.Text = Convert.ToString(++IncreaseLaElahElaAlah);
        }

        private void pbResetLaElahElaAlahCounter_Click(object sender, EventArgs e)
        {
            lbLaElahElaAlahCounter.Text = "0";
        }

        private void pbIncreaseAlahAkbarCounter_Click(object sender, EventArgs e)
        {
            lbAlahAkbarCounter.Text = Convert.ToString(++IncreaseAlahAkbar);
        }

        private void pbResetAlahAkbarCounter_Click(object sender, EventArgs e)
        {
            lbAlahAkbarCounter.Text = "0";
        }

        private void pbIncreaseSalatAlaAlNabeCounter_Click(object sender, EventArgs e)
        {
            lbSalatAlaAlNabeCounter.Text = Convert.ToString(++IncreaseSalatAlaAlNabe);
        }

        private void pbResetSalatAlaAlNabeCounter_Click(object sender, EventArgs e)
        {
            lbSalatAlaAlNabeCounter.Text = "0";
        }

        private void pbIncreaseLaHawlWlaKoowaElaBelahCounter_Click(object sender, EventArgs e)
        {
            lbLaHawlWlaKoowaElaBelahCounter.Text = Convert.ToString(++IncreaseLaHawlWlaKoowaElaBelah);
        }

        private void pbResetLaHawlWlaKoowaElaBelahCounter_Click(object sender, EventArgs e)
        {
            lbLaHawlWlaKoowaElaBelahCounter.Text = "0";
        }

        private void pbIncreaseAstagfarAlahCounter_Click(object sender, EventArgs e)
        {
            lbAstagfarAlahCounter.Text = Convert.ToString(++IncreaseAstagfarAlah);
        }

        private void pbResetAstagfarAlahCounter_Click(object sender, EventArgs e)
        {
            lbAstagfarAlahCounter.Text = "0";
        }

        private void pbIncreaseRabeAgfarLeCounter_Click(object sender, EventArgs e)
        {
            lbRabeAgfarLeCounter.Text = Convert.ToString(++IncreaseRabeAgfarLe);
        }

        private void pbResetRabeAgfarLeCounter_Click(object sender, EventArgs e)
        {
            lbRabeAgfarLeCounter.Text = "0";
        }

        private void PrayerBeadsScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
