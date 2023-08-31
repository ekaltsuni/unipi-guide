using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static unipi_guide.Program;

namespace unipi_guide
{
    public partial class Postgraduate : Form
    {
        public Postgraduate()
        {
            InitializeComponent();
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

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            userStatus.registeredUser = false;
            Form homepage = new homepage_form();
            homepage.ShowDialog();
            this.Close();
        }

        private void αρχικήStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form homepage = new homepage_form();
            homepage.ShowDialog();
            this.Close();
        }

        private void τοΠανεπιστήμιοToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form toPanepistimio = new toPanepistimio_form();
            toPanepistimio.ShowDialog();
            this.Close();
        }

        private void ΠληροφορικήtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            //To be erased!!!!
        }

        private void τοΤμήμαΠληροφορικήςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form pliroforiki = new Pliroforiki_form();
            pliroforiki.ShowDialog();
            this.Close();
        }

        private void προπτυχιακάToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form undergraduate = new Undergraduate();
            undergraduate.ShowDialog();
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

        private void διδάσκοντεςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form didaskontes = new Didaskontes_form();
            didaskontes.ShowDialog();
            this.Close();
        }

        private void σχετικάΜεΕμάςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ο παρών οδηγός για το Πανεπιστήμιο Πειραιά δημιουργήθηκε από τις φοιτήτριες Καλτσούνη Ελένη (ΜΠΠΛ 2218) και Καούνη Μαρία (ΜΠΠΛ 2219) του τμήματος ΠΜΣ Πληροφορικής στα πλαίσια της απαλλάκτικής εργασίας  για το μάθημα Ταχεία Ανάπτυξη Εφαρμογών (εαρινό εξάμηνο, 2023).\r\n\r\nΣτόχος του οδηγού είναι να προσομειώσει μια οθόνη αφής που θα μπορούσε να βρίσκεται στην είσοδο του πανεπιστημίου και η οποία θα μπορέσει να αποτελέσει πηγή πληροφοριών για εγγεγραμμένους φοιτητές και επισκέπτες του πανεπιστημίου. \r\n\r\nΜεταξύ άλλων η εφαρμογή  παρουσιάζει βασικές πληροφορίες του πανεπιστημίου, τις υπηρεσίες που διαθέτει, τις σχολές και τα τμήματα.");
        }

        private void έξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void τεχνολογιώνΠληροφορικήςΚαιΕπικοινωνιώνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form CS_School_Form = new CS_School_Form();
            CS_School_Form.ShowDialog();
            this.Close();
        }

        private void χρηματοοικονομικήςΚαιΣτατιστικήςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form StatisticsSchoolForm = new StatisticsSchoolForm();
            StatisticsSchoolForm.ShowDialog();
            this.Close();
        }
    }
}
