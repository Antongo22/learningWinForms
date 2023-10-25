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
        Dictionary<int, string> picts = new Dictionary<int, string>();


        public Form2()
        {
            InitializeComponent();


            picts.Add(1, @"C:\Users\anton\OneDrive\Изображения\Saved Pictures\bender-ass.png");
            picts.Add(2, @"C:\Users\anton\OneDrive\Изображения\Тяны\Резе\1640360396119486090.png");
            picts.Add(3, @"C:\Users\anton\OneDrive\Изображения\Тяны\Резе\Без названия (1).jpeg");
            picts.Add(4, @"C:\Users\anton\OneDrive\Изображения\Saved Pictures\Фрай.jpeg");
        }

        void SetPic()
        {
            int numPic = rnd.Next(1, 5);
            pictureBox1.BackgroundImage = Image.FromFile(picts[numPic]);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SetPic();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SetPic();
        }
    }
}
