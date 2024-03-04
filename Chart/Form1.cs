using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Chart
{
    public partial class Form1 : Form
    {
        EsemkaHeroEntities db = new EsemkaHeroEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var data = db.Clan.Select(clan => new
            {
                NamaClan = clan.Name,
                JumlahHero = clan.Hero.Count()
            }).ToList();

            chart1.Series[0].Points.DataBind(data, "NamaClan", "JumlahHero", null);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
