using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemNetUI
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void masterPaketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Master Komputer");
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Master Paket");
        }

        private void masterMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Master Member");
        }

        private void masterKodePotonganHargaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Master Kode Potongan Harga");
        }
    }
}
