using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public int hour;
        public int minut;
        public int second;
        public Form1()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            hour = Convert.ToInt32(textBox1.Text);
            minut = Convert.ToInt32(textBox2.Text);
            second = Convert.ToInt32(textBox3.Text);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            second = second - 1;
            if (second == -1)
            {
                minut = minut - 1;
                second = 59;
            }
            if (minut == -1)
            {
                hour = hour - 1;
                minut = 59;
            }
            if (minut == -1)
            {
                hour = hour - 1;
                minut = 59;
            }
            if (hour == 0 && minut == 0 && second == 0)
            {
                timer1.Stop();
                MessageBox.Show("Время закончилось!");
            }
            label4.Text = Convert.ToString(hour);
            label5.Text = Convert.ToString(minut);
            label6.Text = Convert.ToString(second);
        }

        private void button2_Click(object sender, EventArgs e)
        {

              timer1.Stop();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                timer1.Stop();
                label4.Text = "0";
                label5.Text = "0";
                label6.Text = "0";
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
        }
    }
}
