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

namespace EsemkaPolling
{
    public partial class Form6 : Form
    {
        public EsemkaPollingEntities a = new EsemkaPollingEntities();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = a.Polls.Where(f => f.AdminID == Runtime.userid).ToList();
            pollOptionsBindingSource.Clear();
            pollOptionsBindingSource.AddNew();
            pollsBindingSource.Clear();
            pollsBindingSource.AddNew();
            bindingSource2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pollOptionsBindingSource.Current is PollOptions po && pollsBindingSource.Current is Polls p)
            {
                if (p.PollID == default) po.Polls = p;
                else po.PollID = p.PollID;

                bindingSource2.Add(po);
                a.PollOptions.AddOrUpdate(po);

                pollOptionsBindingSource.Clear();
                pollOptionsBindingSource.AddNew();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pollsBindingSource.Current is Polls p)
            {
                p.AdminID = Runtime.userid;
                p.CreatedAt = p.CreatedAt ?? DateTime.Now;
                p.IsClosed = p.IsClosed ?? false;
                a.Polls.AddOrUpdate(p);
                a.SaveChanges();
                OnLoad(EventArgs.Empty);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pollsDataGridView.SelectedRows[0].DataBoundItem is Polls p)
            {
                var pp = a.Polls.AsNoTracking().First(f => f.PollID == p.PollID);
                pollsBindingSource.DataSource = pp;
                bindingSource2.DataSource = pp.PollOptions.ToList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pollsDataGridView.SelectedRows[0].DataBoundItem is Polls p && p.PollResponses.Count == 0)
            {
                a.PollOptions.RemoveRange(p.PollOptions);
                a.Polls.Remove(p);
                a.SaveChanges();
                OnLoad(EventArgs.Empty);
            }
            else MessageBox.Show("Telah terpilih");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pollsDataGridView.SelectedRows[0].DataBoundItem is Polls p && p.PollResponses.Count == 0)
            {
                p.IsClosed = true;
                a.SaveChanges();
                OnLoad(EventArgs.Empty);
            }
        }
    }
}
