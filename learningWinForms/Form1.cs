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
        Random rnd = new Random();
        Timer timer1 = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 300;
            timer1.Tick += Act;
            timer1.Start();
        }

        private void Act(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            Form2 form = new Form2();
            form.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            form.Location = new Point(rnd.Next(0, Screen.PrimaryScreen.Bounds.Width - form.Width), 
                             rnd.Next(0, Screen.PrimaryScreen.Bounds.Height - form.Height));
            form.Size = new Size(rnd.Next(100, 400), rnd.Next(100, 400));
            form.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
