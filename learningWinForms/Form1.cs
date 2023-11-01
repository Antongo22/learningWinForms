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
        string firstOperation = "";
        string secondOperation = "";
        string operation;

        string state = "f";



        public Form1()
        {
            InitializeComponent(); 
        }


        void AddTextAct(string operation)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && state != "s" && state != "e")
            {
                textBox1.Text += " " + operation + " ";
                this.operation = operation;
                state = "s";
            }
        }

        void AddNumber(string num)
        {
            if (state == "f")
            {
                firstOperation += num;
                textBox1.Text += num;
            }
            else if (state == "s")
            {
                secondOperation += num;
                textBox1.Text += num;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxSys_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSys.Checked)
            {
                buttonDecimal.Visible = true;
                buttonBinary.Visible = true;
            }
            else
            {
                buttonDecimal.Visible = false;
                buttonBinary.Visible = false;
            }
        }

        private void buttonCleanAll_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            firstOperation = "";
            secondOperation = "";
            state = "f";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AddNumber(button0.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNumber(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNumber(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddNumber(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddNumber(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddNumber(button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddNumber(button6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddNumber(button7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddNumber(button8.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddNumber(button9.Text);
        }

        private void Fraction_Click(object sender, EventArgs e)
        {
            if(state == "f")
            {
                if (!firstOperation.Contains(",") && !String.IsNullOrEmpty(firstOperation))
                {
                    firstOperation += ",";
                    textBox1.Text += ",";
                }
            }
            else
            {
                if (!secondOperation.Contains(",") && !String.IsNullOrEmpty(secondOperation))
                {
                    secondOperation += ",";
                    textBox1.Text += ",";
                }
            }
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            AddTextAct(buttonAddition.Text);
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            if (state == "f")
            {
                if (!firstOperation.Contains("-") && String.IsNullOrEmpty(firstOperation))
                {
                    firstOperation += "-";
                    textBox1.Text += "-";
                }
                else if (!String.IsNullOrEmpty(firstOperation))
                {
                    AddTextAct(buttonSubtraction.Text);
                }
            }
            else
            {
                if (!secondOperation.Contains("-") && String.IsNullOrEmpty(secondOperation))
                {
                    secondOperation += "-";
                    textBox1.Text += "-";
                }
            }
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            AddTextAct(buttonMultiplication.Text);
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            AddTextAct(buttonDivision.Text);
        }

        private void buttonDegree_Click(object sender, EventArgs e)
        {
            AddTextAct(buttonDegree.Text);
        }

        private void buttonRoot_Click(object sender, EventArgs e)
        {
            AddTextAct(buttonRoot.Text);
            secondOperation = " ";
        }

        private void buttonRounding_Click(object sender, EventArgs e)
        {
            AddTextAct(buttonRounding.Text);
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            AddTextAct(buttonDecimal.Text);
            state = "e";
            textBox1.Text += $" = {Convert.ToString(Convert.ToInt32(firstOperation, 2), 10)}";
        }

        private void buttonBinary_Click(object sender, EventArgs e)
        {
            AddTextAct(buttonBinary.Text);
            state = "e";
            textBox1.Text += $" = {Convert.ToString(Convert.ToInt32(firstOperation, 10), 2)}";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (state == "s" && !String.IsNullOrEmpty(secondOperation))
            {
                switch (operation)
                {
                    case "+":
                        textBox1.Text += $" = {double.Parse(firstOperation) + double.Parse(secondOperation)}";
                        break;
                    case "-":
                        textBox1.Text += $" = {double.Parse(firstOperation) - double.Parse(secondOperation)}";
                        break;
                    case "×":
                        textBox1.Text += $" = {double.Parse(firstOperation) * double.Parse(secondOperation)}";
                        break;
                    case "÷":
                        if (secondOperation == "0")
                        {
                            return;
                        }
                        textBox1.Text += $" = {double.Parse(firstOperation) / double.Parse(secondOperation)}";
                        break;
                    case "^":
                        textBox1.Text += $" = {Math.Pow(double.Parse(firstOperation), double.Parse(secondOperation))}";
                        break;
                    case "√":
                        textBox1.Text += $" = {Math.Sqrt(double.Parse(firstOperation))}";
                        break;
                    case "Round":
                        textBox1.Text += $" = {Math.Round(double.Parse(firstOperation), int.Parse(secondOperation))}";
                        break;
                }
                state = "e";
            }
        }
    }
}
