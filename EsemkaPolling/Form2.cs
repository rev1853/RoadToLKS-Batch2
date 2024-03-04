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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (new Form3().ShowDialog() == DialogResult.OK)
            {
                Hide();
                new Form5().Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form4().ShowDialog();
        }
    }
}
