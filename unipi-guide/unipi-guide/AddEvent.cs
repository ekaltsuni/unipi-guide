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
using System.Xml.Linq;
using static unipi_guide.Program;

namespace unipi_guide
{
    public partial class AddEvent : Form
    {
        String connectionToStudent = "Data source=unipi-guide.db; Version=3";
        SQLiteConnection connection;
        public AddEvent()
        {
            InitializeComponent();
        }

        private void AddEvent_Load(object sender, EventArgs e)
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
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            string Date = monthCalendar1.SelectionRange.Start.ToShortDateString();
            date_richTextBox.Text = Date;
        }

        private void play_music_image_Click(object sender, EventArgs e)
        {
            Music.musicStatus = true;
            checkMusic(play_music_image, mute_image);
        }

        private void mute_image_Click(object sender, EventArgs e)
        {
            Music.musicStatus = false;
            checkMusic(play_music_image, mute_image);
        }

        private void addEvent_button_Click(object sender, EventArgs e)
        {
            string date = date_richTextBox.Text;
            string _event = event_richTextBox.Text;
            if (date != "" && _event != "")
            {
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(connectionToStudent))
                    {
                        connection.Open();
                        string insertSQL = "INSERT INTO EVENTS (Date, Event) VALUES (@Date, @Event)";
                        using (SQLiteCommand command = new SQLiteCommand(insertSQL, connection))
                        {
                            command.Parameters.AddWithValue("@Date", date);
                            command.Parameters.AddWithValue("@Event", _event);
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Η εκδήλωση αποθηκεύτηκε επιτυχώς.");
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

        private void αρχικήStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form homepage = new homepage_form();
            homepage.ShowDialog();
            this.Close();
        }

        private void έξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void event_richTextBox_Click(object sender, EventArgs e)
        {
            event_richTextBox.Clear();
            event_richTextBox.ForeColor = System.Drawing.Color.Black;
        }
    }
}
