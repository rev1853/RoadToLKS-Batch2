using EsemNetUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemNetUI
{
    public partial class LoginFormAdmin : Form
    {
        public bool Test;
        public LoginFormAdmin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is FormAdminData tp)
            {
                tp.Visible = !tp.Visible;
                bindingSource1.ResetCurrentItem();
            }
        }

        private void LoginFormAdmin_Load(object sender, EventArgs e)
        {
            bindingSource1.Add(new FormAdminData
            {
                Visible = true
            });
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }

    class FormAdminData
    {
        public bool Visible { get; set; }
    }
}
