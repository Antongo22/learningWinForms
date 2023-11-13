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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonVegan = new System.Windows.Forms.RadioButton();
            this.radioButtonMeat = new System.Windows.Forms.RadioButton();
            this.groupBoxMeat = new System.Windows.Forms.GroupBox();
            this.checkBoxDoubMeat = new System.Windows.Forms.CheckBox();
            this.checkBoxDobCheese = new System.Windows.Forms.CheckBox();
            this.pictureBoxMeat = new System.Windows.Forms.PictureBox();
            this.groupBoxVeg = new System.Windows.Forms.GroupBox();
            this.checkBoxVegit = new System.Windows.Forms.CheckBox();
            this.checkBoxTomatos = new System.Windows.Forms.CheckBox();
            this.pictureBoxVeg = new System.Windows.Forms.PictureBox();
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.radioButtonDelivery = new System.Windows.Forms.RadioButton();
            this.radioButtonPickup = new System.Windows.Forms.RadioButton();
            this.radioButtonHall = new System.Windows.Forms.RadioButton();
            this.labelCount = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.labelPrise = new System.Windows.Forms.Label();
            this.labelSale = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxMeat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMeat)).BeginInit();
            this.groupBoxVeg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeg)).BeginInit();
            this.groupBoxOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonVegan);
            this.groupBox1.Controls.Add(this.radioButtonMeat);
            this.groupBox1.Location = new System.Drawing.Point(8, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип пиццы";
            // 
            // radioButtonVegan
            // 
            this.radioButtonVegan.AutoSize = true;
            this.radioButtonVegan.Location = new System.Drawing.Point(89, 24);
            this.radioButtonVegan.Name = "radioButtonVegan";
            this.radioButtonVegan.Size = new System.Drawing.Size(102, 17);
            this.radioButtonVegan.TabIndex = 1;
            this.radioButtonVegan.Text = "Вегитрианская";
            this.radioButtonVegan.UseVisualStyleBackColor = true;
            this.radioButtonVegan.CheckedChanged += new System.EventHandler(this.radioButtonVegan_CheckedChanged);
            // 
            // radioButtonMeat
            // 
            this.radioButtonMeat.AutoSize = true;
            this.radioButtonMeat.Checked = true;
            this.radioButtonMeat.Location = new System.Drawing.Point(14, 24);
            this.radioButtonMeat.Name = "radioButtonMeat";
            this.radioButtonMeat.Size = new System.Drawing.Size(69, 17);
            this.radioButtonMeat.TabIndex = 0;
            this.radioButtonMeat.TabStop = true;
            this.radioButtonMeat.Text = "С мясом";
            this.radioButtonMeat.UseVisualStyleBackColor = true;
            this.radioButtonMeat.CheckedChanged += new System.EventHandler(this.radioButtonMeat_CheckedChanged);
            // 
            // groupBoxMeat
            // 
            this.groupBoxMeat.Controls.Add(this.checkBoxDoubMeat);
            this.groupBoxMeat.Controls.Add(this.checkBoxDobCheese);
            this.groupBoxMeat.Controls.Add(this.pictureBoxMeat);
            this.groupBoxMeat.Location = new System.Drawing.Point(8, 78);
            this.groupBoxMeat.Name = "groupBoxMeat";
            this.groupBoxMeat.Size = new System.Drawing.Size(197, 246);
            this.groupBoxMeat.TabIndex = 1;
            this.groupBoxMeat.TabStop = false;
            this.groupBoxMeat.Text = "Мясная";
            // 
            // checkBoxDoubMeat
            // 
            this.checkBoxDoubMeat.AutoSize = true;
            this.checkBoxDoubMeat.Location = new System.Drawing.Point(5, 222);
            this.checkBoxDoubMeat.Name = "checkBoxDoubMeat";
            this.checkBoxDoubMeat.Size = new System.Drawing.Size(100, 17);
            this.checkBoxDoubMeat.TabIndex = 2;
            this.checkBoxDoubMeat.Text = "Двойное мясо";
            this.checkBoxDoubMeat.UseVisualStyleBackColor = true;
            this.checkBoxDoubMeat.CheckedChanged += new System.EventHandler(this.checkBoxDoubMeat_CheckedChanged);
            // 
            // checkBoxDobCheese
            // 
            this.checkBoxDobCheese.AutoSize = true;
            this.checkBoxDobCheese.Location = new System.Drawing.Point(5, 199);
            this.checkBoxDobCheese.Name = "checkBoxDobCheese";
            this.checkBoxDobCheese.Size = new System.Drawing.Size(94, 17);
            this.checkBoxDobCheese.TabIndex = 1;
            this.checkBoxDobCheese.Text = "Двойной сыр";
            this.checkBoxDobCheese.UseVisualStyleBackColor = true;
            this.checkBoxDobCheese.CheckedChanged += new System.EventHandler(this.checkBoxDobCheese_CheckedChanged);
            // 
            // pictureBoxMeat
            // 
            this.pictureBoxMeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxMeat.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxMeat.Name = "pictureBoxMeat";
            this.pictureBoxMeat.Size = new System.Drawing.Size(185, 174);
            this.pictureBoxMeat.TabIndex = 0;
            this.pictureBoxMeat.TabStop = false;
            // 
            // groupBoxVeg
            // 
            this.groupBoxVeg.Controls.Add(this.checkBoxVegit);
            this.groupBoxVeg.Controls.Add(this.checkBoxTomatos);
            this.groupBoxVeg.Controls.Add(this.pictureBoxVeg);
            this.groupBoxVeg.Location = new System.Drawing.Point(211, 78);
            this.groupBoxVeg.Name = "groupBoxVeg";
            this.groupBoxVeg.Size = new System.Drawing.Size(197, 246);
            this.groupBoxVeg.TabIndex = 2;
            this.groupBoxVeg.TabStop = false;
            this.groupBoxVeg.Text = "Вегитрианская";
            // 
            // checkBoxVegit
            // 
            this.checkBoxVegit.AutoSize = true;
            this.checkBoxVegit.Location = new System.Drawing.Point(6, 222);
            this.checkBoxVegit.Name = "checkBoxVegit";
            this.checkBoxVegit.Size = new System.Drawing.Size(61, 17);
            this.checkBoxVegit.TabIndex = 2;
            this.checkBoxVegit.Text = "Овощи";
            this.checkBoxVegit.UseVisualStyleBackColor = true;
            this.checkBoxVegit.CheckedChanged += new System.EventHandler(this.checkBoxVegit_CheckedChanged);
            // 
            // checkBoxTomatos
            // 
            this.checkBoxTomatos.AutoSize = true;
            this.checkBoxTomatos.Location = new System.Drawing.Point(6, 200);
            this.checkBoxTomatos.Name = "checkBoxTomatos";
            this.checkBoxTomatos.Size = new System.Drawing.Size(66, 17);
            this.checkBoxTomatos.TabIndex = 1;
            this.checkBoxTomatos.Text = "Томаты";
            this.checkBoxTomatos.UseVisualStyleBackColor = true;
            this.checkBoxTomatos.CheckedChanged += new System.EventHandler(this.checkBoxTomatos_CheckedChanged);
            // 
            // pictureBoxVeg
            // 
            this.pictureBoxVeg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxVeg.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxVeg.Name = "pictureBoxVeg";
            this.pictureBoxVeg.Size = new System.Drawing.Size(185, 175);
            this.pictureBoxVeg.TabIndex = 0;
            this.pictureBoxVeg.TabStop = false;
            // 
            // groupBoxOrder
            // 
            this.groupBoxOrder.Controls.Add(this.radioButtonDelivery);
            this.groupBoxOrder.Controls.Add(this.radioButtonPickup);
            this.groupBoxOrder.Controls.Add(this.radioButtonHall);
            this.groupBoxOrder.Location = new System.Drawing.Point(8, 330);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Size = new System.Drawing.Size(247, 51);
            this.groupBoxOrder.TabIndex = 3;
            this.groupBoxOrder.TabStop = false;
            this.groupBoxOrder.Text = "Получение заказа";
            // 
            // radioButtonDelivery
            // 
            this.radioButtonDelivery.AutoSize = true;
            this.radioButtonDelivery.Location = new System.Drawing.Point(166, 19);
            this.radioButtonDelivery.Name = "radioButtonDelivery";
            this.radioButtonDelivery.Size = new System.Drawing.Size(75, 17);
            this.radioButtonDelivery.TabIndex = 2;
            this.radioButtonDelivery.TabStop = true;
            this.radioButtonDelivery.Text = "Доставка";
            this.radioButtonDelivery.UseVisualStyleBackColor = true;
            this.radioButtonDelivery.CheckedChanged += new System.EventHandler(this.radioButtonDelivery_CheckedChanged);
            // 
            // radioButtonPickup
            // 
            this.radioButtonPickup.AutoSize = true;
            this.radioButtonPickup.Location = new System.Drawing.Point(76, 19);
            this.radioButtonPickup.Name = "radioButtonPickup";
            this.radioButtonPickup.Size = new System.Drawing.Size(84, 17);
            this.radioButtonPickup.TabIndex = 1;
            this.radioButtonPickup.TabStop = true;
            this.radioButtonPickup.Text = "Самовывоз";
            this.radioButtonPickup.UseVisualStyleBackColor = true;
            this.radioButtonPickup.CheckedChanged += new System.EventHandler(this.radioButtonPickup_CheckedChanged);
            // 
            // radioButtonHall
            // 
            this.radioButtonHall.AutoSize = true;
            this.radioButtonHall.Checked = true;
            this.radioButtonHall.Location = new System.Drawing.Point(11, 19);
            this.radioButtonHall.Name = "radioButtonHall";
            this.radioButtonHall.Size = new System.Drawing.Size(59, 17);
            this.radioButtonHall.TabIndex = 0;
            this.radioButtonHall.TabStop = true;
            this.radioButtonHall.Text = "В зале";
            this.radioButtonHall.UseVisualStyleBackColor = true;
            this.radioButtonHall.CheckedChanged += new System.EventHandler(this.radioButtonHall_CheckedChanged);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(212, 34);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(66, 13);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "Количество";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(281, 31);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(31, 20);
            this.textBoxCount.TabIndex = 5;
            this.textBoxCount.Text = "1";
            this.textBoxCount.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
            // 
            // labelPrise
            // 
            this.labelPrise.AutoSize = true;
            this.labelPrise.Location = new System.Drawing.Point(261, 330);
            this.labelPrise.Name = "labelPrise";
            this.labelPrise.Size = new System.Drawing.Size(42, 13);
            this.labelPrise.TabIndex = 6;
            this.labelPrise.Text = "Цена - ";
            // 
            // labelSale
            // 
            this.labelSale.AutoSize = true;
            this.labelSale.Location = new System.Drawing.Point(262, 349);
            this.labelSale.Name = "labelSale";
            this.labelSale.Size = new System.Drawing.Size(50, 13);
            this.labelSale.TabIndex = 7;
            this.labelSale.Text = "Скидка -";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(262, 366);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(37, 13);
            this.labelResult.TabIndex = 8;
            this.labelResult.Text = "Итог -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 383);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelSale);
            this.Controls.Add(this.labelPrise);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.groupBoxOrder);
            this.Controls.Add(this.groupBoxVeg);
            this.Controls.Add(this.groupBoxMeat);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пицца";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxMeat.ResumeLayout(false);
            this.groupBoxMeat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMeat)).EndInit();
            this.groupBoxVeg.ResumeLayout(false);
            this.groupBoxVeg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVeg)).EndInit();
            this.groupBoxOrder.ResumeLayout(false);
            this.groupBoxOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonVegan;
        private System.Windows.Forms.RadioButton radioButtonMeat;
        private System.Windows.Forms.GroupBox groupBoxMeat;
        private System.Windows.Forms.GroupBox groupBoxVeg;
        private System.Windows.Forms.CheckBox checkBoxDoubMeat;
        private System.Windows.Forms.CheckBox checkBoxDobCheese;
        private System.Windows.Forms.PictureBox pictureBoxMeat;
        private System.Windows.Forms.CheckBox checkBoxVegit;
        private System.Windows.Forms.CheckBox checkBoxTomatos;
        private System.Windows.Forms.PictureBox pictureBoxVeg;
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private System.Windows.Forms.RadioButton radioButtonDelivery;
        private System.Windows.Forms.RadioButton radioButtonPickup;
        private System.Windows.Forms.RadioButton radioButtonHall;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label labelPrise;
        private System.Windows.Forms.Label labelSale;
        private System.Windows.Forms.Label labelResult;
    }
}

