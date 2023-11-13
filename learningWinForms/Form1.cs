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

        int countOfPizza = 1;
        double finalPrise = 0;
        float sale = 0.0f;


        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetResult();
        }

        void SetResult()
        {
            if (int.TryParse(textBoxCount.Text, out int value) && value > 0)
            {
                countOfPizza = value;
            }

            if (radioButtonMeat.Checked)
            {
                groupBoxVeg.Enabled = false;
                groupBoxMeat.Enabled = true;

                pictureBoxMeat.BackgroundImage = Image.FromFile(@"C:\Users\anton\source\repos\Antongo22\learningWinForms\learningWinForms\bin\Debug\Мясная.PNG");

                finalPrise = 500;

                if (checkBoxDobCheese.Checked)
                {
                    finalPrise += 100;
                }
                if (checkBoxDoubMeat.Checked)
                {
                    finalPrise += 150;
                }
            }
            else
            {
                groupBoxVeg.Enabled = true;
                groupBoxMeat.Enabled = false;

                pictureBoxVeg.BackgroundImage = Image.FromFile(@"C:\Users\anton\source\repos\Antongo22\learningWinForms\learningWinForms\bin\Debug\Веганская.PNG");

                finalPrise = 400;

                if (checkBoxTomatos.Checked)
                {
                    finalPrise += 50;
                }
                if (checkBoxVegit.Checked)
                {
                    finalPrise += 70;
                }
            }

            labelPrise.Text = "Цена - " + finalPrise * countOfPizza;

            if (radioButtonPickup.Checked)
            {
                sale = 0.9f;
                labelSale.Text = "Скидка - 10%";
            }
            else if (radioButtonDelivery.Checked)
            {
                sale = 1.1f;
                labelSale.Text = "Больше на 10%";
            }
            else
            {
                sale = 1f;
                labelSale.Text = "Скидки нет";
            }

            finalPrise = finalPrise * sale * countOfPizza;

            labelResult.Text = "Итого - " + Math.Round(finalPrise, 4);
        }

        private void radioButtonMeat_CheckedChanged(object sender, EventArgs e)
        {
            SetResult();
        }

        private void radioButtonVegan_CheckedChanged(object sender, EventArgs e)
        {
            SetResult();
        }

        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {
            SetResult();
        }

        private void checkBoxDobCheese_CheckedChanged(object sender, EventArgs e)
        {
            SetResult();
        }

        private void checkBoxDoubMeat_CheckedChanged(object sender, EventArgs e)
        {
            SetResult();
        }

        private void checkBoxTomatos_CheckedChanged(object sender, EventArgs e)
        {
            SetResult();
        }

        private void checkBoxVegit_CheckedChanged(object sender, EventArgs e)
        {
            SetResult();
        }

        private void radioButtonHall_CheckedChanged(object sender, EventArgs e)
        {
            SetResult();
        }

        private void radioButtonPickup_CheckedChanged(object sender, EventArgs e)
        {
            SetResult();
        }

        private void radioButtonDelivery_CheckedChanged(object sender, EventArgs e)
        {
            SetResult();
        }
    }
}
