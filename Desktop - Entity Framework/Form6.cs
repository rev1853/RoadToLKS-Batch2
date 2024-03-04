using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop___Entity_Framework
{
    public partial class Form6 : Form
    {
        private Day1Entities db = new Day1Entities();
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // save data ke database
            // ambil data dari bindingsource yang ada di form dan simpan ke variable product
            if (bindingSource1.Current is Product product)
            {
                // override data expired date (bug date time picker)
                product.ExpiredDate = expiredDateDateTimePicker.Value;
                // simpan data ke database, jika data sudah ada maka update
                db.Product.AddOrUpdate(product);
                db.SaveChanges();
                // refresh data
                OnLoad(EventArgs.Empty);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // clear form
            // hapus data pada bindingsource yang ada di form 
            bindingSource1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // ambil data pada datagridview yang dipilih dan simpan ke variable product
                if (dataGridView1.SelectedRows[0].DataBoundItem is Product product)
                {
                    // hapus data dari context dan database
                    db.Product.Remove(product);
                    db.SaveChanges();
                    // refresh data
                    OnLoad(EventArgs.Empty);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ambil data yang dipilih dari data grid view dan simpan ke variable product
            if (dataGridView1.SelectedRows[0].DataBoundItem is Product product)
            {
                // duplikat data dari context sesuai dengan id pada variable product
                bindingSource1.DataSource = db.Product.AsNoTracking().First(f => f.ID == product.ID);
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // ambil semua data product
            bindingSource2.DataSource = db.Product.ToList();
            // tambahkan data kosong agar masuk ke mode create
            bindingSource1.AddNew();
        }
    }
}
