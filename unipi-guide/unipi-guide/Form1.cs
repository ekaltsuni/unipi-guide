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
        /* Play sound on form load */
        private void homepage_form_Load(object sender, EventArgs e)
        {
            player.PlayLooping();
        }
        /* Stop sound on mute image click */
        private void mute_image_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        /* Synthesize voice */
        private void voice_sound_image_Click(object sender, EventArgs e)
        {
            if (minima_proedrou_richTextBox.Text != "")
            {
                engine.SelectVoice("Microsoft Stefanos");
                engine.SpeakAsync(minima_proedrou_richTextBox.Text);
            }
        }

        /* Counter for image list slideshow loop */
        int image_number = 0;
        private void slideshow_timer_Tick(object sender, EventArgs e)
        {
            /* Slideshow picture box will show images of the image list based on array position */
            slideshow_homepage_image.Image = slideshow_images.Images[image_number];
            /* Loop through the image list array 
             If counter reaches the position of the last image, set back to 0 to restart
             else increment the image number */
            if (image_number == slideshow_images.Images.Count - 1)
            {
                image_number = 0;
            }
            else
            {
                image_number++;
            }
        }
 
        private void έξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /* Homepage menu redirects to other pages */
        private void σχετικάΜεΕμάςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form about_us_from_homepage = new about_us_form();
            about_us_from_homepage.ShowDialog();
            this.Close();
        }

        private void τοΠανεπιστήμιοToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form toPanepistimio_from_homepage = new toPanepistimio_form();
            toPanepistimio_from_homepage.ShowDialog();
            this.Close();
        }
    }
}
