using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Threading;

namespace learningWinForms
{
    public partial class Form1 : Form
    {
        List<string> persons = new List<string>();

        public Form1()
        {
          
            InitializeComponent(); 
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void DrawCoordinateAxes()
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen axisPen = new Pen(Color.Black, 2f);

            graphics.DrawLine(axisPen, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);

            graphics.DrawLine(axisPen, pictureBox1.Width - 10, pictureBox1.Height / 2 - 5, pictureBox1.Width, pictureBox1.Height / 2);
            graphics.DrawLine(axisPen, pictureBox1.Width - 10, pictureBox1.Height / 2 + 5, pictureBox1.Width, pictureBox1.Height / 2);

            graphics.DrawLine(axisPen, pictureBox1.Width / 2, 0, pictureBox1.Width / 2, pictureBox1.Height);

            graphics.DrawLine(axisPen, pictureBox1.Width / 2 - 5, 10, pictureBox1.Width / 2, 0);
            graphics.DrawLine(axisPen, pictureBox1.Width / 2 + 5, 10, pictureBox1.Width / 2, 0);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DrawCoordinateAxes();
            Graphics graphics = pictureBox1.CreateGraphics();

            Color color = Color.Black;
            if (radioButton1.Checked)
            {
                color = Color.Red;
            }
            else if (radioButton2.Checked)
            {
                color = Color.Blue;
            }
            else if (radioButton3.Checked)
            {
                color = Color.Yellow;
            }


            Pen pen = new Pen(color, 3f);
            Point[] pointsS = new Point[1000];
            Point[] pointsC = new Point[1000];


            for (int i = 0; i < 1000; i++)
            {
                if (checkBox1.Checked)
                {
                    pointsS[i] = new Point(i, (int)(Math.Sin((double)i / 10 - 20) * 100 + 230));
                }
                if (checkBox2.Checked)
                {
                    pointsC[i] = new Point(i, (int)(Math.Cos((double)i / 10 - 20) * 100 + 230));
                }
            }

            if (checkBox3.Checked)
            {
                int centerX = 200;
                int centerY = 200;
                int width = 50;
                int height = 30;
                Rectangle ellipseRect = new Rectangle(centerX - width / 2, centerY - height / 2, width, height);
                graphics.DrawEllipse(pen, ellipseRect);
            }
            if (checkBox4.Checked)
            {
                int centerX = 400;
                int centerY = 200;
                int radius = 50;
                Rectangle circleRect = new Rectangle(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
                graphics.DrawEllipse(pen, circleRect);
            }

            graphics.DrawLines(pen, pointsS);
            graphics.DrawLines(pen, pointsC);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(pictureBox1.BackColor);
            DrawCoordinateAxes();
        }

       
    }
}
    