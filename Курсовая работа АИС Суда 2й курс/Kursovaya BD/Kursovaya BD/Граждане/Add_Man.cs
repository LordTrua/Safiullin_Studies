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
    public partial class Add_Man : Form
    {
        private String connectionString = null;
        private MySqlConnection sqlConnection = null;
        private MySqlDataAdapter sqlDataAdapter = null;
        private MySqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;
        public Add_Man()
        {
         
            sqlConnection = new MySqlConnection(BDLogin.SQLLogin());
            selectQueryString = "SELECT * FROM граждане";
            sqlConnection.Open();
            sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Add_Man_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox_pas.Text;
            selectQueryString = "SELECT  `Номер Паспорта` FROM граждане WHERE  `Номер Паспорта`=" + s;
            sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("гражданин с данным номером паспорта уже добавлен");
            }
            else
            {
                try
                {
                    string saveStaff = "INSERT INTO `kursovaya`.`Граждане` (`Номер Паспорта`, `Фамилия`, `Имя`, `Отчество`, `Дата рождения`, `Адрес прописки`) VALUES (@passnum, @staffFam,@staffName, @Otch, @datee, @prop)";
                    using (MySqlCommand querySaveStaff = new MySqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = sqlConnection;
                        querySaveStaff.Parameters.AddWithValue("passnum", s);
                        querySaveStaff.Parameters.AddWithValue("staffFam", textBox_Fam.Text);
                        querySaveStaff.Parameters.AddWithValue("staffName", textBox_Name.Text);
                        querySaveStaff.Parameters.AddWithValue("Otch", textBox_Otch.Text);
                        querySaveStaff.Parameters.AddWithValue("datee", dateTimePicker.Text);
                        querySaveStaff.Parameters.AddWithValue("prop", textBox_address.Text);
                        querySaveStaff.ExecuteNonQuery();
                    }
                    MessageBox.Show("гражданин добавлен");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Добавить гражданина не удалось");
                }
            }
        }

        private void textBox_Otch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
