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
    public partial class add_Nalof_Form : Form
    {
        private String connectionString = null;
        private MySqlConnection sqlConnection = null;
        private MySqlDataAdapter sqlDataAdapter = null;
        private MySqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;
        public add_Nalof_Form()
        {
            sqlConnection = new MySqlConnection(BDLogin.SQLLogin());
            selectQueryString = "SELECT * FROM Налоги_и_сборы";
            sqlConnection.Open();
            sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_oplata_Click(object sender, EventArgs e)
        {
            string n = textBox_n.Text;
            try
            {
                selectQueryString = "SELECT  `Код налога` FROM иски WHERE `idИска`="+n;
                sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
                sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (!dataTable.Rows[0].IsNull(0))
                {
                    MessageBox.Show("Налог уже уплачен");
                }
                else
                {
                    string saveStaff = "INSERT INTO `kursovaya`.`Налоги_и_сборы` (`объем сбора`, `Статус оплаты`, `Описание налога`) VALUES ( @sum, 'Да', @opis);";
                    using (MySqlCommand querySaveStaff = new MySqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = sqlConnection;
                        querySaveStaff.Parameters.AddWithValue("sum", textBox_sum.Text);
                        querySaveStaff.Parameters.AddWithValue("opis", richTextBox_op.Text);
                        querySaveStaff.ExecuteNonQuery();
                    }
                    MessageBox.Show("налог уплачен");
                    this.Close();
                    try
                    {
                        selectQueryString = "SELECT  idНалога FROM Налоги_и_сборы";
                        sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
                        sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
                        dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        string cnal= dataTable.Rows[dataTable.Rows.Count-1][0].ToString();
                       int nal= Convert.ToInt32(cnal);
                        saveStaff = "UPDATE `kursovaya`.`иски` SET `Код налога` = @cnal WHERE `idИска` = @isk"; 
                        using (MySqlCommand querySaveStaff = new MySqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = sqlConnection;
                            querySaveStaff.Parameters.AddWithValue("isk", n);
                            querySaveStaff.Parameters.AddWithValue("cnal", nal);
                            querySaveStaff.ExecuteNonQuery();
                        }

                        MessageBox.Show("налог успешно привязан к иску");
                       
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка, Не удалось привязать налог");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("транзакция не удалась");
            }
        }

        private void textBox_n_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
