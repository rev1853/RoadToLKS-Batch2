using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework_P2
{
    public partial class Form1 : Form
    {
        public static int id;
        BromoAirlinesEntities db = new BromoAirlinesEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (akunBindingSource.Current is Akun data)
            {
                var akun = db.Akun.Where(akn => akn.Username == data.Username && akn.Password == data.Password).FirstOrDefault();
                if (akun != default && akun.MerupakanAdmin)
                {
                    id = akun.ID;
                    new Form2().Show();
                    Hide();
                }
                else MessageBox.Show("Gagal");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            akunBindingSource.Add(new Akun
            {
                Username = "admin",
                Password = "admin123"
            });
        }
    }
}
