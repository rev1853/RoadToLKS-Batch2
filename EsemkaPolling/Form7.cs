using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaPolling
{
    public partial class Form7 : Form
    {
        EsemkaPollingEntities db = new EsemkaPollingEntities();
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            pollResponsesBindingSource.DataSource = db.PollResponses.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // cara 1
            //foreach(DataGridViewRow baris in pollResponsesDataGridView.SelectedRows)
            //{
            //    db.PollResponses.Remove(baris.DataBoundItem as PollResponses);
            //}
            //db.SaveChanges();
            //OnLoad(EventArgs.Empty);

            // cara 2
            db.PollResponses.RemoveRange(pollResponsesDataGridView.SelectedRows.Cast<DataGridViewRow>().Select(f => f.DataBoundItem as PollResponses));
            db.SaveChanges();
            OnLoad(EventArgs.Empty);

        }
    }
}
