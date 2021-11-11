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
    public partial class add_pred : Form
    {
        private String connectionString = null;
        private MySqlConnection sqlConnection = null;
        private MySqlDataAdapter sqlDataAdapter = null;
        private MySqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;
        string cd;
        public add_pred(string codedela)
        {
            cd = codedela;
            InitializeComponent();
        }

        private void add_pred_Load(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection(BDLogin.SQLLogin());
            selectQueryString = "SELECT * FROM предписания";
            //SELECT `idАктивного дела`,`Ход дела`,`Статус дела`,`Состав суда`,concat_ws(" ",ФИО.`Фамилия`,ФИО.`Имя`,ФИО.`Отчество`) as "ФИО подающего" ,concat_ws(" ",ФИОп.`Фамилия`,ФИОп.`Имя`,ФИОп.`Отчество`) as "ФИО получающего" FROM активные_дела left join иски ON (`Иск`=`idИска`) left join граждане as ФИО ON (`Подающий иск`=ФИО.`Номер Паспорта`)  left join граждане as ФИОп ON (`Получающий иск`=ФИОп.`Номер Паспорта`)
            sqlConnection.Open();
            sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            int tex = Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count-1][0].ToString())+1;
            textBox_num.Text = Convert.ToString(tex);
        }

        private void button_predp_Click(object sender, EventArgs e)
        {
            try
            {
                string man = textBox_man_pred.Text;
                selectQueryString = "SELECT  `Номер Паспорта` FROM граждане WHERE `Номер Паспорта`=" + man;
                sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
                sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    string saveStaff = "INSERT INTO `kursovaya`.`предписания` (`Код дела`, `Лицо, на которое распространяется`, `содержание предписания`, `Дата выдачи`) VALUES (@coddela,@man,@sod, curdate())";
                    using (MySqlCommand querySaveStaff = new MySqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = sqlConnection;
                        querySaveStaff.Parameters.AddWithValue("coddela", cd);
                        querySaveStaff.Parameters.AddWithValue("man",man);
                        querySaveStaff.Parameters.AddWithValue("sod", richTextBox1.Text);
                        querySaveStaff.ExecuteNonQuery();
                    }
                    MessageBox.Show("Предписание выдано успешно");
                }
                else
                {
                    MessageBox.Show("Гражданина нет в базе, необходимо добавить");
                    Add_Man f1 = new Add_Man();
                    f1.Show();
                }
            }
            catch
            {
                MessageBox.Show("Невозможно вынести предписание, обратитесь к администратору");
            }

        }

        }
    }

