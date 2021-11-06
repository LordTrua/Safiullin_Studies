namespace LabRabota_4_BKIT
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFileReadTime = new System.Windows.Forms.TextBox();
            this.textBoxFileReadCount = new System.Windows.Forms.TextBox();
            this.button_Text_Load = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxExactTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_SaveOtch = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Кол-во уникальных слов в файле:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Время чтения файла:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxFileReadTime
            // 
            this.textBoxFileReadTime.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxFileReadTime.Location = new System.Drawing.Point(488, 8);
            this.textBoxFileReadTime.Name = "textBoxFileReadTime";
            this.textBoxFileReadTime.Size = new System.Drawing.Size(231, 22);
            this.textBoxFileReadTime.TabIndex = 2;
            this.textBoxFileReadTime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxFileReadCount
            // 
            this.textBoxFileReadCount.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxFileReadCount.Location = new System.Drawing.Point(566, 33);
            this.textBoxFileReadCount.Name = "textBoxFileReadCount";
            this.textBoxFileReadCount.Size = new System.Drawing.Size(153, 22);
            this.textBoxFileReadCount.TabIndex = 3;
            this.textBoxFileReadCount.TextChanged += new System.EventHandler(this.textBoxFileReadCount_TextChanged);
            // 
            // button_Text_Load
            // 
            this.button_Text_Load.Location = new System.Drawing.Point(12, 8);
            this.button_Text_Load.Name = "button_Text_Load";
            this.button_Text_Load.Size = new System.Drawing.Size(155, 33);
            this.button_Text_Load.TabIndex = 4;
            this.button_Text_Load.Text = "Чтение файла";
            this.button_Text_Load.UseVisualStyleBackColor = true;
            this.button_Text_Load.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(155, 63);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(252, 22);
            this.textBoxFind.TabIndex = 6;
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Слово для поиска: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 33);
            this.button4.TabIndex = 7;
            this.button4.Text = "Поиск";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxExactTime
            // 
            this.textBoxExactTime.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxExactTime.Location = new System.Drawing.Point(467, 103);
            this.textBoxExactTime.Name = "textBoxExactTime";
            this.textBoxExactTime.Size = new System.Drawing.Size(252, 22);
            this.textBoxExactTime.TabIndex = 9;
            this.textBoxExactTime.TextChanged += new System.EventHandler(this.textBoxExactTime_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Время поиска:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button_SaveOtch
            // 
            this.button_SaveOtch.Location = new System.Drawing.Point(1, 577);
            this.button_SaveOtch.Name = "button_SaveOtch";
            this.button_SaveOtch.Size = new System.Drawing.Size(202, 33);
            this.button_SaveOtch.TabIndex = 18;
            this.button_SaveOtch.Text = "Сохранить отчёт";
            this.button_SaveOtch.UseVisualStyleBackColor = true;
            this.button_SaveOtch.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(530, 577);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(189, 33);
            this.button_Exit.TabIndex = 19;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button7_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 16;
            this.listBoxResult.Location = new System.Drawing.Point(12, 255);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(707, 308);
            this.listBoxResult.TabIndex = 22;
            this.listBoxResult.SelectedIndexChanged += new System.EventHandler(this.listBoxResult_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 56);
            this.button3.TabIndex = 24;
            this.button3.Text = "Параллельный нечёткий поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(574, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 22);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(574, 217);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 22);
            this.textBox3.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(335, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Максимальное расстояние для нечёткого поиска";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Время нечёткого поиска";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(731, 622);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_SaveOtch);
            this.Controls.Add(this.textBoxExactTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Text_Load);
            this.Controls.Add(this.textBoxFileReadCount);
            this.Controls.Add(this.textBoxFileReadTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Load_File;
        private System.Windows.Forms.TextBox text_Box_Count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Text_Load;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_SaveOtch;
        private System.Windows.Forms.Button button_Exit;
        public System.Windows.Forms.TextBox textBoxFileReadTime;
        public System.Windows.Forms.TextBox textBoxFileReadCount;
        public System.Windows.Forms.TextBox textBoxFind;
        public System.Windows.Forms.TextBox textBoxExactTime;
        protected System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}

