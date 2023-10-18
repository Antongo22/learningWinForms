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
    public partial class Form2 : Form
    {
        Random rnd = new Random();
        Timer timer1 = new Timer();

        public Form2()
        {
            InitializeComponent();
            timer1.Interval = 500;
            timer1.Tick += Act;
            timer1.Start();
        }

        private void Act(object sender, EventArgs e)
        {
            this.Location = new Point(rnd.Next(0, Screen.PrimaryScreen.Bounds.Width - this.Width),
                 rnd.Next(0, Screen.PrimaryScreen.Bounds.Height - this.Height));
            this.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            this.Size = new Size(rnd.Next(100, 400), rnd.Next(100, 400));
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Location = new Point(rnd.Next(0, Screen.PrimaryScreen.Bounds.Width - this.Width),
                 rnd.Next(0, Screen.PrimaryScreen.Bounds.Height - this.Height));
        }
    }
}
