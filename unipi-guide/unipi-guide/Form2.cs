using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unipi_guide
{
    public partial class about_us_form : Form
    {
        public about_us_form()
        {
            InitializeComponent();
        }

        /* About us menu redirects to other pages */
        private void πίσωToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form homepage_from_about_us = new homepage_form();
            homepage_from_about_us.ShowDialog();
            this.Close();
        }

        private void έξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
