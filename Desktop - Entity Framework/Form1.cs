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
    public partial class Form1 : Form
    {
        private readonly Day1Entities entities = new Day1Entities();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = textBox1.Text;
            var password = textBox2.Text;

            // cara 1
            var isExist = entities.User.Any(user => user.Username == username && user.Password == password);

            // cara 2
            var isExist2 = entities.User.Where(f => f.Username == username && f.Password == password).FirstOrDefault();

            // cara 3
            var isExist3 = entities.User.FirstOrDefault(f => f.Username == username && f.Password == password);

            if (isExist)
            {
                //MessageBox.Show($"Selamat datang {username}");
                Hide();
                new Form4().Show();
            } else
            {
                MessageBox.Show("Login gagal");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // cara 1
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;

            // cara 2
            if (checkBox1.Checked) textBox2.UseSystemPasswordChar = false;
            else textBox2.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // cara 2
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "revan";
            textBox2.Text = "revanrevan";
        }
    }
}
