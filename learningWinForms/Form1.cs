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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace learningWinForms
{
    public partial class Form1 : Form
    {
        List<Person> persons = new List<Person>();

        public Form1()
        {
          
            InitializeComponent(); 
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            foreach(Person person in persons)
            {
                if (person.FIO == textBox1.Text)
                {
                    MessageBox.Show("Такой человек уже есть!");
                    return;
                }
            }
        
            persons.Add(new Person(textBox1.Text, dateTimePicker1.Value));
            MessageBox.Show("Человек добавлен!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            string text = "";
            int adult = 0;
            int minor = 0;

            foreach (Person person in persons)
            {
                text += person + "\n";
                if (person.age >= 18)
                {
                    adult++;
                }
                else
                {
                    minor++;
                }
            }

            MessageBox.Show(text + "\nСоверешеннолетних - " + adult + " Несоверешеннолетних - " + minor);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < persons.Count; i++)
            {
                if (persons[i].FIO == textBox2.Text)
                {
                    persons[i] = new Person(textBox1.Text, dateTimePicker1.Value);
                    MessageBox.Show("Данные изменены!");
                    return;
                }
            }
            MessageBox.Show("Таково человека не существует!");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i].FIO == textBox2.Text)
                {
                    persons.Remove(persons[i]);                  
                    MessageBox.Show("Данные удалены!");
                    return;
                }
            }
            MessageBox.Show("Нет данных о таком человеке!");
        }
    }
}
