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
    public partial class Form1 : Form
    {
        class Mouse
        {
            public string merek;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pollOptionsBindingSource.DataSource = new EsemkaPollingEntities().PollOptions.ToList();
        }

        private void pollOptionsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (pollOptionsDataGridView.Rows[e.RowIndex].DataBoundItem is PollOptions po)
            {
                if (e.ColumnIndex == pollingColumn.Index)
                {
                    e.Value = po.Polls.Question;

                    if (e.RowIndex > 0 && po.PollID.Equals((pollOptionsDataGridView.Rows[e.RowIndex - 1].DataBoundItem as PollOptions).PollID))
                    {
                        e.Value = null;
                    }
                }

                if (e.ColumnIndex == jumlahSuaraColumn.Index)
                {
                    e.Value = po.PollResponses.Count;
                }

                if (e.ColumnIndex == totalSuaraColumn.Index)
                {
                    e.Value = po.Polls.PollResponses.Count;
                }
            }
        }

        private void pollOptionsDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < pollOptionsDataGridView.RowCount - 1 && pollOptionsDataGridView.Rows[e.RowIndex].DataBoundItem is PollOptions po)
            {
                if (e.ColumnIndex == pollingColumn.Index && po.PollID.Equals((pollOptionsDataGridView.Rows[e.RowIndex + 1].DataBoundItem as PollOptions).PollID))
                {
                    e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            Hide();
        }
    }
}
