
namespace Kursovaya_BD
{
    partial class ArchiveForm
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
            this.OtxBox = new System.Windows.Forms.TextBox();
            this.FamBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.button_ark = new System.Windows.Forms.Button();
            this.button_Nal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Вы вошли как:";
            // 
            // OtxBox
            // 
            this.OtxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OtxBox.Location = new System.Drawing.Point(483, 6);
            this.OtxBox.Name = "OtxBox";
            this.OtxBox.Size = new System.Drawing.Size(151, 28);
            this.OtxBox.TabIndex = 6;
            this.OtxBox.TextChanged += new System.EventHandler(this.OtxBox_TextChanged);
            // 
            // FamBox
            // 
            this.FamBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FamBox.Location = new System.Drawing.Point(162, 6);
            this.FamBox.Name = "FamBox";
            this.FamBox.Size = new System.Drawing.Size(159, 28);
            this.FamBox.TabIndex = 5;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(327, 6);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(150, 28);
            this.NameBox.TabIndex = 4;
            // 
            // button_ark
            // 
            this.button_ark.Location = new System.Drawing.Point(17, 79);
            this.button_ark.Name = "button_ark";
            this.button_ark.Size = new System.Drawing.Size(266, 91);
            this.button_ark.TabIndex = 14;
            this.button_ark.Text = "Архив";
            this.button_ark.UseVisualStyleBackColor = true;
            this.button_ark.Click += new System.EventHandler(this.button_ark_Click);
            // 
            // button_Nal
            // 
            this.button_Nal.Location = new System.Drawing.Point(17, 176);
            this.button_Nal.Name = "button_Nal";
            this.button_Nal.Size = new System.Drawing.Size(266, 91);
            this.button_Nal.TabIndex = 15;
            this.button_Nal.Text = "Налоги и сборы";
            this.button_Nal.UseVisualStyleBackColor = true;
            this.button_Nal.Click += new System.EventHandler(this.button_Nal_Click);
            // 
            // ArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 288);
            this.Controls.Add(this.button_Nal);
            this.Controls.Add(this.button_ark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OtxBox);
            this.Controls.Add(this.FamBox);
            this.Controls.Add(this.NameBox);
            this.Name = "ArchiveForm";
            this.Text = "Сотрудник архива";
            this.Load += new System.EventHandler(this.ArchiveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OtxBox;
        private System.Windows.Forms.TextBox FamBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button button_ark;
        private System.Windows.Forms.Button button_Nal;
    }
}