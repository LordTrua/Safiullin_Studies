
namespace Kursovaya_BD
{
    partial class Op_Dela
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
            this.button_op_delo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_zased = new System.Windows.Forms.Button();
            this.button_del_delo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(902, 318);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_op_delo
            // 
            this.button_op_delo.Location = new System.Drawing.Point(684, 437);
            this.button_op_delo.Name = "button_op_delo";
            this.button_op_delo.Size = new System.Drawing.Size(230, 95);
            this.button_op_delo.TabIndex = 1;
            this.button_op_delo.Text = "Открыть дело";
            this.button_op_delo.UseVisualStyleBackColor = true;
            this.button_op_delo.Click += new System.EventHandler(this.button_op_delo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Открытые дела";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(584, 437);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(94, 95);
            this.button_update.TabIndex = 3;
            this.button_update.Text = "Обновить";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_zased
            // 
            this.button_zased.Location = new System.Drawing.Point(337, 438);
            this.button_zased.Name = "button_zased";
            this.button_zased.Size = new System.Drawing.Size(241, 94);
            this.button_zased.TabIndex = 4;
            this.button_zased.Text = "Начать заседание по делу";
            this.button_zased.UseVisualStyleBackColor = true;
            this.button_zased.Click += new System.EventHandler(this.button_zased_Click);
            // 
            // button_del_delo
            // 
            this.button_del_delo.Location = new System.Drawing.Point(12, 438);
            this.button_del_delo.Name = "button_del_delo";
            this.button_del_delo.Size = new System.Drawing.Size(219, 94);
            this.button_del_delo.TabIndex = 5;
            this.button_del_delo.Text = "Удалить";
            this.button_del_delo.UseVisualStyleBackColor = true;
            this.button_del_delo.Click += new System.EventHandler(this.button_del_delo_Click);
            // 
            // Op_Dela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 544);
            this.Controls.Add(this.button_del_delo);
            this.Controls.Add(this.button_zased);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_op_delo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Op_Dela";
            this.Text = "Открытые дела";
            this.Load += new System.EventHandler(this.Op_Dela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_op_delo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_zased;
        private System.Windows.Forms.Button button_del_delo;
    }
}