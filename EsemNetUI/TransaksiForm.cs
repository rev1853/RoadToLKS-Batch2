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
    public partial class MasterTransaksiForm : Form
    {
        public MasterTransaksiForm()
        {
            InitializeComponent();
        }

        private void MasterKomputerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TambahTransaksiForm().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new DetailTransaksiForm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TambahDurasi().ShowDialog();
        }
    }
}
