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

namespace Desktop___Entity_Framework
{
    public partial class Form2 : Form
    {
        private Day1Entities entities = new Day1Entities();
        private int id = -1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            id = -1;
            dataGridView1.DataSource = entities.User.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime? birthDate = dateTimePicker1.Value;
            if (checkBox1.Checked) birthDate = null;

            if (id == -1)
            {
                var user = new User
                {
                    Username = textBox1.Text,
                    Password = textBox2.Text,
                    BirthDate = birthDate
                };

                entities.User.Add(user);
                entities.SaveChanges();
            } else
            {
                var user = entities.User.Find(id);
                user.Username = textBox1.Text;
                user.Password = textBox2.Text;
                user.BirthDate = birthDate;

                entities.SaveChanges();
            }

            OnLoad(EventArgs.Empty);
            button4.PerformClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count ==0)
            {
                MessageBox.Show("Mohon pilih data terlebih dahulu");
                return;
            }

            var data = dataGridView1.SelectedRows[0].DataBoundItem as User;
            textBox1.Text = data.Username;
            textBox2.Text = data.Password;
            dateTimePicker1.Value = data.BirthDate ?? DateTime.Now;

            id = data.ID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin menghapus?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Mohon pilih data terlebih dahulu");
                    return;
                }

                var data = dataGridView1.SelectedRows[0].DataBoundItem as User;

                entities.User.Remove(data);
                entities.SaveChanges();

                OnLoad(EventArgs.Empty);
            }
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
