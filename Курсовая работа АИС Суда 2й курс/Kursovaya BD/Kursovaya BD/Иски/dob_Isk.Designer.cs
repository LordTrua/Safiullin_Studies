
namespace Kursovaya_BD
{
    partial class dob_Isk
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
            this.button_iskadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.textBox_pass_a = new System.Windows.Forms.TextBox();
            this.richTextBox_iskk = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_iskadd
            // 
            this.button_iskadd.Location = new System.Drawing.Point(595, 496);
            this.button_iskadd.Name = "button_iskadd";
            this.button_iskadd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_iskadd.Size = new System.Drawing.Size(202, 80);
            this.button_iskadd.TabIndex = 0;
            this.button_iskadd.Text = "Подать иск";
            this.button_iskadd.UseVisualStyleBackColor = true;
            this.button_iskadd.Click += new System.EventHandler(this.button_iskadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ваш номер паспорта:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Изложите иск:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Номер паспорта гражданина, которому адрпесован иск:";
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(17, 45);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(199, 22);
            this.textBox_pass.TabIndex = 4;
            // 
            // textBox_pass_a
            // 
            this.textBox_pass_a.Location = new System.Drawing.Point(17, 473);
            this.textBox_pass_a.Name = "textBox_pass_a";
            this.textBox_pass_a.Size = new System.Drawing.Size(376, 22);
            this.textBox_pass_a.TabIndex = 6;
            // 
            // richTextBox_iskk
            // 
            this.richTextBox_iskk.Location = new System.Drawing.Point(17, 129);
            this.richTextBox_iskk.Name = "richTextBox_iskk";
            this.richTextBox_iskk.Size = new System.Drawing.Size(766, 305);
            this.richTextBox_iskk.TabIndex = 8;
            this.richTextBox_iskk.Text = "";
            // 
            // dob_Isk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 588);
            this.Controls.Add(this.richTextBox_iskk);
            this.Controls.Add(this.textBox_pass_a);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_iskadd);
            this.Name = "dob_Isk";
            this.Text = "Добавление иска";
            this.Load += new System.EventHandler(this.dob_Isk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_iskadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.TextBox textBox_pass_a;
        private System.Windows.Forms.RichTextBox richTextBox_iskk;
    }
}