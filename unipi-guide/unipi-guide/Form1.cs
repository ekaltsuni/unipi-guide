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
using System.Speech.Synthesis;


namespace unipi_guide
{
    public partial class homepage_form : Form
    {
        /* Initialize sound player */
        SoundPlayer player = new SoundPlayer("sound\\guitar_loop.wav");
        /* Initialize speech synthesizer */
        SpeechSynthesizer engine = new SpeechSynthesizer();
        public homepage_form()
        {
            InitializeComponent();
        }

        private void homepage_form_Load(object sender, EventArgs e)
        {
            player.PlayLooping();
        }

        private void mute_image_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void voice_sound_image_Click(object sender, EventArgs e)
        {
            if (minima_proedrou_richTextBox.Text != "")
            {
                engine.SelectVoice("Microsoft Stefanos");
                engine.SpeakAsync(minima_proedrou_richTextBox.Text);
            }
        }
    }
}
