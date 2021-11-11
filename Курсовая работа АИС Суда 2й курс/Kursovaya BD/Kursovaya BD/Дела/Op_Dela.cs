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
    public partial class Op_Dela : Form
    {
        private String connectionString = null;
        private MySqlConnection sqlConnection = null;
        private MySqlDataAdapter sqlDataAdapter = null;
        private MySqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;
        public Op_Dela()
        {
            InitializeComponent();
        }

        private void Op_Dela_Load(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection(BDLogin.SQLLogin());
            selectQueryString = "SELECT * FROM активные_дела WHERE `Статус дела` NOT LIKE 'Издано решение' OR 'Закрыто';";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_op_delo_Click(object sender, EventArgs e)
        {
            Add_new_delo f1 = new Add_new_delo();
            f1.Show();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(BDLogin.SQLLogin()))
            {
                sqlConnection = new MySqlConnection(BDLogin.SQLLogin());
                selectQueryString = "SELECT * FROM активные_дела WHERE `Статус дела` NOT LIKE 'Издано решение' OR 'Закрыто'";
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

        private void button_zased_Click(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection(BDLogin.SQLLogin());
            selectQueryString = "Select * From активные_дела WHERE `Статус дела` NOT LIKE 'Издано решение' OR 'Закрыто'";
            sqlConnection.Open();
            sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            op_zased f1 = new op_zased(Convert.ToInt32(dataTable.Rows[dataGridView1.CurrentRow.Index][0].ToString()));// Передаём индекс дела с которым будем работать
            f1.Show();
        }

        private void button_del_delo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    sqlDataAdapter.Update(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
