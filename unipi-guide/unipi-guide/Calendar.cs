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
using static unipi_guide.Program;


namespace unipi_guide
{
    public partial class calendar_form : Form
    {
        String connectionToStudent = "Data source=unipi-guide.db; Version=3";
        SQLiteConnection connection;
        public calendar_form()
        {
            InitializeComponent();
            /* Form behavior when admin is logged in */
            if (userStatus.isAdmin == true) { 
                addEvent_button.Visible = true;
            }
        }

        private void calendar_form_Load(object sender, EventArgs e)
        {
            this.Width = 1046;
            this.Height = 703;
            LoadData();

            /* Check music status */
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
            events_richTextBox.Clear();
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

        private void σχετικάΜεΕμάςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ο παρών οδηγός για το Πανεπιστήμιο Πειραιά δημιουργήθηκε από τις φοιτήτριες Καλτσούνη Ελένη (ΜΠΠΛ 2218) και Καούνη Μαρία (ΜΠΠΛ 2219) του τμήματος ΠΜΣ Πληροφορικής στα πλαίσια της απαλλάκτικής εργασίας  για το μάθημα Ταχεία Ανάπτυξη Εφαρμογών (εαρινό εξάμηνο, 2023).\r\n\r\nΣτόχος του οδηγού είναι να προσομειώσει μια οθόνη αφής που θα μπορούσε να βρίσκεται στην είσοδο του πανεπιστημίου και η οποία θα μπορέσει να αποτελέσει πηγή πληροφοριών για εγγεγραμμένους φοιτητές και επισκέπτες του πανεπιστημίου. \r\n\r\nΜεταξύ άλλων η εφαρμογή  παρουσιάζει βασικές πληροφορίες του πανεπιστημίου, τις υπηρεσίες που διαθέτει, τις σχολές και τα τμήματα.");
        }

        private void κριτικέςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form kritikes = new Kritikes_form();
            kritikes.ShowDialog();
            this.Close();
        }

        private void διδάσκοντεςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form didaskontes = new Didaskontes_form();
            didaskontes.ShowDialog();
            this.Close();
        }

        private void έξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void τοΤμήμαΠληροφορικήςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form pliroforiki = new Pliroforiki_form();
            pliroforiki.ShowDialog();
            this.Close();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            userStatus.registeredUser = false;
            Form homepage = new homepage_form();
            homepage.ShowDialog();
            this.Close();
        }

        private void addEvent_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form addEvent = new AddEvent();
            addEvent.ShowDialog();
            this.Close();
        }

        private void προπτυχιακάToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form undergraduate = new Undergraduate();
            undergraduate.ShowDialog();
            this.Close();
        }

        private void μεταπτυχιακάToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form postgraduate = new Postgraduate();
            postgraduate.ShowDialog();
            this.Close();
        }
    }
}
