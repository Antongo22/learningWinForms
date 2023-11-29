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
            this.настройкиФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonShowProducts = new System.Windows.Forms.Button();
            this.buttonMidPrise = new System.Windows.Forms.Button();
            this.buttonSumGroup = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxGoup = new System.Windows.Forms.TextBox();
            this.textBoxPrise = new System.Windows.Forms.TextBox();
            this.textBoxWarehouse = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // настройкиФонаToolStripMenuItem
            // 
            this.настройкиФонаToolStripMenuItem.Name = "настройкиФонаToolStripMenuItem";
            this.настройкиФонаToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // buttonShowProducts
            // 
            this.buttonShowProducts.Location = new System.Drawing.Point(448, 41);
            this.buttonShowProducts.Name = "buttonShowProducts";
            this.buttonShowProducts.Size = new System.Drawing.Size(75, 23);
            this.buttonShowProducts.TabIndex = 0;
            this.buttonShowProducts.Text = "Показать";
            this.buttonShowProducts.UseVisualStyleBackColor = true;
            this.buttonShowProducts.Click += new System.EventHandler(this.buttonShowProducts_Click);
            // 
            // buttonMidPrise
            // 
            this.buttonMidPrise.Location = new System.Drawing.Point(12, 41);
            this.buttonMidPrise.Name = "buttonMidPrise";
            this.buttonMidPrise.Size = new System.Drawing.Size(186, 23);
            this.buttonMidPrise.TabIndex = 1;
            this.buttonMidPrise.Text = "Средняя стоимость по складу";
            this.buttonMidPrise.UseVisualStyleBackColor = true;
            this.buttonMidPrise.Click += new System.EventHandler(this.buttonMidPrise_Click);
            // 
            // buttonSumGroup
            // 
            this.buttonSumGroup.Location = new System.Drawing.Point(204, 41);
            this.buttonSumGroup.Name = "buttonSumGroup";
            this.buttonSumGroup.Size = new System.Drawing.Size(184, 23);
            this.buttonSumGroup.TabIndex = 2;
            this.buttonSumGroup.Text = "Суммарная стоимость группы";
            this.buttonSumGroup.UseVisualStyleBackColor = true;
            this.buttonSumGroup.Click += new System.EventHandler(this.buttonSumGroup_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 15);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(128, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxGoup
            // 
            this.textBoxGoup.Location = new System.Drawing.Point(146, 15);
            this.textBoxGoup.Name = "textBoxGoup";
            this.textBoxGoup.Size = new System.Drawing.Size(130, 20);
            this.textBoxGoup.TabIndex = 4;
            // 
            // textBoxPrise
            // 
            this.textBoxPrise.Location = new System.Drawing.Point(282, 15);
            this.textBoxPrise.Name = "textBoxPrise";
            this.textBoxPrise.Size = new System.Drawing.Size(72, 20);
            this.textBoxPrise.TabIndex = 5;
            // 
            // textBoxWarehouse
            // 
            this.textBoxWarehouse.Location = new System.Drawing.Point(360, 15);
            this.textBoxWarehouse.Name = "textBoxWarehouse";
            this.textBoxWarehouse.Size = new System.Drawing.Size(82, 20);
            this.textBoxWarehouse.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(448, 15);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 76);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxWarehouse);
            this.Controls.Add(this.textBoxPrise);
            this.Controls.Add(this.textBoxGoup);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonSumGroup);
            this.Controls.Add(this.buttonMidPrise);
            this.Controls.Add(this.buttonShowProducts);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem настройкиФонаToolStripMenuItem;
        private System.Windows.Forms.Button buttonShowProducts;
        private System.Windows.Forms.Button buttonMidPrise;
        private System.Windows.Forms.Button buttonSumGroup;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxGoup;
        private System.Windows.Forms.TextBox textBoxPrise;
        private System.Windows.Forms.TextBox textBoxWarehouse;
        private System.Windows.Forms.Button buttonAdd;
    }
}

