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

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открытие диалогового окна для выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            // Чтение данных из файла и сохранение в массив
            string text = File.ReadAllText(openFileDialog.FileName);

            textBox1.Text = text;
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Получаем путь к выбранному файлу
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.Write(textBox1.Text);
                    }

                    MessageBox.Show("Файл успешно сохранен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.SelectedText))
            {
                Clipboard.SetText(textBox1.SelectedText);
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string clipboardText = Clipboard.GetText();

            int cursorPosition = textBox1.SelectionStart;

            textBox1.Text = textBox1.Text.Insert(cursorPosition, clipboardText);

            textBox1.SelectionStart = cursorPosition + clipboardText.Length;
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли в textBox1 выделенный текст
            if (!string.IsNullOrEmpty(textBox1.SelectedText))
            {
                // Копируем выделенный текст в буфер обмена
                Clipboard.SetText(textBox1.SelectedText);

                // Затем удаляем выделенный текст из textBox1
                textBox1.SelectedText = "";
            }
        }

        private void настройкиШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog= new FontDialog();
            fontDialog.ShowDialog();
            textBox1.Font= fontDialog.Font;
        }

        private void настройкиФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            textBox1.BackColor = colorDialog.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            persons.Add(textBox2.Text);
            textBox2.Text = "";
            textBox1.Text = $"Уважаемые {GetPeople()}{Environment.NewLine}Приглашаем вас на всеобщую мобилизвцию!{Environment.NewLine}Явка обязательна.";
        }

        string GetPeople()
        {
            string per = "";
            foreach (var person in persons)
            {
                per += person + ", ";
            }
            return per;
        }
    }
}
    