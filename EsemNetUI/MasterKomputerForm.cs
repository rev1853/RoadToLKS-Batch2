﻿using System;
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
    public partial class MasterKomputerForm : Form
    {
        public MasterKomputerForm()
        {
            InitializeComponent();
        }

        private void MasterKomputerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(5);
        }
    }
}
