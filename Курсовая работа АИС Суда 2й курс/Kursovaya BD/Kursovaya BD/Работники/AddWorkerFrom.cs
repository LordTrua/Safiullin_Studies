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
    public partial class AddWorkerFrom : Form
    {
        private String connectionString = null;
        private MySqlConnection sqlConnection = null;
        private MySqlDataAdapter sqlDataAdapter = null;
        private MySqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;
        public AddWorkerFrom()
        {
            sqlConnection = new MySqlConnection(BDLogin.SQLLogin());
            selectQueryString = "SELECT * FROM работники";
            sqlConnection.Open();
            sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dolj=0;
            if (comboBox.SelectedIndex==1 )
            {
                dolj = 2;
            }
            else if (comboBox.SelectedIndex == 2)
            {
                dolj = 3;
            }
            else if (comboBox.SelectedIndex == 3)
            {
                dolj = 4;
            }
            else
            {
                MessageBox.Show("Укажите должность");
            }
            if (dolj != 0)
            {
                try
                {

                    string saveStaff = "INSERT into `kursovaya`.`работники` (`Фамилия`, `Имя`, `Отчество`, `Должность`) VALUES (@staffFam,@staffName,@Otch,@Dol)";
                    using (MySqlCommand querySaveStaff = new MySqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = sqlConnection;
                        querySaveStaff.Parameters.AddWithValue("staffFam", textBoxFam.Text);
                        querySaveStaff.Parameters.AddWithValue("staffName", textBoxName.Text);
                        querySaveStaff.Parameters.AddWithValue("Otch", textBoxOtch.Text);
                        querySaveStaff.Parameters.AddWithValue("Dol", dolj.ToString());
                        querySaveStaff.ExecuteNonQuery();
                    }
                    MessageBox.Show("Работник добавлен");
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка добавления");
                }
            }
        }

        private void textBoxFam_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddWorkerFrom_Load(object sender, EventArgs e)
        {

        }
    }
}
