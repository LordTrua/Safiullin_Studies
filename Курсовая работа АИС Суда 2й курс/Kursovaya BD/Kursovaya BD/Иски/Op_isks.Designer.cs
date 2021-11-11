
namespace Kursovaya_BD
{
    partial class Op_isks
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
            this.button_Add_Isk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_num = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 396);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_Add_Isk
            // 
            this.button_Add_Isk.Location = new System.Drawing.Point(814, 487);
            this.button_Add_Isk.Name = "button_Add_Isk";
            this.button_Add_Isk.Size = new System.Drawing.Size(216, 103);
            this.button_Add_Isk.TabIndex = 1;
            this.button_Add_Isk.Text = "Добавить иск";
            this.button_Add_Isk.UseVisualStyleBackColor = true;
            this.button_Add_Isk.Click += new System.EventHandler(this.button_Add_Isk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поданые иски";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(592, 487);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 103);
            this.button2.TabIndex = 5;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(12, 496);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(186, 103);
            this.button_Del.TabIndex = 6;
            this.button_Del.Text = "Удалить";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Номер выбраного иска";
            // 
            // textBox_num
            // 
            this.textBox_num.Location = new System.Drawing.Point(243, 517);
            this.textBox_num.Name = "textBox_num";
            this.textBox_num.ReadOnly = true;
            this.textBox_num.Size = new System.Drawing.Size(156, 22);
            this.textBox_num.TabIndex = 8;
            // 
            // Op_isks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 602);
            this.Controls.Add(this.textBox_num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Add_Isk);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Op_isks";
            this.Text = "Op_isks";
            this.Load += new System.EventHandler(this.Op_isks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Add_Isk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_num;
    }
}