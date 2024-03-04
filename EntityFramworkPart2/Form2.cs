using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramworkPart2
{
    public partial class Form2 : Form
    {
        QuizinAjaEntities db = new QuizinAjaEntities();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var data = db.Participant.Select(par => new
            {
                Quiz = par.Quiz.Name,
                Nama = par.ParticipantNickname,
                Benar = par.ParticipantAnswer.Count(f => f.Answer == f.Question.CorrectAnswer) * 1.0 / par.Quiz.Question.Count * 100
            }).OrderBy(f => f.Quiz).ToList();
            dataGridView1.DataSource = data;
            
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < dataGridView1.RowCount - 1 && e.ColumnIndex == 0)
            {
                if (e.Value.Equals(dataGridView1.Rows[e.RowIndex + 1].Cells[0].Value))
                {
                    e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex > 0 && e.ColumnIndex == 0)
            {
                if (e.Value.Equals(dataGridView1.Rows[e.RowIndex - 1].Cells[0].Value))
                {
                    e.Value = null;
                }
            }
        }
    }
}
