using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework_P2
{
    public partial class Form2 : Form
    {
        BromoAirlinesEntities db = new BromoAirlinesEntities();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var admin = db.Akun.Find(Form1.id);
            label1.Text = label1.Text.Replace("$1", admin.Nama);

            tabelBindingSource.Clear();
            tabelBindingSource.DataSource = db.Bandara.ToList();

            negaraBindingSource.Clear();
            negaraBindingSource.DataSource = db.Negara.ToList();

            bandaraBindingSource.Clear();
            bandaraBindingSource.AddNew();
        }

        private void bandaraDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (bandaraDataGridView.Rows[e.RowIndex].DataBoundItem is Bandara bandara)
            {
                var negara = bandara.Negara ?? db.Negara.Find(bandara.NegaraID);

                if (e.ColumnIndex == dataGridViewTextBoxColumn10.Index)
                {
                    e.Value = negara.Nama;
                }

                if (e.ColumnIndex == ibukotaNegaraColumn.Index) e.Value = negara.IbukotaNegara;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bandaraBindingSource.Current is Bandara bandara)
            {
                if (db.Bandara.Any(f => f.KodeIATA == bandara.KodeIATA && f.ID != bandara.ID))
                {
                    MessageBox.Show("Kode iata sama");
                    return;
                }


                if (string.IsNullOrEmpty(bandara.Nama))
                {
                    MessageBox.Show("Nama harus diisi");
                    return;
                }

                bandara.KodeIATA = maskedTextBox1.Text;
                db.Bandara.AddOrUpdate(bandara);
                db.SaveChanges();
                OnLoad(EventArgs.Empty);
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bandaraDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bandaraDataGridView.Rows[e.RowIndex].DataBoundItem is Bandara bandara)
            {
                if (e.ColumnIndex == editButton.Index)
                {
                    bandaraBindingSource.Clear();
                    bandaraBindingSource.DataSource = db.Bandara.AsNoTracking().First(b => b.ID == bandara.ID);
                }

                if (e.ColumnIndex == hapusColumn.Index)
                {
                    db.Bandara.Remove(bandara);
                    db.SaveChanges();
                    OnLoad(EventArgs.Empty);
                }
            }
        }
    }
}
