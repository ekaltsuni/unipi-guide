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

namespace unipi_guide
{
    public partial class toPanepistimio_form : Form
    {
        public toPanepistimio_form()
        {
            InitializeComponent();
        }

        private void έξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /* to Panepistimio menu redirects to other pages */
        private void σχετικάΜεΕμάςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ο παρών οδηγός για το Πανεπιστήμιο Πειραιά δημιουργήθηκε από τις φοιτήτριες Καλτσούνη Ελένη (ΜΠΠΛ 2218) και Καούνη Μαρία (ΜΠΠΛ 2219) του τμήματος ΠΜΣ Πληροφορικής στα πλαίσια της απαλλάκτικής εργασίας  για το μάθημα Ταχεία Ανάπτυξη Εφαρμογών (εαρινό εξάμηνο, 2023).\r\n\r\nΣτόχος του οδηγού είναι να προσομειώσει μια οθόνη αφής που θα μπορούσε να βρίσκεται στην είσοδο του πανεπιστημίου και η οποία θα μπορέσει να αποτελέσει πηγή πληροφοριών για εγγεγραμμένους φοιτητές και επισκέπτες του πανεπιστημίου. \r\n\r\nΜεταξύ άλλων η εφαρμογή  παρουσιάζει βασικές πληροφορίες του πανεπιστημίου, τις υπηρεσίες που διαθέτει, τις σχολές και τα τμήματα.");
        }

        private void πίσωToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form homepage_from_toPanepistimio = new homepage_form();
            homepage_from_toPanepistimio.ShowDialog();
            this.Close();
        }

        private void mute_image_Click(object sender, EventArgs e)
        {
            /* Calls the mute_image_Click method of homepage_form to stop the player */
            homepage_form form1 = Application.OpenForms.OfType<homepage_form>().FirstOrDefault();
            form1?.mute_image_Click(sender,e);
        }
    }
}
