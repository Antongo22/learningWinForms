using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learningWinForms
{
    public partial class Form1 : Form
    {
        string firstOperation = "";
        string secondOperation = "";
        string operation;

        string state = "f";



        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                groupBox2.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = true;
                pictureBox1.BackgroundImage = Image.FromFile("Шар.png");
            }
            else
            {
                groupBox2.Enabled = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                if (radioButton4.Checked)
                {
                    pictureBox1.BackgroundImage = Image.FromFile("Пир3.png");
                }
                if (radioButton5.Checked)
                {
                    pictureBox1.BackgroundImage = Image.FromFile("Пир4.png");
                }
                if (radioButton6.Checked)
                {
                    pictureBox1.BackgroundImage = Image.FromFile("Пир5.jpeg");
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                if (radioButton4.Checked)
                {
                    pictureBox1.BackgroundImage = Image.FromFile("Приз3.jpg");
                }
                if (radioButton5.Checked)
                {
                    pictureBox1.BackgroundImage = Image.FromFile("Приз4.png");
                }
                if (radioButton6.Checked)
                {
                    pictureBox1.BackgroundImage = Image.FromFile("Приз5.jpg");
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                if (radioButton2.Checked)
                {
                    pictureBox1.BackgroundImage = Image.FromFile("Пир3.png");
                }
                else
                {
                    pictureBox1.BackgroundImage = Image.FromFile("Приз3.jpg");
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                if (radioButton2.Checked)
                {
                    pictureBox1.BackgroundImage = Image.FromFile("Пир4.png");
                }
                else
                {
                    pictureBox1.BackgroundImage = Image.FromFile("Приз4.png");
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton6.Checked)
            {
                if (radioButton2.Checked)
                {
                    pictureBox1.BackgroundImage = Image.FromFile("Пир5.jpeg");
                }
                else
                {
                    pictureBox1.BackgroundImage = Image.FromFile("Приз5.jpg");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                if(double.TryParse(textBox3.Text, out double value) && value > 0)
                {
                    labelRes.Text = "v = " + Math.Round(((3.0/4.0) * Math.PI * value), 3);
                }
            }
            if (radioButton2.Checked)
            {
                if (double.TryParse(textBox1.Text, out double value1) && value1 > 0 && double.TryParse(textBox2.Text, out double value2) && value2 > 0)
                {
                    if(radioButton4.Checked)
                    {
                        labelRes.Text = "v = " + Math.Round(1.0 /3.0 * ((Math.Sqrt(3) * value1 * value1) / 4 ) * value2, 3);
                    }
                    if (radioButton5.Checked)
                    {
                        labelRes.Text = "v = " + Math.Round( (1.0 / 3.0) * value2 * Math.Pow(value1, 2), 3);
                    }
                    if (radioButton6.Checked)
                    {
                        labelRes.Text = "v = " + Math.Round( 1.0 / 3.0 * ((5 * Math.Sqrt(3) * value1 * value1) / 4) * value2, 3);
                    }
                }
            }
            if (radioButton3.Checked)
            {
                if(double.TryParse(textBox1.Text, out double value1) && value1 > 0 && double.TryParse(textBox2.Text, out double value2) && value2 > 0)
                {
                    if (radioButton4.Checked)
                    {
                        labelRes.Text = "v = " + Math.Round(((Math.Sqrt(3) * value1 * value1) / 4) * value2, 3);
                    }
                    if (radioButton5.Checked)
                    {
                        labelRes.Text = "v = " + Math.Round(value2 * Math.Pow(value1, 2), 3);
                    }
                    if (radioButton6.Checked)
                    {
                        labelRes.Text = "v = " + Math.Round( (((5 * Math.Sqrt(3) * value1 * value1) / 4) * value2), 3) ;

                    }
                }
            }
        }
    }
}
