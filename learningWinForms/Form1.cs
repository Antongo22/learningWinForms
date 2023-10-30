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

        int correct = 0;
        int wrong = 0;


        List<int> listPicts = new List<int>(); 

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
            sp:
            int numPic = rnd.Next(1, 6);
            if (listPicts.Contains(numPic))
            {
                goto sp;
            }
            listPicts.Add(numPic);

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
            picts.Add(5, new Picture("резе", @"C:\Users\anton\OneDrive\Изображения\Тяны\Резе\Без названия.jpeg"));
     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetPic();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower() == key)
            {
                correct++;
            }
            else
            {
                wrong ++;   
            }
            textBox1.Text = "";
            textBox1.Focus();
            labelRi.Text = $"Правильно - {correct}";
            labelWr.Text = $"Неправильно - {wrong}";

            if (correct+wrong == 5)
            {
                string text = "";

                if (correct >= 3)
                {
                    text = "Вы прошли тест! Ваша оценка - " + correct;
                }
                else
                {
                    text = "Вы не прошли тест! Вы отчислены!";
                }


                MessageBox.Show(text);
                Close();
            }
            SetPic();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelRi.Visible = true;
            labelWr.Visible = true;
            pictureBox1.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
            button2.Visible = false;
            textBoxName.ReadOnly = true;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxName.Text))
            {
                button2.Visible = true;
            }
            else { button2.Visible = false; }
        }
    }
}
