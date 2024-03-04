using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDEF
{

    public partial class Form2 : Form
    {
        public static int id;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = new TokoEntities().Barang.Where(b => b.Stok > 50).First();
            id = data.ID;
            new Form3().Show();
        }
    }
}
