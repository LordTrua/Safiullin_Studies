
namespace Kursovaya_BD
{
    partial class add_Nalof_Form
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
            this.label4 = new System.Windows.Forms.Label();
            this.button_oplata = new System.Windows.Forms.Button();
            this.textBox_sum = new System.Windows.Forms.TextBox();
            this.richTextBox_op = new System.Windows.Forms.RichTextBox();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оплата налога";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сумма платежа";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер иска";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Описание налога";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button_oplata
            // 
            this.button_oplata.Location = new System.Drawing.Point(231, 452);
            this.button_oplata.Name = "button_oplata";
            this.button_oplata.Size = new System.Drawing.Size(135, 49);
            this.button_oplata.TabIndex = 4;
            this.button_oplata.Text = "Оплата";
            this.button_oplata.UseVisualStyleBackColor = true;
            this.button_oplata.Click += new System.EventHandler(this.button_oplata_Click);
            // 
            // textBox_sum
            // 
            this.textBox_sum.Location = new System.Drawing.Point(22, 136);
            this.textBox_sum.Name = "textBox_sum";
            this.textBox_sum.Size = new System.Drawing.Size(141, 22);
            this.textBox_sum.TabIndex = 5;
            // 
            // richTextBox_op
            // 
            this.richTextBox_op.Location = new System.Drawing.Point(20, 286);
            this.richTextBox_op.Name = "richTextBox_op";
            this.richTextBox_op.Size = new System.Drawing.Size(344, 96);
            this.richTextBox_op.TabIndex = 7;
            this.richTextBox_op.Text = "";
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(22, 221);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(141, 22);
            this.textBox_n.TabIndex = 8;
            this.textBox_n.TextChanged += new System.EventHandler(this.textBox_n_TextChanged);
            // 
            // add_Nalof_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 513);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.richTextBox_op);
            this.Controls.Add(this.textBox_sum);
            this.Controls.Add(this.button_oplata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "add_Nalof_Form";
            this.Text = "add_Nalof_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_oplata;
        private System.Windows.Forms.TextBox textBox_sum;
        private System.Windows.Forms.RichTextBox richTextBox_op;
        private System.Windows.Forms.TextBox textBox_n;
    }
}