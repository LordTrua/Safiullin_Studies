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

    public partial class add_Resh : Form
    {
        private String connectionString = null;
        private MySqlConnection sqlConnection = null;
        private MySqlDataAdapter sqlDataAdapter = null;
        private MySqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;
        int nomdel;
        string pol, pod;
        int nomresh;
        public add_Resh(int nd, string pod1,string pol1)
        {
            pod = pod1;
            pol = pol1;
            nomdel = nd;
            nomresh = nd;
            InitializeComponent();
        }

        private void add_Resh_Load(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection(BDLogin.SQLLogin());
            selectQueryString = "SELECT `idРешения суда` FROM решения_суда";
            //SELECT `idАктивного дела`,`Ход дела`,`Статус дела`,`Состав суда`,concat_ws(" ",ФИО.`Фамилия`,ФИО.`Имя`,ФИО.`Отчество`) as "ФИО подающего" ,concat_ws(" ",ФИОп.`Фамилия`,ФИОп.`Имя`,ФИОп.`Отчество`) as "ФИО получающего" FROM активные_дела left join иски ON (`Иск`=`idИска`) left join граждане as ФИО ON (`Подающий иск`=ФИО.`Номер Паспорта`)  left join граждане as ФИОп ON (`Получающий иск`=ФИОп.`Номер Паспорта`)
            sqlConnection.Open();
            sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            textBox_num_resh.Text = Convert.ToString(nomresh);
            textBox_num_del.Text = Convert.ToString(nomdel);
            comboBox1.Items.Add(pod);
            comboBox1.Items.Add(pol);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string saveStaff = "INSERT INTO `kursovaya`.`решения_суда` (`idРешения суда`,`Решение по делу`, `Лицо, исполняющее решение`, `Дата решения`)  VALUES (@del,@resh,@litso,curdate())";
                using (MySqlCommand querySaveStaff = new MySqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = sqlConnection;
                    querySaveStaff.Parameters.AddWithValue("resh", richTextBox_res.Text);
                    querySaveStaff.Parameters.AddWithValue("litso", comboBox1.SelectedItem.ToString());
                    querySaveStaff.Parameters.AddWithValue("del", nomresh);
                    querySaveStaff.ExecuteNonQuery();
                }
                MessageBox.Show("Заседание окончено успешно");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка не удалось завершить заседание");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
