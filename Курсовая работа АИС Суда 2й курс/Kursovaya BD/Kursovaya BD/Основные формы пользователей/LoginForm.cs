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
    
    public partial class LoginForm : Form
    {
        MySqlConnection conn;
        public LoginForm()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void L_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string Login, Password;
            Login = LoginBox.Text;
            Password = PassBox.Text;
            MySqlConnection conn = new MySqlConnection(BDLogin.SQLLogin());
            try
            {
                conn.Open();
                try
                {
                    string sql = "SELECT UserLvl,Men FROM userslogin WHERE UserName LIKE '" + Login + "' AND `Password` LIKE '" + Password + "'"; // Строка запроса
                    MySqlCommand logCom = new MySqlCommand(sql, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(logCom);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    
                    if (table.Rows.Count != 0)
                    {
                        MessageBox.Show("Успешный вход!");
                        MySqlDataReader Reader = logCom.ExecuteReader(); //ридер запроса
                        Reader.Read(); // Чтение 1й строки запроса
                        if (Reader.GetString(0) == "Admin") // Ссылка на 0 столбец запроса 
                        {
                            Admin_MainForm NewFrom = new Admin_MainForm(Reader.GetString(1),conn);
                            conn.Close();
                            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
                            NewFrom.Show();
                            this.Hide();

                        }
                        else if (Reader.GetString(0) == "SudUser")
                        {

                            SudUser NewFrom = new SudUser(Reader.GetString(1), conn);
                            conn.Close();
                            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
                            NewFrom.Show();
                            this.Hide();

                        }
                        else if (Reader.GetString(0) == "PSUser")
                        {

                            PSUserFrom NewFrom = new PSUserFrom(Reader.GetString(1), conn);
                            conn.Close();
                            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
                            NewFrom.Show();
                            this.Hide();

                        }
                        else if (Reader.GetString(0) == "AUser")
                        {

                            ArchiveForm NewFrom = new ArchiveForm(Reader.GetString(1), conn);
                            conn.Close();
                            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
                            NewFrom.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Вам не назначена роль, обратитесь к администратору!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вход неудался!");
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка с адаптером! (Обратитесь к администратору)");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка Открытия базы данных! (Обратитесь к администратору)");
            }

        }
    }
}

