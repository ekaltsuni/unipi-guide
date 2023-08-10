using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static unipi_guide.Program;

namespace unipi_guide
{
    public partial class Didaskontes_form : Form
    {
        public Didaskontes_form()
        {
            InitializeComponent();
            /* Form behavior when user is logged in */
            /* No need to check the user since we are on didaskontes page */
            ΠληροφορικήtoolStripMenuItem.Visible = true;
            ΕκδηλώσειςtoolStripMenuItem.Visible = true;

            /* Voice synth initialization */
            SpeechPlay.engine.SpeakAsyncCancelAll();
        }

        /* Try to download contact details of unipi professors and handle exception if system error occurs */
        private void didaskontes_save_button_Click(object sender, EventArgs e)
        {
            saveFileDialogKathigites.InitialDirectory = Application.StartupPath + "\\textfiles";
            if (saveFileDialogKathigites.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    stoixeiaKathigitwnRichTextBox.SaveFile(saveFileDialogKathigites.FileName, RichTextBoxStreamType.PlainText);
                    MessageBox.Show("File saved at " + saveFileDialogKathigites.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("There's been an error in downloading this file.");
                }
            }
        }

        /* Try to download contact details of unipi professors and handle exception if system error occurs */
        private void didaskontes_download_icon_Click(object sender, EventArgs e)
        {
            saveFileDialogKathigites.InitialDirectory = Application.StartupPath + "\\textfiles";
            if (saveFileDialogKathigites.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    stoixeiaKathigitwnRichTextBox.SaveFile(saveFileDialogKathigites.FileName, RichTextBoxStreamType.PlainText);
                    MessageBox.Show("File saved at " + saveFileDialogKathigites.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("There's been an error in downloading this file.");
                }
            }
        }

        private void Didaskontes_form_Load(object sender, EventArgs e)
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

        private void mute_image_Click(object sender, EventArgs e)
        {
            Music.musicStatus = false;
            checkMusic(play_music_image, mute_image);
        }

        private void play_music_image_Click(object sender, EventArgs e)
        {
            Music.musicStatus = true;
            checkMusic(play_music_image, mute_image);
        }

        private void έξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /* Διδάσκοντες form menu redirects to other pages */

        private void αρχικήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form homepage = new homepage_form();
            homepage.ShowDialog();
            this.Close();
        }

        private void τοΠανεπιστήμιοStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form toPanepistimio = new toPanepistimio_form();
            toPanepistimio.ShowDialog();
            this.Close();
        }

        private void κριτικέςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form kritikes = new Kritikes_form();
            kritikes.ShowDialog();
            this.Close();
        }

        private void ΕκδηλώσειςtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form calendar = new calendar_form();
            calendar.ShowDialog();
            this.Close();
        }

        private void τοΤμήμαΠληροφορικήςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form pliroforiki = new Pliroforiki_form();
            pliroforiki.ShowDialog();
            this.Close();
        }
        private void σχετικάΜεΕμάςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ο παρών οδηγός για το Πανεπιστήμιο Πειραιά δημιουργήθηκε από τις φοιτήτριες Καλτσούνη Ελένη (ΜΠΠΛ 2218) και Καούνη Μαρία (ΜΠΠΛ 2219) του τμήματος ΠΜΣ Πληροφορικής στα πλαίσια της απαλλάκτικής εργασίας  για το μάθημα Ταχεία Ανάπτυξη Εφαρμογών (εαρινό εξάμηνο, 2023).\r\n\r\nΣτόχος του οδηγού είναι να προσομειώσει μια οθόνη αφής που θα μπορούσε να βρίσκεται στην είσοδο του πανεπιστημίου και η οποία θα μπορέσει να αποτελέσει πηγή πληροφοριών για εγγεγραμμένους φοιτητές και επισκέπτες του πανεπιστημίου. \r\n\r\nΜεταξύ άλλων η εφαρμογή  παρουσιάζει βασικές πληροφορίες του πανεπιστημίου, τις υπηρεσίες που διαθέτει, τις σχολές και τα τμήματα.");
        }
    }
}
