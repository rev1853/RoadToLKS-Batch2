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
    public partial class Form3 : Form
    {
        private Day1Entities db = new Day1Entities();
        private readonly int dataPerPage = 2;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var count = db.User.Count();
            var totalPage = Math.Ceiling(count / (dataPerPage * 1.0));
            for (int i = 1; i <= totalPage; i++) bindingSource1.Add(i);


            bindingNavigatorMoveNextItem.Click += (s, f) => OnNavigate();
            bindingNavigatorMovePreviousItem.Click += (s, f) => OnNavigate();
            bindingNavigatorMoveLastItem.Click += (s, f) => OnNavigate();
            bindingNavigatorMoveFirstItem.Click += (s, f) => OnNavigate();

            OnNavigate();
        }

        private void OnNavigate()
        {
            int page = bindingSource1.Current as int? ?? 1;
            userBindingSource.DataSource = db.User.OrderBy(f => f.ID).Skip((page - 1) * dataPerPage).Take(dataPerPage).ToList();
        }
    }
}
