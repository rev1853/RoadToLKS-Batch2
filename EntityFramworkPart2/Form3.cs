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
    public partial class Form3 : Form
    {
        QuizinAjaEntities db = new QuizinAjaEntities();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = db.Quiz.ToList();
            comboBox1.DisplayMember = "Name";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Quiz quiz)
            {
                var data = quiz.Participant.Select(ff => new
                {
                    Nama = ff.ParticipantNickname,
                    JumlahJawabanYangBenar = ff.ParticipantAnswer.Count(f => f.Question.CorrectAnswer == f.Answer),
                    Durasi = ff.ParticipantAnswer.Count(f => f.Question.CorrectAnswer != f.Answer)
                }).ToList();

                chart1.Series[0].Points.DataBind(data, "Nama", "JumlahJawabanYangBenar", null);
                chart1.Series[1].Points.DataBind(data, "Nama", "Durasi", null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }
    }
}
