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
    public partial class Add_new_delo : Form
    {
        private String connectionString = null;
        private MySqlConnection sqlConnection = null;
        private MySqlDataAdapter sqlDataAdapter = null;
        private MySqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;

        public Add_new_delo()
        {
            LoadData();
            InitializeComponent();
        }
        void LoadData()
        {
            DataSet ds = new DataSet();
            using (MySqlConnection con = new MySqlConnection(BDLogin.SQLLogin()))
            {
                sqlConnection = new MySqlConnection(BDLogin.SQLLogin());
                selectQueryString = "SELECT `Номер трудового договора`,Фамилия,Имя,Отчество,`Название должности`,`Название состава` FROM работники left join должности on(Должность= idДолжности) left join составы_суда on(`Состоят в составе`=`idСостава суда`) ";
                sqlConnection.Open();
                sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
                sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
            }
        }

        private void Add_new_delo_Load(object sender, EventArgs e)
        {
            try
            {
                // Вывод номера дела
                selectQueryString = "SELECT  `idАктивного дела` FROM Активные_дела";
                sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
                sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                string cnal = dataTable.Rows[dataTable.Rows.Count - 1][0].ToString(); // Номер последнего активного дела
                int nal = Convert.ToInt32(cnal); // id последнего активного дела
                nal++;
                textBox_delo.Text = Convert.ToString(nal);

                /* Добавление в combobox значений из  таблицы
                 * сombobox1.DataSource=tbl; //datatable
                 combobox1.DisplayMember="Столбец1";// столбец для отображения
                    combobox1.ValueMember="id";//столбец с id*/
            
                // Добавляем в комбобокс значение
                
                selectQueryString = "SELECT  `idСостава суда`,`Название состава` FROM составы_суда";
                sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
                sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                comboBox_sost.DataSource = dataTable;
                comboBox_sost.DisplayMember = dataTable.Columns[1].ColumnName.ToString();
                comboBox_sost.ValueMember = dataTable.Columns[0].ColumnName.ToString();

                selectQueryString = "SELECT idИска FROM иски order by idИска; ";
                sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
                sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                comboBox_num_isk.DataSource = dataTable;
                comboBox_num_isk.DisplayMember = dataTable.Columns[0].ColumnName.ToString();
                comboBox_num_isk.ValueMember = dataTable.Columns[0].ColumnName.ToString();
            }

            catch
            {
                MessageBox.Show("Ошибка закгрузки формы, обратитесь к администратору");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string saveStaff = "INSERT INTO `kursovaya`.`активные_дела` (`Статус дела`, `Иск`, `Состав суда`) VALUES ( 'Открыто',@isk, @sostav);";
                using (MySqlCommand querySaveStaff = new MySqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = sqlConnection;
                    querySaveStaff.Parameters.AddWithValue("isk", comboBox_num_isk.SelectedValue) ;
                    querySaveStaff.Parameters.AddWithValue("sostav",comboBox_sost.SelectedValue);

                    querySaveStaff.ExecuteNonQuery();
                }
                MessageBox.Show("Дело открыто");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Открыть дело не удалось");
            }
        }

        private void comboBox_sost_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
