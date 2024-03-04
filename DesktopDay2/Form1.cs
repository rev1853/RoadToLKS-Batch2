using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopDay2
{
    public partial class Form1 : Form
    {

        BromoAirlinesEntities db = new BromoAirlinesEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bandaraBindingSource.DataSource = db.Bandara.ToList();
            negaraBindingSource.DataSource = db.Negara.ToList();
            formBindingSource.AddNew();
        }

        private void bandaraDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (bandaraDataGridView.Rows[e.RowIndex].DataBoundItem is Bandara bandara)
            {
                if (e.ColumnIndex == dataGridViewTextBoxColumn10.Index)
                {
                    e.Value = bandara.Negara.Nama;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (formBindingSource.Current is Bandara bandara)
            {
                db.Bandara.Add(bandara);
                db.SaveChanges();
                formBindingSource.Clear();
                OnLoad(EventArgs.Empty);
            }
        }
    }
}
