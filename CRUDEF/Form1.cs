using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDEF
{
    public partial class Form1 : Form
    {
        TokoEntities db = new TokoEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            barangBindingSource.DataSource = db.Barang.ToList();
            formBindingSource.Clear();
            formBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dataYangDipilih = barangBindingSource.Current as Barang;
            MessageBox.Show(dataYangDipilih.Nama);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (formBindingSource.Current is Barang barang)
            {
                db.Barang.AddOrUpdate(barang);
                db.SaveChanges();
                OnLoad(EventArgs.Empty);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formBindingSource.Clear();
            formBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (barangDataGridView.SelectedRows[0].DataBoundItem is Barang barang)
            {
                formBindingSource.DataSource = db.Barang.AsNoTracking().First(brg => brg.ID == barang.ID);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (barangDataGridView.SelectedRows[0].DataBoundItem is Barang barang)
            {
                db.Barang.Remove(barang);
                db.SaveChanges();
                OnLoad(EventArgs.Empty);
            }
        }
    }
}
