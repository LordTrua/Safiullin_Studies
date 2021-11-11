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
    public partial class Ark_mainform : Form
    {
        private String connectionString = null;
        private MySqlConnection sqlConnection = null;
        private MySqlDataAdapter sqlDataAdapter = null;
        private MySqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;
        public Ark_mainform()
        {
            InitializeComponent();
        }

        private void Ark_mainform_Load(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection(BDLogin.SQLLogin());
            selectQueryString = "Select * From архив";
            sqlConnection.Open();
            sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
            dataGridView1.Columns[0].Visible = false;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(BDLogin.SQLLogin()))
            {
                sqlConnection = new MySqlConnection(BDLogin.SQLLogin());
                selectQueryString = "Select * From архив";
                sqlConnection.Open();
                sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
                sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                dataGridView1.DataSource = bindingSource;
                dataGridView1.Columns[0].Visible = false;
            }
        sqlDataAdapter.Update(dataTable);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection(BDLogin.SQLLogin());
            selectQueryString = "Select * From архив";
            sqlConnection.Open();
            sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
             op_zased f1 = new op_zased(Convert.ToInt32(dataTable.Rows[dataGridView1.CurrentRow.Index][1].ToString()));// Передаём индекс дела с которым будем работать
            f1.ShowDialog();
        }
    }
}
