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
    public partial class ch_sostav : Form
    {
        private String connectionString = null;
        private MySqlConnection sqlConnection = null;
        private MySqlDataAdapter sqlDataAdapter = null;
        private MySqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;
        int numworker;
        public ch_sostav(int nw)
        {
            numworker = nw;
            InitializeComponent();
        }

        private void ch_sostav_Load(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection(BDLogin.SQLLogin());
            selectQueryString = "SELECT  `idСостава суда`,`Название состава` FROM составы_суда";
            sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            comboBox_sost.Items.Add("-");
            comboBox_sost.DataSource = dataTable;
            comboBox_sost.DisplayMember = dataTable.Columns[1].ColumnName.ToString();
            comboBox_sost.ValueMember = dataTable.Columns[0].ColumnName.ToString();
           

            selectQueryString = "SELECT idДолжности,`Название должности` FROM должности;";
            sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            comboBox_dol.DataSource = dataTable;
            comboBox_dol.DisplayMember = dataTable.Columns[1].ColumnName.ToString();
            comboBox_dol.ValueMember = dataTable.Columns[0].ColumnName.ToString();
           

            selectQueryString = "SELECT * FROM работники WHERE `Номер трудового договора`="+numworker;
            //SELECT `idАктивного дела`,`Ход дела`,`Статус дела`,`Состав суда`,concat_ws(" ",ФИО.`Фамилия`,ФИО.`Имя`,ФИО.`Отчество`) as "ФИО подающего" ,concat_ws(" ",ФИОп.`Фамилия`,ФИОп.`Имя`,ФИОп.`Отчество`) as "ФИО получающего" FROM активные_дела left join иски ON (`Иск`=`idИска`) left join граждане as ФИО ON (`Подающий иск`=ФИО.`Номер Паспорта`)  left join граждане as ФИОп ON (`Получающий иск`=ФИОп.`Номер Паспорта`)
            sqlConnection.Open();
            sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            textBox_fam.Text = dataTable.Rows[0][1].ToString();
            textBox_name.Text = dataTable.Rows[0][2].ToString();
            textBox_otch.Text = dataTable.Rows[0][3].ToString();
            try
            {
                int sos = Convert.ToInt32(dataTable.Rows[0][5].ToString());
                comboBox_sost.SelectedIndex = sos-1;
            }
           catch
            {
                comboBox_sost.SelectedIndex = 0;
            }
            comboBox_dol.SelectedIndex = Convert.ToInt32(dataTable.Rows[0][4].ToString())-1;
            
        }

        private void button_red_Click(object sender, EventArgs e)
        {
            try
            {
                string saveStaff = "UPDATE `kursovaya`.`работники` SET `Фамилия` = @fam, `Имя` = @name, `Отчество` = @otch, `Должность` = @dol, `Состоят в составе` = @sost WHERE (`Номер трудового договора` = @num);";
                using (MySqlCommand querySaveStaff = new MySqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = sqlConnection;
                    querySaveStaff.Parameters.AddWithValue("fam", textBox_fam.Text);
                    querySaveStaff.Parameters.AddWithValue("name", textBox_name.Text);
                    querySaveStaff.Parameters.AddWithValue("otch", textBox_otch.Text);
                    querySaveStaff.Parameters.AddWithValue("dol", comboBox_dol.SelectedValue);
                    querySaveStaff.Parameters.AddWithValue("sost", comboBox_sost.SelectedValue);
                    querySaveStaff.Parameters.AddWithValue("num", numworker);
                    querySaveStaff.ExecuteNonQuery();
                }
                MessageBox.Show("Редактирование успешно");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка не удалось завершить редактирование");
            }
        }
    }
}
