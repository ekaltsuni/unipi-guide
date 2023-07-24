﻿using System;
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

        private void σχετικάΜεΕμάςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ο παρών οδηγός για το Πανεπιστήμιο Πειραιά δημιουργήθηκε από τις φοιτήτριες Καλτσούνη Ελένη (ΜΠΠΛ 2218) και Καούνη Μαρία (ΜΠΠΛ 2219) του τμήματος ΠΜΣ Πληροφορικής στα πλαίσια της απαλλάκτικής εργασίας  για το μάθημα Ταχεία Ανάπτυξη Εφαρμογών (εαρινό εξάμηνο, 2023).\r\n\r\nΣτόχος του οδηγού είναι να προσομειώσει μια οθόνη αφής που θα μπορούσε να βρίσκεται στην είσοδο του πανεπιστημίου και η οποία θα μπορέσει να αποτελέσει πηγή πληροφοριών για εγγεγραμμένους φοιτητές και επισκέπτες του πανεπιστημίου. \r\n\r\nΜεταξύ άλλων η εφαρμογή  παρουσιάζει βασικές πληροφορίες του πανεπιστημίου, τις υπηρεσίες που διαθέτει, τις σχολές και τα τμήματα.");

        }
        /* Κριτικες form menu redirects to other pages */

        private void τοΠανεπιστήμιοStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form toPanepistimio_from_homepage = new toPanepistimio_form();
            toPanepistimio_from_homepage.ShowDialog();
            this.Close();
        }

        private void αρχικήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form arxiki_from_kritikes = new homepage_form();
            arxiki_from_kritikes.ShowDialog();
            this.Close();
        }
        private void διδάσκοντεςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form didaskontes_form_from_kritikes = new Didaskontes_form();
            didaskontes_form_from_kritikes.ShowDialog();
            this.Close();
        }
        private void login_button_homepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login_form_from_kritikes = new login_form();
            login_form_from_kritikes.ShowDialog();
            this.Close();
        }

        private void έξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mute_image_Click(object sender, EventArgs e)
        {
            /* Calls the mute_image_Click method of homepage_form to stop the player */
            homepage_form form1 = Application.OpenForms.OfType<homepage_form>().FirstOrDefault();
            form1?.mute_image_Click(sender, e);
        }

        private void Kritikes_form_Load(object sender, EventArgs e)
        {
            /* Create object connection to database */
            connection = new SQLiteConnection(connectionToStudent);
            connection.Open();
            String selectSQL = "Select * from Student where review is not null";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                kritikes_richTextBox.AppendText(reader.GetString(6) + " \n" + reader.GetString(3));
                kritikes_richTextBox.AppendText(Environment.NewLine);
                kritikes_richTextBox.AppendText("-------------------------------------------------------------------------------------------");
                kritikes_richTextBox.AppendText(Environment.NewLine);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
        }

        private void leaveNewReview_button_Click(object sender, EventArgs e)
        {
            String name = name_richTextBox.Text;
            String review = newReview_richTextBox.Text;
            connection = new SQLiteConnection(connectionToStudent);
            connection.Open();
            String insertSQL = "Insert into Reviews values(@Name,@Review)";
            SQLiteCommand command = new SQLiteCommand(insertSQL, connection);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Review", review);
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Η κριτική σας αποθηκεύτηκε επιτυχώς.");
            }
            else
            {
                MessageBox.Show("Παρακαλώ προσπαθήστε ξανά.");
            }
            command.Dispose();
            connection.Close();
        }
    }
}
