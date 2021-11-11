
namespace Kursovaya_BD
{
    partial class add_pred
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_num = new System.Windows.Forms.TextBox();
            this.button_predp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_man_pred = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 80);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(720, 349);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Предписание №";
            // 
            // textBox_num
            // 
            this.textBox_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_num.Location = new System.Drawing.Point(265, 29);
            this.textBox_num.Name = "textBox_num";
            this.textBox_num.Size = new System.Drawing.Size(128, 38);
            this.textBox_num.TabIndex = 2;
            // 
            // button_predp
            // 
            this.button_predp.Location = new System.Drawing.Point(540, 436);
            this.button_predp.Name = "button_predp";
            this.button_predp.Size = new System.Drawing.Size(210, 102);
            this.button_predp.TabIndex = 3;
            this.button_predp.Text = "Вынести предписание";
            this.button_predp.UseVisualStyleBackColor = true;
            this.button_predp.Click += new System.EventHandler(this.button_predp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(482, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Лицо, на которое, распространяется предписание";
            // 
            // textBox_man_pred
            // 
            this.textBox_man_pred.Location = new System.Drawing.Point(31, 465);
            this.textBox_man_pred.Name = "textBox_man_pred";
            this.textBox_man_pred.Size = new System.Drawing.Size(228, 22);
            this.textBox_man_pred.TabIndex = 5;
            // 
            // add_pred
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.textBox_man_pred);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_predp);
            this.Controls.Add(this.textBox_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "add_pred";
            this.Text = "Добавить предписание";
            this.Load += new System.EventHandler(this.add_pred_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_num;
        private System.Windows.Forms.Button button_predp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_man_pred;
    }
}