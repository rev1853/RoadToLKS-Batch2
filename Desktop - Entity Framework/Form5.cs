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
    public partial class Form5 : Form
    {
        private readonly Day1Entities db = new Day1Entities();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = db.User.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userBindingSource.Current is User user)
            {
                user.BirthDate = birthDateDateTimePicker.Value;
                db.User.AddOrUpdate(user);
                db.SaveChanges();
                OnLoad(EventArgs.Empty);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (userBindingSource.Current is User user)
            {
                db.User.Remove(user);
                db.SaveChanges();
                OnLoad(EventArgs.Empty);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (userDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Mohon pilih data");
                return;
            }

            if (userDataGridView.SelectedRows[0].DataBoundItem is User user)
            {
                userBindingSource.DataSource = db.User.AsNoTracking().First(f => f.ID == user.ID);
            } 
        }
    }
}
