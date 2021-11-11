
namespace Kursovaya_BD
{
    partial class Admin_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_MainForm));
            this.NameBox = new System.Windows.Forms.TextBox();
            this.FamBox = new System.Windows.Forms.TextBox();
            this.OtxBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Form_Button = new System.Windows.Forms.Button();
            this.Zapros_but = new System.Windows.Forms.Button();
            this.button_isk = new System.Windows.Forms.Button();
            this.button_add_man = new System.Windows.Forms.Button();
            this.button_Nal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_ark = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(399, 12);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(162, 28);
            this.NameBox.TabIndex = 0;
            // 
            // FamBox
            // 
            this.FamBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FamBox.Location = new System.Drawing.Point(222, 12);
            this.FamBox.Name = "FamBox";
            this.FamBox.Size = new System.Drawing.Size(171, 28);
            this.FamBox.TabIndex = 1;
            // 
            // OtxBox
            // 
            this.OtxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OtxBox.Location = new System.Drawing.Point(567, 12);
            this.OtxBox.Name = "OtxBox";
            this.OtxBox.Size = new System.Drawing.Size(163, 28);
            this.OtxBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вы вошли как:";
            // 
            // Form_Button
            // 
            this.Form_Button.Location = new System.Drawing.Point(12, 97);
            this.Form_Button.Name = "Form_Button";
            this.Form_Button.Size = new System.Drawing.Size(266, 91);
            this.Form_Button.TabIndex = 4;
            this.Form_Button.Text = "Работники";
            this.Form_Button.UseVisualStyleBackColor = true;
            this.Form_Button.Click += new System.EventHandler(this.Form_Button_Click);
            // 
            // Zapros_but
            // 
            this.Zapros_but.Location = new System.Drawing.Point(284, 295);
            this.Zapros_but.Name = "Zapros_but";
            this.Zapros_but.Size = new System.Drawing.Size(273, 93);
            this.Zapros_but.TabIndex = 5;
            this.Zapros_but.Text = "Открытые дела";
            this.Zapros_but.UseVisualStyleBackColor = true;
            this.Zapros_but.Click += new System.EventHandler(this.Zapros_but_Click);
            // 
            // button_isk
            // 
            this.button_isk.Location = new System.Drawing.Point(284, 196);
            this.button_isk.Name = "button_isk";
            this.button_isk.Size = new System.Drawing.Size(273, 93);
            this.button_isk.TabIndex = 7;
            this.button_isk.Text = "Иски ";
            this.button_isk.UseVisualStyleBackColor = true;
            this.button_isk.Click += new System.EventHandler(this.button_isk_Click);
            // 
            // button_add_man
            // 
            this.button_add_man.Location = new System.Drawing.Point(284, 97);
            this.button_add_man.Name = "button_add_man";
            this.button_add_man.Size = new System.Drawing.Size(273, 93);
            this.button_add_man.TabIndex = 8;
            this.button_add_man.Text = "Добавить гражданина";
            this.button_add_man.UseVisualStyleBackColor = true;
            this.button_add_man.Click += new System.EventHandler(this.button_add_man_Click);
            // 
            // button_Nal
            // 
            this.button_Nal.Location = new System.Drawing.Point(12, 297);
            this.button_Nal.Name = "button_Nal";
            this.button_Nal.Size = new System.Drawing.Size(266, 91);
            this.button_Nal.TabIndex = 9;
            this.button_Nal.Text = "Налоги и сборы";
            this.button_Nal.UseVisualStyleBackColor = true;
            this.button_Nal.Click += new System.EventHandler(this.button_Nal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(300, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "Судебные дела";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 38);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ратация кадров";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 38);
            this.label4.TabIndex = 12;
            this.label4.Text = "Налоги";
            // 
            // button_ark
            // 
            this.button_ark.Location = new System.Drawing.Point(563, 296);
            this.button_ark.Name = "button_ark";
            this.button_ark.Size = new System.Drawing.Size(266, 91);
            this.button_ark.TabIndex = 13;
            this.button_ark.Text = "Архив";
            this.button_ark.UseVisualStyleBackColor = true;
            this.button_ark.Click += new System.EventHandler(this.button_ark_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(563, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Admin_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 404);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_ark);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Nal);
            this.Controls.Add(this.button_add_man);
            this.Controls.Add(this.button_isk);
            this.Controls.Add(this.Zapros_but);
            this.Controls.Add(this.Form_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OtxBox);
            this.Controls.Add(this.FamBox);
            this.Controls.Add(this.NameBox);
            this.Name = "Admin_MainForm";
            this.Text = "Председательская форма";
            this.Load += new System.EventHandler(this.Admin_MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox FamBox;
        private System.Windows.Forms.TextBox OtxBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Form_Button;
        private System.Windows.Forms.Button Zapros_but;
        private System.Windows.Forms.Button button_isk;
        private System.Windows.Forms.Button button_add_man;
        private System.Windows.Forms.Button button_Nal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_ark;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}