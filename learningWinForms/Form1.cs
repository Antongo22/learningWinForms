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
        Dictionary<string, int> products = new Dictionary<string, int>();
        

        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        void Culc()
        {
            int res = 0;

            foreach(var item in products)
            {
                res += item.Value;
            }

            label1.Text = "Итого:" + res;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string[] prod = comboBox1.Text.Split(' ');

            if (products.ContainsKey(prod[0]) )
            {
                return;
            }

            products.Add(prod[0], int.Parse(prod[1]) * int.Parse(textBox2.Text));
            listBox1.Items.Add(comboBox1.Text + " x " + textBox2.Text);

            Culc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] prod = listBox1.SelectedItem.ToString().Split(' ');

            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            products.Remove(prod[0]);
            Culc();
        }
    }
}
