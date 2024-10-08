using IslamicProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IslamicProject
{
    public partial class QuranScreen : Form
    {
        public QuranScreen()
        {
            InitializeComponent();
        }

        SoundPlayer soundPlayer = new SoundPlayer();
        private bool isPlaying = false;
        private string buttonPlayingName = string.Empty;
        
        private void StartStopSound(Button button,string SoundPath)
        {
            

            if (isPlaying && buttonPlayingName != button.Tag.ToString())
            {
                MessageBox.Show("The Sound is Already playing !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(button.Tag.ToString() == "Stop")
            {
                soundPlayer = new SoundPlayer(SoundPath);
                soundPlayer.Play();
                button.Tag = "Start";
                button.BackgroundImage = Resources.pause_circle;
                isPlaying = true;
                buttonPlayingName = button.Tag.ToString();
            }
            else
            {
                soundPlayer.Stop();
                button.Tag = "Stop";
                button.BackgroundImage = Resources.play_button;
                isPlaying = false;
                buttonPlayingName = string.Empty;
            }

        }
        private void btnAlFateha_Click(object sender, EventArgs e)
        {
            StartStopSound((Button)sender,@"C:\Users\ahmad\Downloads\Telegram Desktop\الفاتحة.wav");
        }

        private void btnAlMasad_Click(object sender, EventArgs e)
        {
            StartStopSound((Button)sender, @"C:\Users\ahmad\Downloads\Telegram Desktop\المسد.wav");
        }

        private void btnAlFalak_Click(object sender, EventArgs e)
        {
            StartStopSound((Button)sender, @"C:\Users\ahmad\Downloads\Telegram Desktop\الفلق.wav");
        }

        private void btnAlNasar_Click(object sender, EventArgs e)
        {
            StartStopSound((Button)sender, @"C:\Users\ahmad\Downloads\Telegram Desktop\النصر.wav");
        }

        private void btnAlNas_Click(object sender, EventArgs e)
        {
            StartStopSound((Button)sender, @"C:\Users\ahmad\Downloads\Telegram Desktop\الناس.wav");
        }

        private void btnAlEklas_Click(object sender, EventArgs e)
        {
            StartStopSound((Button)sender, @"C:\Users\ahmad\Downloads\Telegram Desktop\الاخلاص.wav");
        }

       

       
    }
}
