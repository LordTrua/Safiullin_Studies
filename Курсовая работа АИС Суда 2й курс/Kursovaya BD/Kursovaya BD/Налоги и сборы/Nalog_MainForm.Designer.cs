
namespace Kursovaya_BD
{
    partial class Nalog_MainForm
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
            this.button_add_nal = new System.Windows.Forms.Button();
            this.button_del_nal = new System.Windows.Forms.Button();
            this.button_up_nal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_add_nal
            // 
            this.button_add_nal.Location = new System.Drawing.Point(613, 406);
            this.button_add_nal.Name = "button_add_nal";
            this.button_add_nal.Size = new System.Drawing.Size(178, 92);
            this.button_add_nal.TabIndex = 2;
            this.button_add_nal.Text = "Добавить налог";
            this.button_add_nal.UseVisualStyleBackColor = true;
            this.button_add_nal.Click += new System.EventHandler(this.button_add_nal_Click);
            // 
            // button_del_nal
            // 
            this.button_del_nal.Location = new System.Drawing.Point(25, 407);
            this.button_del_nal.Name = "button_del_nal";
            this.button_del_nal.Size = new System.Drawing.Size(190, 88);
            this.button_del_nal.TabIndex = 3;
            this.button_del_nal.Text = "Удалить налог";
            this.button_del_nal.UseVisualStyleBackColor = true;
            this.button_del_nal.Click += new System.EventHandler(this.button_del_nal_Click);
            // 
            // button_up_nal
            // 
            this.button_up_nal.Location = new System.Drawing.Point(306, 406);
            this.button_up_nal.Name = "button_up_nal";
            this.button_up_nal.Size = new System.Drawing.Size(216, 92);
            this.button_up_nal.TabIndex = 5;
            this.button_up_nal.Text = "Обновить";
            this.button_up_nal.UseVisualStyleBackColor = true;
            this.button_up_nal.Click += new System.EventHandler(this.button_up_nal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Налоги и сборы";
            // 
            // Nalog_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_up_nal);
            this.Controls.Add(this.button_del_nal);
            this.Controls.Add(this.button_add_nal);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Nalog_MainForm";
            this.Text = "Nalog_MainForm";
            this.Load += new System.EventHandler(this.Nalog_MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_add_nal;
        private System.Windows.Forms.Button button_del_nal;
        private System.Windows.Forms.Button button_up_nal;
        private System.Windows.Forms.Label label1;
    }
}