using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unipi_guide
{
    public partial class calendar_form : Form
    {
        String connectionToStudent = "Data source=unipi-guide.db; Version=3";
        SQLiteConnection connection;
        public calendar_form()
        {
            InitializeComponent();
            /* Form behavior when user is logged in */
            /* No need to check the user since we are on didaskontes page */
            ΠληροφορικήtoolStripMenuItem.Visible = true;
            ΕκδηλώσειςtoolStripMenuItem.Visible = true;
        }

        private void mute_image_Click(object sender, EventArgs e)
        {
            /* Calls the mute_image_Click method of homepage_form to stop the player */
            homepage_form form1 = Application.OpenForms.OfType<homepage_form>().FirstOrDefault();
            form1?.mute_image_Click(sender, e);
        }

        private void αρχικήStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form arxiki_from_didaskontes = new homepage_form();
            arxiki_from_didaskontes.ShowDialog();
            this.Close();
        }

        private void τοΠανεπιστήμιοToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form toPanepistimio_from_didaskontes = new toPanepistimio_form();
            toPanepistimio_from_didaskontes.ShowDialog();
            this.Close();
        }

        private void σχετικάΜεΕμάςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ο παρών οδηγός για το Πανεπιστήμιο Πειραιά δημιουργήθηκε από τις φοιτήτριες Καλτσούνη Ελένη (ΜΠΠΛ 2218) και Καούνη Μαρία (ΜΠΠΛ 2219) του τμήματος ΠΜΣ Πληροφορικής στα πλαίσια της απαλλάκτικής εργασίας  για το μάθημα Ταχεία Ανάπτυξη Εφαρμογών (εαρινό εξάμηνο, 2023).\r\n\r\nΣτόχος του οδηγού είναι να προσομειώσει μια οθόνη αφής που θα μπορούσε να βρίσκεται στην είσοδο του πανεπιστημίου και η οποία θα μπορέσει να αποτελέσει πηγή πληροφοριών για εγγεγραμμένους φοιτητές και επισκέπτες του πανεπιστημίου. \r\n\r\nΜεταξύ άλλων η εφαρμογή  παρουσιάζει βασικές πληροφορίες του πανεπιστημίου, τις υπηρεσίες που διαθέτει, τις σχολές και τα τμήματα.");
        }

        private void κριτικέςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form kritikes_form_from_uni = new Kritikes_form();
            kritikes_form_from_uni.ShowDialog();
            this.Close();
        }

        private void διδάσκοντεςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form didaskontes_form_from_toPanepistimio = new Didaskontes_form();
            didaskontes_form_from_toPanepistimio.ShowDialog();
            this.Close();
        }

        private void έξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void τοΤμήμαΠληροφορικήςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form pliroforiki_form_from_calendar_form = new Pliroforiki_form();
            pliroforiki_form_from_calendar_form.ShowDialog();
            this.Close();

        }

        private void calendar_form_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            string Date = monthCalendar1.SelectionRange.Start.ToShortDateString();
            events_richTextBox.Clear();
            connection = new SQLiteConnection(connectionToStudent);
            connection.Open();
            try
            {
                String selectSQL = "Select * from Events where Date=@Date";
                SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
                command.Parameters.AddWithValue("@Date", Date);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    events_richTextBox.AppendText((string)reader.GetString(0) + " \n" + (string)reader.GetString(1));
                    events_richTextBox.AppendText(Environment.NewLine);
                    events_richTextBox.AppendText("☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸\r\n");
                    events_richTextBox.AppendText(Environment.NewLine);
                }
                reader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void events_button_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            /* Create object connection to database */
            connection = new SQLiteConnection(connectionToStudent);
            connection.Open();
            try
            {
                String selectSQL = "Select * from Events where Date is not null";
                SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    events_richTextBox.AppendText((string)reader.GetString(0) + " \n" + (string)reader.GetString(1));
                    events_richTextBox.AppendText(Environment.NewLine);
                    events_richTextBox.AppendText("☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸\r\n");
                    events_richTextBox.AppendText(Environment.NewLine);
                }
                reader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
