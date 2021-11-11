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
    public partial class Admin_WorkFrom : Form
    {
        private String connectionString = null;
        private MySqlConnection sqlConnection = null;
        private MySqlDataAdapter sqlDataAdapter = null;
        private MySqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;
        public Admin_WorkFrom()
        {
            InitializeComponent();
            LoadData();
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
                dataGridView1.DataSource = bindingSource;
                dataGridView1.Columns[0].Visible = false;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                sqlDataAdapter.Update(dataTable);
                this.dataGridView1.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            */
            AddWorkerFrom f1 = new AddWorkerFrom();
            f1.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            f1.Show();
            this.Hide();
        }

        private void button_Del_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(BDLogin.SQLLogin()))
            {
                sqlConnection = new MySqlConnection(BDLogin.SQLLogin());
                selectQueryString = "SELECT `Номер трудового договора`,Фамилия,Имя,Отчество,`Название должности`,`Название состава` FROM работники left join должности on(Должность= idДолжности) left join составы_суда on(`Состоят в составе`=`idСостава суда`)";
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

        private void button_sostavs_ch_Click(object sender, EventArgs e)
        {
            ch_sostav f1 = new ch_sostav(Convert.ToInt32(dataTable.Rows[dataGridView1.CurrentRow.Index][0].ToString()));
            f1.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            f1.Show();
            this.Hide();
        }
    }
}

