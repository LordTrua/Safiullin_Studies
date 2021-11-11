
namespace Kursovaya_BD
{
    partial class SudUser
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
            this.button_add_man = new System.Windows.Forms.Button();
            this.button_isk = new System.Windows.Forms.Button();
            this.Zapros_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Вы вошли как:";
            // 
            // OtxBox
            // 
            this.OtxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OtxBox.Location = new System.Drawing.Point(563, 12);
            this.OtxBox.Name = "OtxBox";
            this.OtxBox.Size = new System.Drawing.Size(163, 28);
            this.OtxBox.TabIndex = 6;
            // 
            // FamBox
            // 
            this.FamBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FamBox.Location = new System.Drawing.Point(218, 12);
            this.FamBox.Name = "FamBox";
            this.FamBox.Size = new System.Drawing.Size(171, 28);
            this.FamBox.TabIndex = 5;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(395, 12);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(162, 28);
            this.NameBox.TabIndex = 4;
            // 
            // button_add_man
            // 
            this.button_add_man.Location = new System.Drawing.Point(10, 46);
            this.button_add_man.Name = "button_add_man";
            this.button_add_man.Size = new System.Drawing.Size(273, 93);
            this.button_add_man.TabIndex = 11;
            this.button_add_man.Text = "Добавить гражданина";
            this.button_add_man.UseVisualStyleBackColor = true;
            this.button_add_man.Click += new System.EventHandler(this.button_add_man_Click);
            // 
            // button_isk
            // 
            this.button_isk.Location = new System.Drawing.Point(10, 145);
            this.button_isk.Name = "button_isk";
            this.button_isk.Size = new System.Drawing.Size(273, 93);
            this.button_isk.TabIndex = 10;
            this.button_isk.Text = "Иски ";
            this.button_isk.UseVisualStyleBackColor = true;
            this.button_isk.Click += new System.EventHandler(this.button_isk_Click);
            // 
            // Zapros_but
            // 
            this.Zapros_but.Location = new System.Drawing.Point(10, 244);
            this.Zapros_but.Name = "Zapros_but";
            this.Zapros_but.Size = new System.Drawing.Size(273, 93);
            this.Zapros_but.TabIndex = 9;
            this.Zapros_but.Text = "Открытые дела";
            this.Zapros_but.UseVisualStyleBackColor = true;
            this.Zapros_but.Click += new System.EventHandler(this.Zapros_but_Click);
            // 
            // SudUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 349);
            this.Controls.Add(this.button_add_man);
            this.Controls.Add(this.button_isk);
            this.Controls.Add(this.Zapros_but);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OtxBox);
            this.Controls.Add(this.FamBox);
            this.Controls.Add(this.NameBox);
            this.Name = "SudUser";
            this.Text = "Судья";
            this.Load += new System.EventHandler(this.SudUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OtxBox;
        private System.Windows.Forms.TextBox FamBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button button_add_man;
        private System.Windows.Forms.Button button_isk;
        private System.Windows.Forms.Button Zapros_but;
    }
}