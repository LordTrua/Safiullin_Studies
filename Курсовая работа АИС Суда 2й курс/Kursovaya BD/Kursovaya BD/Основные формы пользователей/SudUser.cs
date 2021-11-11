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
    public partial class SudUser : Form
    {
        string Men;
        MySqlConnection conn;
        public SudUser(string M, MySqlConnection c)
        {
            InitializeComponent();
            Men = M; 
            conn= c;
        }

        private void SudUser_Load(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "SELECT Фамилия,Имя,Отчество FROM Работники WHERE `Номер трудового договора`=" + Men; // Строка запроса
            MySqlCommand logCom1 = new MySqlCommand(sql, conn);
            MySqlDataReader Reader = logCom1.ExecuteReader(); //ридер запроса
            Reader.Read(); // Чтение 1й строки запроса
            FamBox.Text = Reader.GetString(0);
            NameBox.Text = Reader.GetString(1);
            OtxBox.Text = Reader.GetString(2);
            NameBox.ReadOnly = true;
            FamBox.ReadOnly = true;
            OtxBox.ReadOnly = true;
            conn.Close();
        }

        private void button_add_man_Click(object sender, EventArgs e)
        {
            Add_Man f1 = new Add_Man();
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

        private void Zapros_but_Click(object sender, EventArgs e)
        {
            Op_Dela f1 = new Op_Dela();
            f1.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            f1.Show();
            this.Hide();
        }
    }
}
