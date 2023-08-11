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
    public partial class login_form : Form
    {
        /* Initialize connection to database */
        String connectionToStudent = "Data source=unipi-guide.db; Version=3";
        SQLiteConnection connection;

        public login_form()
        {
            InitializeComponent();
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            /* Create object connection to database */
            connection = new SQLiteConnection(connectionToStudent);

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

        private void login_button_Click(object sender, EventArgs e)
        {   
            /* Open connection to database */
            connection.Open();
            String username = usernameTextBox.Text;
            String password = passwordTextBox.Text;
            /* Run query to get username and password that matches user's input */
            String selectSQL = "Select * from Student where am=@am and password=@password";
            /* Read query */
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            command.Parameters.AddWithValue("@am", username);
            command.Parameters.AddWithValue("@password", password);
            /* Store query's return value */
            SQLiteDataReader reader = command.ExecuteReader();

            /* If username and password is found, show student homepage. 
             * Otherwise, prompt user to try again. */
            if (reader.Read())
            {
                reader.Close();
                command.Dispose();
                connection.Close();
                this.Hide();
                userStatus.registeredUser = true;
                Form homepage = new homepage_form();
                homepage.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid login details. Please try again.");
                reader.Close();
                command.Dispose();
                connection.Close();
            }
        }

        private void έξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /* Login page menu redirects to other pages */
        private void σχετικάΜεΕμάςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ο παρών οδηγός για το Πανεπιστήμιο Πειραιά δημιουργήθηκε από τις φοιτήτριες Καλτσούνη Ελένη (ΜΠΠΛ 2218) και Καούνη Μαρία (ΜΠΠΛ 2219) του τμήματος ΠΜΣ Πληροφορικής στα πλαίσια της απαλλάκτικής εργασίας  για το μάθημα Ταχεία Ανάπτυξη Εφαρμογών (εαρινό εξάμηνο, 2023).\r\n\r\nΣτόχος του οδηγού είναι να προσομειώσει μια οθόνη αφής που θα μπορούσε να βρίσκεται στην είσοδο του πανεπιστημίου και η οποία θα μπορέσει να αποτελέσει πηγή πληροφοριών για εγγεγραμμένους φοιτητές και επισκέπτες του πανεπιστημίου. \r\n\r\nΜεταξύ άλλων η εφαρμογή  παρουσιάζει βασικές πληροφορίες του πανεπιστημίου, τις υπηρεσίες που διαθέτει, τις σχολές και τα τμήματα.");
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
    }
}
