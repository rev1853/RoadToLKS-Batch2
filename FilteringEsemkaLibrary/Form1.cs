using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilteringEsemkaLibrary
{
    public partial class Form1 : Form
    {
        HovLibraryEntities db = new HovLibraryEntities();
        private bool doFilter = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IQueryable<Book> query = db.Book;

            var searchBy = comboBox1.SelectedItem;
            var keyword = textBox1.Text;

            switch (searchBy)
            {
                case "Title":
                    query = query.Where(q => q.title.Contains(keyword));
                    break;
                case "Author":
                    query = query.Where(q => q.authors.Contains(keyword));
                    break;
                case "Publisher":
                    query = query.Where(q => q.Publisher.name.Contains(keyword));
                    break;
            }

            if (doFilter)
            {
                if (comboBox2.SelectedItem is Language lang) query = query.Where(q => q.language_id == lang.id);

                query = query.Where(q => DbFunctions.TruncateTime(q.publication_date) > dateTimePicker1.Value && DbFunctions.TruncateTime(q.publication_date) < dateTimePicker2.Value);

                query = query.Where(q => q.number_of_pages > numericUpDown1.Value && q.number_of_pages < numericUpDown2.Value);

                query = query.Where(q => q.average_rating > (double)numericUpDown4.Value && q.average_rating < (double)numericUpDown3.Value);
            }


            bookBindingSource.DataSource = query.ToList();

            bindingSource1.DataSource = db.Language.ToList();
        }

        private void bookDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (bookDataGridView.Rows[e.RowIndex].DataBoundItem is Book book)
            {
                if (e.ColumnIndex == dataGridViewTextBoxColumn11.Index)
                {
                    e.Value = $"{book.average_rating} ({book.ratings_count})";
                }

                if (e.ColumnIndex == dataGridViewTextBoxColumn15.Index) e.Value = book.Language.long_text;
                if (e.ColumnIndex == dataGridViewTextBoxColumn16.Index) e.Value = book.Publisher.name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnLoad(EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doFilter = true;
            OnLoad(EventArgs.Empty);
        }
    }
}
