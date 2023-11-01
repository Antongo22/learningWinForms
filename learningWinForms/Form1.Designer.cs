namespace learningWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCleanAll = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonSubtraction = new System.Windows.Forms.Button();
            this.buttonAddition = new System.Windows.Forms.Button();
            this.Fraction = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.checkBoxSys = new System.Windows.Forms.CheckBox();
            this.buttonDegree = new System.Windows.Forms.Button();
            this.buttonRounding = new System.Windows.Forms.Button();
            this.buttonRoot = new System.Windows.Forms.Button();
            this.buttonBinary = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(312, 77);
            this.textBox1.TabIndex = 0;
            // 
            // buttonCleanAll
            // 
            this.buttonCleanAll.Location = new System.Drawing.Point(243, 144);
            this.buttonCleanAll.Name = "buttonCleanAll";
            this.buttonCleanAll.Size = new System.Drawing.Size(75, 51);
            this.buttonCleanAll.TabIndex = 2;
            this.buttonCleanAll.Text = "C";
            this.buttonCleanAll.UseVisualStyleBackColor = true;
            this.buttonCleanAll.Click += new System.EventHandler(this.buttonCleanAll_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(243, 201);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(75, 51);
            this.buttonDivision.TabIndex = 3;
            this.buttonDivision.Text = "÷";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Location = new System.Drawing.Point(243, 258);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(75, 51);
            this.buttonMultiplication.TabIndex = 4;
            this.buttonMultiplication.Text = "×";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            this.buttonMultiplication.Click += new System.EventHandler(this.buttonMultiplication_Click);
            // 
            // buttonSubtraction
            // 
            this.buttonSubtraction.Location = new System.Drawing.Point(243, 315);
            this.buttonSubtraction.Name = "buttonSubtraction";
            this.buttonSubtraction.Size = new System.Drawing.Size(75, 51);
            this.buttonSubtraction.TabIndex = 5;
            this.buttonSubtraction.Text = "-";
            this.buttonSubtraction.UseVisualStyleBackColor = true;
            this.buttonSubtraction.Click += new System.EventHandler(this.buttonSubtraction_Click);
            // 
            // buttonAddition
            // 
            this.buttonAddition.Location = new System.Drawing.Point(243, 371);
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.Size = new System.Drawing.Size(75, 51);
            this.buttonAddition.TabIndex = 6;
            this.buttonAddition.Text = "+";
            this.buttonAddition.UseVisualStyleBackColor = true;
            this.buttonAddition.Click += new System.EventHandler(this.buttonAddition_Click);
            // 
            // Fraction
            // 
            this.Fraction.Location = new System.Drawing.Point(6, 371);
            this.Fraction.Name = "Fraction";
            this.Fraction.Size = new System.Drawing.Size(75, 51);
            this.Fraction.TabIndex = 7;
            this.Fraction.Text = ",";
            this.Fraction.UseVisualStyleBackColor = true;
            this.Fraction.Click += new System.EventHandler(this.Fraction_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Location = new System.Drawing.Point(162, 371);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(75, 51);
            this.buttonEquals.TabIndex = 8;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(84, 371);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 51);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 11;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(162, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 50);
            this.button3.TabIndex = 12;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 51);
            this.button4.TabIndex = 13;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(84, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 51);
            this.button5.TabIndex = 14;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(162, 258);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 51);
            this.button6.TabIndex = 15;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 201);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 51);
            this.button7.TabIndex = 16;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(84, 201);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 51);
            this.button8.TabIndex = 17;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(162, 201);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 51);
            this.button9.TabIndex = 18;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // checkBoxSys
            // 
            this.checkBoxSys.AutoSize = true;
            this.checkBoxSys.Location = new System.Drawing.Point(6, 3);
            this.checkBoxSys.Name = "checkBoxSys";
            this.checkBoxSys.Size = new System.Drawing.Size(118, 17);
            this.checkBoxSys.TabIndex = 20;
            this.checkBoxSys.Text = "Перевод системы";
            this.checkBoxSys.UseVisualStyleBackColor = true;
            this.checkBoxSys.CheckedChanged += new System.EventHandler(this.checkBoxSys_CheckedChanged);
            // 
            // buttonDegree
            // 
            this.buttonDegree.Location = new System.Drawing.Point(160, 144);
            this.buttonDegree.Name = "buttonDegree";
            this.buttonDegree.Size = new System.Drawing.Size(75, 51);
            this.buttonDegree.TabIndex = 21;
            this.buttonDegree.Text = "^";
            this.buttonDegree.UseVisualStyleBackColor = true;
            this.buttonDegree.Click += new System.EventHandler(this.buttonDegree_Click);
            // 
            // buttonRounding
            // 
            this.buttonRounding.Location = new System.Drawing.Point(6, 144);
            this.buttonRounding.Name = "buttonRounding";
            this.buttonRounding.Size = new System.Drawing.Size(75, 51);
            this.buttonRounding.TabIndex = 22;
            this.buttonRounding.Text = "Round";
            this.buttonRounding.UseVisualStyleBackColor = true;
            this.buttonRounding.Click += new System.EventHandler(this.buttonRounding_Click);
            // 
            // buttonRoot
            // 
            this.buttonRoot.Location = new System.Drawing.Point(84, 144);
            this.buttonRoot.Name = "buttonRoot";
            this.buttonRoot.Size = new System.Drawing.Size(75, 51);
            this.buttonRoot.TabIndex = 23;
            this.buttonRoot.Text = "√";
            this.buttonRoot.UseVisualStyleBackColor = true;
            this.buttonRoot.Click += new System.EventHandler(this.buttonRoot_Click);
            // 
            // buttonBinary
            // 
            this.buttonBinary.Location = new System.Drawing.Point(162, 109);
            this.buttonBinary.Name = "buttonBinary";
            this.buttonBinary.Size = new System.Drawing.Size(156, 29);
            this.buttonBinary.TabIndex = 24;
            this.buttonBinary.Text = "Binary";
            this.buttonBinary.UseVisualStyleBackColor = true;
            this.buttonBinary.Visible = false;
            this.buttonBinary.Click += new System.EventHandler(this.buttonBinary_Click);
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.Location = new System.Drawing.Point(6, 109);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(150, 29);
            this.buttonDecimal.TabIndex = 25;
            this.buttonDecimal.Text = "Decimal";
            this.buttonDecimal.UseVisualStyleBackColor = true;
            this.buttonDecimal.Visible = false;
            this.buttonDecimal.Click += new System.EventHandler(this.buttonDecimal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 429);
            this.Controls.Add(this.buttonDecimal);
            this.Controls.Add(this.buttonBinary);
            this.Controls.Add(this.buttonRoot);
            this.Controls.Add(this.buttonRounding);
            this.Controls.Add(this.buttonDegree);
            this.Controls.Add(this.checkBoxSys);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.Fraction);
            this.Controls.Add(this.buttonAddition);
            this.Controls.Add(this.buttonSubtraction);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonCleanAll);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCleanAll;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonSubtraction;
        private System.Windows.Forms.Button buttonAddition;
        private System.Windows.Forms.Button Fraction;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.CheckBox checkBoxSys;
        private System.Windows.Forms.Button buttonDegree;
        private System.Windows.Forms.Button buttonRounding;
        private System.Windows.Forms.Button buttonRoot;
        private System.Windows.Forms.Button buttonBinary;
        private System.Windows.Forms.Button buttonDecimal;
    }
}

