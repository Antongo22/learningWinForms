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

namespace learningWinForms
{
    public partial class Form1 : Form
    {
        Timer timer;
        int min = 0;
        int hou = 0;
        string time = "";

        string h = "00";
        string m = "00";

        public Form1()
        {
          
            InitializeComponent(); 
        }

        void UpdateTime()
        {
            time = "Время - " + h + ":" + m;
            this.Text = time;
        }

        void SetPic()
        {
            if (hou < 7)
            {
                pictureBox1.BackgroundImage = Image.FromFile("00-00.png");
            }
            else if (hou < 10)
            {
                pictureBox1.BackgroundImage = Image.FromFile("07-00.png");
            }
            else if (hou < 15)
            {
                pictureBox1.BackgroundImage = Image.FromFile("10-00.png");
            }
            else if (hou < 18)
            {
                pictureBox1.BackgroundImage = Image.FromFile("15-00.png");
            }
            else if (hou < 20)
            {
                pictureBox1.BackgroundImage = Image.FromFile("18-00.png");
            }
            else
            {
                pictureBox1.BackgroundImage = Image.FromFile("20-00.png");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 1;
            timer.Tick += Act;
            timer.Start();
        }

        private void Act(object sender, EventArgs e)
        {
            if (min < 60)
            {
                if (min < 10)
                {
                    m = "0" + min.ToString();
                    min++;
                }
                else
                {
                   m = min.ToString();
                    min++;
                }
            }
            else
            {
                min = 0;
                if (hou >= 23)
                {
                    hou = 0;
                    h = "0" + hou.ToString();
                    return;
                }
                if (hou < 9)
                {
                    h = hou.ToString();
                    hou++;
                    h = "0" + hou.ToString();
                }
                else
                {
                    hou++;
                    h = hou.ToString();
                }

            }

            SetPic();
            UpdateTime();
        }
    }
}
