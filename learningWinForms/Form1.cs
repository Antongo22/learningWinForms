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
using System.Globalization;

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
            Products.GetProducts();
        }

        private void buttonShowProducts_Click(object sender, EventArgs e)
        {
            Products.GetProducts(true);
        }

        private void buttonMidPrise_Click(object sender, EventArgs e)
        {
            Products.GetMidPrise();
        }

        private void buttonSumGroup_Click(object sender, EventArgs e)
        {
            Products.GetTotalPriceByGroup();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            if (double.TryParse(textBoxPrise.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double pr) && !String.IsNullOrEmpty(textBoxName.Text) && !String.IsNullOrEmpty(textBoxGoup.Text) && !String.IsNullOrEmpty(textBoxWarehouse.Text))
            {
                string text = textBoxName.Text + " % " + textBoxGoup.Text + " % " + textBoxPrise.Text + " % " + textBoxWarehouse.Text;
                File.AppendAllText("prod.txt", text + '\n');
                MessageBox.Show("Данные внесены!");
            }
            else
            {
                MessageBox.Show("Ошибка формата данных");
            }
           

        }
    }
}
    