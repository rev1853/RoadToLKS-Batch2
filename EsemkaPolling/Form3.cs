using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaPolling
{
    class Runtime
    {
        public static int userid;
    }

    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            adminsBindingSource.Add(new Admins
            {
                UserName = "admin1",
                Password = "admin1"
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (adminsBindingSource.Current is Admins admin)
            {
                admin.Password = string.Join("", MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(admin.Password)).Select(f => $"{f:x2}"));
                var data = new EsemkaPollingEntities().Admins.FirstOrDefault(f => f.UserName == admin.UserName && f.Password == admin.Password);
                if (data != default)
                {
                    Runtime.userid = data.AdminID;
                    DialogResult = DialogResult.OK;
                } else
                {
                    MessageBox.Show("Gagal login");
                }
            }
        }
    }
}
