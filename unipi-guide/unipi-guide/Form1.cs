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
using static unipi_guide.Program;


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
            ΕκδηλώσειςtoolStripMenuItem.Visible = true;
            /* Form behavior when user is logged in */
            if (userStatus.registeredUser == true)
            {
                ΠληροφορικήtoolStripMenuItem.Visible = true;
                ΕκδηλώσειςtoolStripMenuItem.Visible = true;
                login_button_homepage.Visible = false;
            }
            
        }
        /* Play sound on form load */
        private void homepage_form_Load(object sender, EventArgs e)
        {
            player.PlayLooping();


        }
        /* Stop sound on mute image click */
        public void mute_image_Click(object sender, EventArgs e)
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
            MessageBox.Show("Ο παρών οδηγός για το Πανεπιστήμιο Πειραιά δημιουργήθηκε από τις φοιτήτριες Καλτσούνη Ελένη (ΜΠΠΛ 2218) και Καούνη Μαρία (ΜΠΠΛ 2219) του τμήματος ΠΜΣ Πληροφορικής στα πλαίσια της απαλλάκτικής εργασίας  για το μάθημα Ταχεία Ανάπτυξη Εφαρμογών (εαρινό εξάμηνο, 2023).\r\n\r\nΣτόχος του οδηγού είναι να προσομειώσει μια οθόνη αφής που θα μπορούσε να βρίσκεται στην είσοδο του πανεπιστημίου και η οποία θα μπορέσει να αποτελέσει πηγή πληροφοριών για εγγεγραμμένους φοιτητές και επισκέπτες του πανεπιστημίου. \r\n\r\nΜεταξύ άλλων η εφαρμογή  παρουσιάζει βασικές πληροφορίες του πανεπιστημίου, τις υπηρεσίες που διαθέτει, τις σχολές και τα τμήματα.");
        }

        private void τοΠανεπιστήμιοToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form toPanepistimio_from_homepage = new toPanepistimio_form();
            toPanepistimio_from_homepage.ShowDialog();
            this.Close();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login_form_from_homepage = new login_form();
            login_form_from_homepage.ShowDialog();
            this.Close();
        }

        private void διδάσκοντεςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form didaskontes_form_from_homepage = new Didaskontes_form();
            didaskontes_form_from_homepage.ShowDialog();
            this.Close();
        }

        private void κριτικέςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form kritikes_form_from_homepage = new Kritikes_form();
            kritikes_form_from_homepage.ShowDialog();
            this.Close();
        }

        private void ΕκδηλώσειςtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form calendar_form_from_homepage = new calendar_form();
            calendar_form_from_homepage.ShowDialog();
            this.Close();
        }

        private void τοΤμήμαΠληροφορικήςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form pliroforiki_form_from_homepage = new Pliroforiki_form();
            pliroforiki_form_from_homepage.ShowDialog();
            this.Close();
        }
    }
}
