﻿using System;
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
    public partial class login_form : Form
    {
        /* Initialize connection to database */
        String connectionToStudent = "Data source=unipi-guide.db; Version=3";
        SQLiteConnection connection;
        public login_form()
        {
            InitializeComponent();
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
            Form arxiki_from_login = new homepage_form();
            arxiki_from_login.ShowDialog();
            this.Close();
        }

        private void τοΠανεπιστήμιοToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form toPanepistimio_from_login = new toPanepistimio_form();
            toPanepistimio_from_login.ShowDialog();
            this.Close();
        }

        private void mute_image_Click(object sender, EventArgs e)
        {
            /* Calls the mute_image_Click method of homepage_form to stop the player */
            homepage_form form1 = Application.OpenForms.OfType<homepage_form>().FirstOrDefault();
            form1?.mute_image_Click(sender, e);
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            /* Create object connection to database */
            connection = new SQLiteConnection(connectionToStudent);
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
                this.Hide();
                Form homepage = new homepage_form();
                homepage.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid login details. Please try again.");
            }

            reader.Close();
            command.Dispose();
            connection.Close();
        }
    }
}