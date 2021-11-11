
namespace Kursovaya_BD
{
    partial class Add_new_delo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_delo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_sost = new System.Windows.Forms.ComboBox();
            this.comboBox_num_isk = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дело №";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Состав суда, приступающий к делу:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(577, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер иска, по которому будет объявлено дело:";
            // 
            // textBox_delo
            // 
            this.textBox_delo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_delo.Location = new System.Drawing.Point(165, 6);
            this.textBox_delo.Name = "textBox_delo";
            this.textBox_delo.Size = new System.Drawing.Size(153, 49);
            this.textBox_delo.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 77);
            this.button1.TabIndex = 6;
            this.button1.Text = "Открыть дело";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_sost
            // 
            this.comboBox_sost.FormattingEnabled = true;
            this.comboBox_sost.Location = new System.Drawing.Point(436, 72);
            this.comboBox_sost.Name = "comboBox_sost";
            this.comboBox_sost.Size = new System.Drawing.Size(311, 24);
            this.comboBox_sost.TabIndex = 7;
            this.comboBox_sost.SelectedIndexChanged += new System.EventHandler(this.comboBox_sost_SelectedIndexChanged);
            // 
            // comboBox_num_isk
            // 
            this.comboBox_num_isk.FormattingEnabled = true;
            this.comboBox_num_isk.Location = new System.Drawing.Point(596, 114);
            this.comboBox_num_isk.Name = "comboBox_num_isk";
            this.comboBox_num_isk.Size = new System.Drawing.Size(151, 24);
            this.comboBox_num_isk.TabIndex = 8;
            // 
            // Add_new_delo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 241);
            this.Controls.Add(this.comboBox_num_isk);
            this.Controls.Add(this.comboBox_sost);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_delo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_new_delo";
            this.Text = "Добавление дела";
            this.Load += new System.EventHandler(this.Add_new_delo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_delo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_sost;
        private System.Windows.Forms.ComboBox comboBox_num_isk;
    }
}