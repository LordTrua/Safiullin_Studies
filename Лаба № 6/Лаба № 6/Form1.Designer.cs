namespace Лаба___6
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
            this.button1 = new System.Windows.Forms.Button();
            this.Param1_textBox = new System.Windows.Forms.TextBox();
            this.Param2_textBox = new System.Windows.Forms.TextBox();
            this.Param3_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 89);
            this.button1.TabIndex = 0;
            this.button1.Text = "Тык";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Param1_textBox
            // 
            this.Param1_textBox.Location = new System.Drawing.Point(316, 35);
            this.Param1_textBox.Name = "Param1_textBox";
            this.Param1_textBox.Size = new System.Drawing.Size(262, 22);
            this.Param1_textBox.TabIndex = 1;
            this.Param1_textBox.TextChanged += new System.EventHandler(this.Param1_textBox_TextChanged);
            // 
            // Param2_textBox
            // 
            this.Param2_textBox.Location = new System.Drawing.Point(316, 82);
            this.Param2_textBox.Name = "Param2_textBox";
            this.Param2_textBox.Size = new System.Drawing.Size(262, 22);
            this.Param2_textBox.TabIndex = 2;
            this.Param2_textBox.TextChanged += new System.EventHandler(this.Param2_textBox_TextChanged);
            // 
            // Param3_textBox
            // 
            this.Param3_textBox.Location = new System.Drawing.Point(316, 133);
            this.Param3_textBox.Name = "Param3_textBox";
            this.Param3_textBox.Size = new System.Drawing.Size(262, 22);
            this.Param3_textBox.TabIndex = 3;
            this.Param3_textBox.TextChanged += new System.EventHandler(this.Param3_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Текст сюда";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Цифирки сюда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цифирки сюда, но другие";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 210);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(923, 84);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(296, 89);
            this.button2.TabIndex = 8;
            this.button2.Text = "Переход на 2ю часть лабы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Param3_textBox);
            this.Controls.Add(this.Param2_textBox);
            this.Controls.Add(this.Param1_textBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Param1_textBox;
        private System.Windows.Forms.TextBox Param2_textBox;
        private System.Windows.Forms.TextBox Param3_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
    }
}

