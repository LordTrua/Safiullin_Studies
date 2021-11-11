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
    public partial class dob_Isk : Form
    {

        private String connectionString = null;
        private MySqlConnection sqlConnection = null;
        private MySqlDataAdapter sqlDataAdapter = null;
        private MySqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;

        public dob_Isk()
        {

        InitializeComponent();
        }

        private void dob_Isk_Load(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection(BDLogin.SQLLogin());
            selectQueryString = "Select * From иски";
            sqlConnection.Open();
            sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_iskadd_Click(object sender, EventArgs e)
        {
            string s1, s2;
            s1 = textBox_pass.Text;
            s2 = textBox_pass_a.Text;
            selectQueryString = "SELECT  `Номер Паспорта` FROM граждане WHERE `Номер Паспорта`=" + s1;
            sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                selectQueryString = "SELECT  `Номер Паспорта` FROM граждане WHERE `Номер Паспорта`=" + s2;
                sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
                sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    try
                    {
                        string saveStaff = "INSERT INTO `kursovaya`.`Иски` (`Изложение иска`, `Подающий иск`, `Получающий иск`) VALUES (@Text, @pass, @npass)";
                         using (MySqlCommand querySaveStaff = new MySqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = sqlConnection;
                            querySaveStaff.Parameters.AddWithValue("Text", richTextBox_iskk.Text);
                            querySaveStaff.Parameters.AddWithValue("pass", s1);
                            querySaveStaff.Parameters.AddWithValue("npass", s2);
                            querySaveStaff.ExecuteNonQuery();
                        }
                        MessageBox.Show("Иск подан, ожидайте уведомления");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Добавить иск не удалось" );
                    }
                }
                else
                {

                    DialogResult res = MessageBox.Show("Гражданин подающий заявление отсутствует в базе.Добавить гражданина?", "Добавить гражданина?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        Add_Man f1 = new Add_Man();
                        f1.Show();
                    }
                    else
                    {

                    }
                }

              }
                 else
                {

                    DialogResult res = MessageBox.Show("В базе отсутствует, гражданин на которого подаётся иск. Добавить гражданина ? ", "добавление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        Add_Man f1 = new Add_Man();
                        f1.Show();
                    }
                    else
                    {

                    }

                }
            }

                
        }
    }

