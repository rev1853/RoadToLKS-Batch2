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

namespace EntityFramworkPart2
{
    public partial class Form4 : Form
    {
        EsemkaHeroEntities db = new EsemkaHeroEntities();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            tabelElementBS.DataSource = db.Element.ToList();
            formSkillBS.AddNew();
            formElementBS.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (formSkillBS.Current is Skill skill && formElementBS.Current is Element element)
            {
                skill.Element = element;
                tabelSkillBS.Add(skill);
                db.Skill.Add(skill);

                formSkillBS.Clear();
                formSkillBS.AddNew();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (formElementBS.Current is Element element)
            {
                db.Element.AddOrUpdate(element);
                db.SaveChanges();
                OnLoad(EventArgs.Empty);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Skill skill)
            {
                if (e.ColumnIndex == DeleteButton.Index)
                {
                    db.Skill.Remove(skill);
                    tabelSkillBS.Remove(skill);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (elementDataGridView.SelectedRows[0].DataBoundItem is Element element)
            {
                formElementBS.DataSource = element;
                tabelSkillBS.DataSource = db.Skill.Where(f => f.ElementID == element.ID).ToList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (elementDataGridView.SelectedRows[0].DataBoundItem is Element element)
            {
                db.Skill.RemoveRange(db.Skill.Where(f => f.ElementID == element.ID));
                db.Element.Remove(element);
                db.SaveChanges();
                OnLoad(EventArgs.Empty);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form5().ShowDialog();
            MessageBox.Show(Class1.id.ToString());
        }
    }
}
