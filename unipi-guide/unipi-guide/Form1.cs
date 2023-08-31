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
        /* Initialize speech synthesis */
        SpeechSynthesizer engine = new SpeechSynthesizer();

        public homepage_form()
        {
            InitializeComponent();
            homepage_menu.Width = 1009;
            /* Form behavior when user is logged in */
            if (userStatus.registeredUser == true)
            {
                ΠληροφορικήtoolStripMenuItem.Visible = true;
                ΕκδηλώσειςtoolStripMenuItem.Visible = true;
                login_button_homepage.Visible = false;
                logout_button.Visible = true;
            }

            /* Voice synth controls' initialization */
            voice_mute_image.Visible = false;
            voice_sound_image.Visible = true;

        }

        /* Check music status on form load */
        private void homepage_form_Load(object sender, EventArgs e)
        {
            if (Music.musicStatus == false)
            {
                checkMusic(play_music_image, mute_image);
            }
            else
            {
                mute_image.Visible = true;
                play_music_image.Visible = false;
            }
        }

        /* Stop music on mute image click */
        public void mute_image_Click(object sender, EventArgs e)
        {
            Music.musicStatus = false;
            checkMusic(play_music_image, mute_image);
        }

        /* Play music on mute image click */
        private void play_music_image_Click(object sender, EventArgs e)
        {
            Music.musicStatus = true;
            checkMusic(play_music_image, mute_image);
        }

        /* Synthesize voice and stop music while doing so if it's on */
        private void voice_sound_image_Click(object sender, EventArgs e)
        {
            engine.SelectVoice("Microsoft Stefanos");
            engine.SpeakAsync(minima_proedrou_richTextBox.Text);
            voice_mute_image.Visible = true;
            voice_sound_image.Visible = false;
            Music.musicStatus = false;
            checkMusic(play_music_image, mute_image);
        }

        /* Stop voice speech on mute button click */
        private void voice_mute_image_Click(object sender, EventArgs e)
        {
            engine.SpeakAsyncCancelAll();
            voice_mute_image.Visible = false;
            voice_sound_image.Visible = true;
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
            engine.SpeakAsyncCancelAll();
            voice_mute_image.Visible = false;
            voice_sound_image.Visible = true;
            MessageBox.Show("Ο παρών οδηγός για το Πανεπιστήμιο Πειραιά δημιουργήθηκε από τις φοιτήτριες Καλτσούνη Ελένη (ΜΠΠΛ 2218) και Καούνη Μαρία (ΜΠΠΛ 2219) του τμήματος ΠΜΣ Πληροφορικής στα πλαίσια της απαλλάκτικής εργασίας  για το μάθημα Ταχεία Ανάπτυξη Εφαρμογών (εαρινό εξάμηνο, 2023).\r\n\r\nΣτόχος του οδηγού είναι να προσομειώσει μια οθόνη αφής που θα μπορούσε να βρίσκεται στην είσοδο του πανεπιστημίου και η οποία θα μπορέσει να αποτελέσει πηγή πληροφοριών για εγγεγραμμένους φοιτητές και επισκέπτες του πανεπιστημίου. \r\n\r\nΜεταξύ άλλων η εφαρμογή  παρουσιάζει βασικές πληροφορίες του πανεπιστημίου, τις υπηρεσίες που διαθέτει, τις σχολές και τα τμήματα.");
        }

        private void τοΠανεπιστήμιοToolStripMenuItem_Click(object sender, EventArgs e)
        {
            engine.SpeakAsyncCancelAll();
            this.Hide();
            Form toPanepistimio = new toPanepistimio_form();
            toPanepistimio.ShowDialog();
            this.Close();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            engine.SpeakAsyncCancelAll();
            this.Hide();
            Form login = new login_form();
            login.ShowDialog();
            this.Close();
        }

        private void διδάσκοντεςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            engine.SpeakAsyncCancelAll();
            this.Hide();
            Form didaskontes = new Didaskontes_form();
            didaskontes.ShowDialog();
            this.Close();
        }

        private void κριτικέςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            engine.SpeakAsyncCancelAll();
            this.Hide();
            Form kritikes = new Kritikes_form();
            kritikes.ShowDialog();
            this.Close();
        }

        private void ΕκδηλώσειςtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            engine.SpeakAsyncCancelAll();
            this.Hide();
            Form calendar = new calendar_form();
            calendar.ShowDialog();
            this.Close();
        }

        private void τοΤμήμαΠληροφορικήςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            engine.SpeakAsyncCancelAll();
            this.Hide();
            Form pliroforiki = new Pliroforiki_form();
            pliroforiki.ShowDialog();
            this.Close();
        }

        private void οικονομικώνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            engine.SpeakAsyncCancelAll();
        }

        private void ναυτιλίαςΚαιΒιομηχανίαςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            engine.SpeakAsyncCancelAll();
        }

        private void χρηματοοικονομικήςΚαιΣτατιστικήςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            engine.SpeakAsyncCancelAll();
            this.Hide();
            Form StatisticsSchoolForm = new StatisticsSchoolForm();
            StatisticsSchoolForm.ShowDialog();
            this.Close();
        }

        private void τεχνολογιώνΠληροφορικήςΚαιΕπικοινωνιώνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            engine.SpeakAsyncCancelAll();
            this.Hide();
            Form CS_School_Form = new CS_School_Form();
            CS_School_Form.ShowDialog();
            this.Close();
        }

        private void προπτυχιακάToolStripMenuItem_Click(object sender, EventArgs e)
        {
            engine.SpeakAsyncCancelAll();
            this.Hide();
            Form undergraduate = new Undergraduate();
            undergraduate.ShowDialog();
            this.Close();
        }

        private void μεταπτυχιακάToolStripMenuItem_Click(object sender, EventArgs e)
        {
            engine.SpeakAsyncCancelAll();
            this.Hide();
            Form postgraduate = new Postgraduate();
            postgraduate.ShowDialog();
            this.Close();
        }

        private void sxoles1_homepage_button_Click(object sender, EventArgs e)
        {
            engine.SpeakAsyncCancelAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            engine.SpeakAsyncCancelAll();
            this.Hide();
            Form StatisticsSchoolForm = new StatisticsSchoolForm();
            StatisticsSchoolForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            engine.SpeakAsyncCancelAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            engine.SpeakAsyncCancelAll();
            this.Hide();
            Form CS_School_Form = new CS_School_Form();
            CS_School_Form.ShowDialog();
            this.Close();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            engine.SpeakAsyncCancelAll();
            this.Hide();
            userStatus.registeredUser = false;
            Form homepage = new homepage_form();
            homepage.ShowDialog();
            this.Close();
        }
    }
}
