using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kursovaya_BD
{
    public partial class Admin_MainForm : Form
    {
        string Men;
        MySqlConnection conn;
        public Admin_MainForm(string M, MySqlConnection c)
        {
            Men = M;
            conn = c;
            InitializeComponent();
        }
        private void Admin_MainForm_Load(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "SELECT Фамилия,Имя,Отчество FROM Работники WHERE `Номер трудового договора`=" + Men ; // Строка запроса
            MySqlCommand logCom1 = new MySqlCommand(sql, conn);
            MySqlDataReader Reader = logCom1.ExecuteReader(); //ридер запроса
            Reader.Read(); // Чтение 1й строки запроса
            FamBox.Text = Reader.GetString(0);
            NameBox.Text = Reader.GetString(1);
            OtxBox.Text= Reader.GetString(2);
            NameBox.ReadOnly = true;
            FamBox.ReadOnly = true;
            OtxBox.ReadOnly = true;
            conn.Close();
        }

        private void Form_Button_Click(object sender, EventArgs e)
        {
            Admin_WorkFrom f1 = new Admin_WorkFrom();
            f1.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            f1.Show();
            this.Hide();
        }

        private void Zapros_but_Click(object sender, EventArgs e)
        {
            Op_Dela  f1 = new Op_Dela();
            f1.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            f1.Show();
            this.Hide();
        }

        private void button_isk_Click(object sender, EventArgs e)
        {
            Op_isks f1 = new Op_isks();
            f1.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            f1.Show();
            this.Hide();
        }

        private void button_add_man_Click(object sender, EventArgs e)
        {
            Add_Man f1 = new Add_Man();
            f1.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            f1.Show();
            this.Hide();
        }

        private void button_Nal_Click(object sender, EventArgs e)
        {
            Nalog_MainForm f1 = new Nalog_MainForm();
            f1.FormClosed+=(object s, FormClosedEventArgs args)=>{ this.Show(); };
            f1.Show();
            this.Hide();
        }

        private void Otchet_Button_Click(object sender, EventArgs e)
        {

        }

        private void button_ark_Click(object sender, EventArgs e)
        {
            Ark_mainform f1 = new Ark_mainform();
            f1.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            f1.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
