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
    public partial class ArchiveForm : Form
    {
        string Men;
        MySqlConnection conn;
        public ArchiveForm(string M, MySqlConnection c)
        {
            Men = M;
            conn = c;
            InitializeComponent();
        }

        private void ArchiveForm_Load(object sender, EventArgs e)
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

        private void OtxBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_ark_Click(object sender, EventArgs e)
        {
            Ark_mainform f1 = new Ark_mainform();
            f1.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            f1.Show();
            this.Hide();
        }

        private void button_Nal_Click(object sender, EventArgs e)
        {
            Nalog_MainForm f1 = new Nalog_MainForm();
            f1.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            f1.Show();
            this.Hide();
        }
    }
}
