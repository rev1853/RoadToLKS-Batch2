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
    public partial class Form1 : Form
    {
        QuizinAjaEntities db = new QuizinAjaEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private class Data
        {
            public string NamaAja { get; set; }
            public double JawabanBenar { get; set; }
            public double TotalJawaban { get; set; }
            public double PresentaseBenar => JawabanBenar / TotalJawaban * 100;
            public double PresentaseSalah => (TotalJawaban - JawabanBenar) / TotalJawaban * 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var data = db.Participant.Select(participant => new Data
            {
                NamaAja = participant.ParticipantNickname,
                JawabanBenar = participant.ParticipantAnswer.Count(f => f.Answer == f.Question.CorrectAnswer),
                TotalJawaban = participant.Quiz.Question.Count
            }).ToList();
            dataGridView1.DataSource = data;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }
    }
}
