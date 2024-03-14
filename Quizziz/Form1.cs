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
    public partial class Form1 : Form
    {

        QuizinAjaEntities db = new QuizinAjaEntities();
        Participant p;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p = db.Participant.Add(new Participant
            {
                ParticipantNickname = "Revan",
                ParticipationDate = DateTime.Now,
                TimeTaken = 1
            });
            questionBindingSource.DataSource = db.Question.Where(f => f.QuizID == 1).ToList();
        }

        private void questionBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            foreach (Question item in questionBindingSource)
            {
                var index = questionBindingSource.IndexOf(item);
                Button btn = new Button
                {
                    Width = 50,
                    Text = (index + 1).ToString(),
                    Tag = item
                };
                btn.Click += (a, b) =>
                {
                    questionBindingSource.Position = index;
                };
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            questionBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            questionBindingSource.MoveNext();
        }

        void GetJawaban(object sender)
        {
            // cara 1
            //var yangTerpilih = groupBox1.Controls.Cast<Control>().FirstOrDefault(f => f is RadioButton r && r.Checked);
            //if (yangTerpilih != default) MessageBox.Show(yangTerpilih.Text);

            // cara 2
            if (sender is RadioButton rb && questionBindingSource.Current is Question q)
            {
                if (rb.Checked)
                {
                    var answer = new ParticipantAnswer
                    {
                        Participant = p,
                        QuestionID = q.ID,
                        Answer = rb.Text
                    };
                    q.ParticipantAnswer.Add(answer);
                }
            }
        }

        void DrawQuestion()
        {
            foreach (Button b in flowLayoutPanel1.Controls)
            {
                if (b.Tag is Question q && q.ParticipantAnswer.Any(f => f.Participant == p)) b.BackColor = Color.Red;
            }

            if (questionBindingSource.Current is Question qq)
            {
                var jawabanTerpilih = qq.ParticipantAnswer.FirstOrDefault(f => f.Participant == p);
                if (jawabanTerpilih != default)
                {
                    groupBox1.Controls.Cast<RadioButton>().First(f => f.Text == jawabanTerpilih.Answer).Checked = true;
                } else
                {
                    if (groupBox1.Controls.Cast<RadioButton>().FirstOrDefault(f => f.Checked) is RadioButton rb) rb.Checked = false;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GetJawaban(sender);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            GetJawaban(sender);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            GetJawaban(sender);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            GetJawaban(sender);
        }

        private void questionBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DrawQuestion();
        }
    }
}
