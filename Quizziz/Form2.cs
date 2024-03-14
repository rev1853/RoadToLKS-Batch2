using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizziz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Timer timer = new Timer
            {
                Interval = 2
            };
            if (menuStrip1.Width > 80)
            {
                foreach (ToolStripMenuItem item in menuStrip1.Items)
                {
                    item.DisplayStyle = ToolStripItemDisplayStyle.Image;
                }
                timer.Tick += (a, b) =>
                {
                    if (menuStrip1.Width > 80) menuStrip1.Width -= 4;
                    else
                    {
                        timer.Stop();
                        button1.Enabled = true;
                    }
                };
                
            } else
            {
                foreach (ToolStripMenuItem item in menuStrip1.Items)
                {
                    item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                }
                timer.Tick += (a, b) =>
                {
                    if (menuStrip1.Width < 350) menuStrip1.Width += 4;
                    else
                    {
                        timer.Stop();
                        button1.Enabled = true;
                    }
                };
            }
            timer.Start();
        }
    }
}
