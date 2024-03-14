using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemNetUI
{
    public partial class Form1 : Form
    {
        string time = "15:58:00";
        int duration = 2;

        int remainingChances = 3;

        public Form1()
        {
            var nama = "revan";
            
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(nama);
            var base64 = System.Convert.ToBase64String(plainTextBytes);
            Console.WriteLine(base64);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer1.Tick += (s, o) =>
            //{
            //    DateTime datetime = DateTime.Parse(time).AddHours(duration);
            //    TimeSpan waktu = datetime.TimeOfDay - DateTime.Now.TimeOfDay;
            //    //label1.Text = $"{waktu.Hours}:{waktu.Minutes}:{waktu.Seconds}";
            //    label1.Text = waktu.ToString(@"hh\:mm\:ss");
            //};
            //timer1.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234")
            {
                MessageBox.Show("Password benar");
            }
            else
            {
                --remainingChances;
                if (remainingChances == 0)
                {
                    textBox1.Clear();
                    textBox1.ReadOnly = true;

                    DateTime time = DateTime.Now;
                    int duration = 5;

                    timer2.Tick += (s, f) =>
                    {
                        DateTime now = DateTime.Now;
                        var kurang = now - time;

                        label1.Text = kurang.TotalSeconds.ToString();
                        if (kurang.TotalSeconds > duration)
                        {
                            textBox1.ReadOnly = false;
                            timer2.Stop();
                            remainingChances = 3;
                        }

                    };
                    timer2.Start();
                }


            }
        }
    }
}
