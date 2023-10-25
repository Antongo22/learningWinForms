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
        Dictionary<int, Picture> picts = new Dictionary<int, Picture>();
        Random rnd = new Random();
        string key;

        class Picture
        {
            public string path;
            public string name;
            public Picture(string name, string path)
            {
                this.name = name;   
                this.path = path;
            }
        }
        void SetPic()
        {
            int numPic = rnd.Next(1, 5);
            pictureBox1.BackgroundImage = Image.FromFile(picts[numPic].path);
            key = picts[numPic].name;
        }

        public Form1()
        {

            InitializeComponent();

            picts.Add(1, new Picture("бендер", @"C:\Users\anton\OneDrive\Изображения\Saved Pictures\bender-ass.png"));
            picts.Add(2, new Picture("фрай", @"C:\Users\anton\OneDrive\Изображения\Saved Pictures\Фрай.jpeg"));
            picts.Add(3, new Picture("теренс и филип", @"C:\Users\anton\OneDrive\Изображения\Saved Pictures\terens-i-filip-yuzhnyj-park.jpg"));
            picts.Add(4, new Picture("тау", @"C:\Users\anton\OneDrive\Изображения\Работа\photo_2023-07-31_21-16-55.jpg"));

     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetPic();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SetPic();
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower() == key)
            {
                MessageBox.Show("Правильно!");
            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Ошибка!");
                textBox1.Focus();
            }
        }
    }
}
