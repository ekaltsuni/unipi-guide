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
            this.Hide();
            Form about_us_from_toPanepistimio = new about_us_form();
            about_us_from_toPanepistimio.ShowDialog();
            this.Close();
        }
    }
}
