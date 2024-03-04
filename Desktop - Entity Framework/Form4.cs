using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop___Entity_Framework
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // cara 1
            bindingSource1.DataSource = new string[] { "Data 1", "Data 2", "Data 3", "Data 4", "Data 5" };

            // cara 2
            //bindingSource1.Add("Data 1");
            //bindingSource1.Add("Data 2");
            //bindingSource1.Add("Data 3");
            //bindingSource1.Add("Data 4");
            //bindingSource1.Add("Data 5");


            Console.WriteLine(dataGridView1.Rows[0].DataBoundItem);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.Value = dataGridView1.Rows[e.RowIndex].DataBoundItem;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource1.Current is string data)
            {
                textBox1.Text = data;
            }
        }
    }
}
