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

namespace TheStore
{
    public partial class Form2 : Form
    {
        TheStoreEntities db = new TheStoreEntities();
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSource1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is Products product)
            {
                db.Products.AddOrUpdate(product);
                db.SaveChanges();

                MessageBox.Show("Product created successfully");
                OnLoad(EventArgs.Empty);
            }
        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productsDataGridView.Rows[e.RowIndex].DataBoundItem is Products product)
            {
                if (e.ColumnIndex == EditColumn.Index)
                {
                    bindingSource1.DataSource = db.Products.AsNoTracking().First(f => f.ProductID == product.ProductID);
                } 

                if (e.ColumnIndex == DeleteColumn.Index)
                {
                    if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        db.Products.Remove(product);
                        db.SaveChanges();
                        OnLoad(EventArgs.Empty);
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
            productsBindingSource.DataSource = db.Products.ToList();
        }
    }
}
