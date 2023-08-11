using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static unipi_guide.Program;

namespace unipi_guide
{
    public partial class Kritikes_form : Form
    {
        /* Initialize connection to database */
        String connectionToStudent = "Data source=unipi-guide.db; Version=3";
        SQLiteConnection connection;
        public Kritikes_form()
        {
            InitializeComponent();
            /* Form behavior when user is logged in */
            if (userStatus.registeredUser == true)
            {
                ΠληροφορικήtoolStripMenuItem.Visible = true;
                ΕκδηλώσειςtoolStripMenuItem.Visible = true;
                login_button_homepage.Visible = false;
                unregistered_label.Visible = false;
                leaveNewReview_button.Visible = true;
                leaveReview_label.Visible = true;
                newReview_richTextBox.Visible = true;
                name_label.Visible = true;
                name_richTextBox.Visible = true;
            }
        }

        private void Kritikes_form_Load(object sender, EventArgs e)
        {
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

            /* Create object connection to database */
            connection = new SQLiteConnection(connectionToStudent);
            connection.Open();
            String selectSQL = "Select * from Reviews where Review is not null";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                kritikes_richTextBox.AppendText(reader.GetString(1) + ", \n" + reader.GetString(0));
                kritikes_richTextBox.AppendText(Environment.NewLine);
                kritikes_richTextBox.AppendText("☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸\r\n");
                kritikes_richTextBox.AppendText(Environment.NewLine);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
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

        private void leaveNewReview_button_Click(object sender, EventArgs e)
        {
            /*Adds a review to the table Reviews*/
            string Name = name_richTextBox.Text;
            string Review = newReview_richTextBox.Text;
            if (Name != "" && Review != "")
            {
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(connectionToStudent))
                    {
                        connection.Open();
                        string insertSQL = "INSERT INTO Reviews (Name, Review) VALUES (@Name, @Review)";
                        using (SQLiteCommand command = new SQLiteCommand(insertSQL, connection))
                        {
                            command.Parameters.AddWithValue("@Name", Name);
                            command.Parameters.AddWithValue("@Review", Review);
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Η κριτική σας αποθηκεύτηκε επιτυχώς.");
                            }
                            else
                            {
                                MessageBox.Show("Παρακαλώ προσπαθήστε ξανά.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε όλα τα πεδία.");
            }
        }

        private void σχετικάΜεΕμάςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ο παρών οδηγός για το Πανεπιστήμιο Πειραιά δημιουργήθηκε από τις φοιτήτριες Καλτσούνη Ελένη (ΜΠΠΛ 2218) και Καούνη Μαρία (ΜΠΠΛ 2219) του τμήματος ΠΜΣ Πληροφορικής στα πλαίσια της απαλλάκτικής εργασίας  για το μάθημα Ταχεία Ανάπτυξη Εφαρμογών (εαρινό εξάμηνο, 2023).\r\n\r\nΣτόχος του οδηγού είναι να προσομειώσει μια οθόνη αφής που θα μπορούσε να βρίσκεται στην είσοδο του πανεπιστημίου και η οποία θα μπορέσει να αποτελέσει πηγή πληροφοριών για εγγεγραμμένους φοιτητές και επισκέπτες του πανεπιστημίου. \r\n\r\nΜεταξύ άλλων η εφαρμογή  παρουσιάζει βασικές πληροφορίες του πανεπιστημίου, τις υπηρεσίες που διαθέτει, τις σχολές και τα τμήματα.");

        }
        /* Κριτικες form menu redirects to other pages */

        private void τοΠανεπιστήμιοStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form toPanepistimio = new toPanepistimio_form();
            toPanepistimio.ShowDialog();
            this.Close();
        }

        private void αρχικήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form homepage = new homepage_form();
            homepage.ShowDialog();
            this.Close();
        }
        private void διδάσκοντεςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form didaskontes = new Didaskontes_form();
            didaskontes.ShowDialog();
            this.Close();
        }
        private void login_button_homepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new login_form();
            login.ShowDialog();
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

        private void έξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

