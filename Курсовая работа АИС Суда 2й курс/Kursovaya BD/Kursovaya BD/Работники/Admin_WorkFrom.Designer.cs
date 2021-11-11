
namespace Kursovaya_BD
{
    partial class Admin_WorkFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_sostavs_ch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(875, 347);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Работники";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 92);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить работника";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(18, 417);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(186, 92);
            this.button_Del.TabIndex = 3;
            this.button_Del.Text = "Удалить";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 92);
            this.button2.TabIndex = 4;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_sostavs_ch
            // 
            this.button_sostavs_ch.Location = new System.Drawing.Point(210, 417);
            this.button_sostavs_ch.Name = "button_sostavs_ch";
            this.button_sostavs_ch.Size = new System.Drawing.Size(230, 92);
            this.button_sostavs_ch.TabIndex = 5;
            this.button_sostavs_ch.Text = "Изменить данные о сотруднике";
            this.button_sostavs_ch.UseVisualStyleBackColor = true;
            this.button_sostavs_ch.Click += new System.EventHandler(this.button_sostavs_ch_Click);
            // 
            // Admin_WorkFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 521);
            this.Controls.Add(this.button_sostavs_ch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin_WorkFrom";
            this.Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_sostavs_ch;
    }
}