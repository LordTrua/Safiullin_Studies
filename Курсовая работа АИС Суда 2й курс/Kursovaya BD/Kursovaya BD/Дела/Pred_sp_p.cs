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
    public partial class Pred_sp_p : Form
    {
        private String connectionString = null;
        private MySqlConnection sqlConnection = null;
        private MySqlDataAdapter sqlDataAdapter = null;
        private MySqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;
        string dn;
        public Pred_sp_p(string delnum)
        {
            dn = delnum;
            InitializeComponent();
        }

        private void Pred_sp_p_Load(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(BDLogin.SQLLogin()))
            {
                sqlConnection = new MySqlConnection(BDLogin.SQLLogin());
                selectQueryString = "SELECT idПредписания,`Код дела`,concat_ws(' ',`Фамилия`,`Имя`,`Отчество`) as 'Лицо, на которое распространяется предписание',`содержание предписания`,`Дата выдачи` FROM предписания left join граждане ON(`Лицо, на которое распространяется`=`Номер Паспорта`) WHERE `Код дела`=" + dn;
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

        private void button_add_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(BDLogin.SQLLogin()))
            {
                sqlConnection = new MySqlConnection(BDLogin.SQLLogin());
                selectQueryString = "SELECT idПредписания,`Код дела`,concat_ws(' ',`Фамилия`,`Имя`,`Отчество`) as 'Лицо, на которое распространяется предписание',`содержание предписания`,`Дата выдачи` FROM предписания left join граждане ON(`Лицо, на которое распространяется`=`Номер Паспорта`) WHERE `Код дела`=" + dn;
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

        private void button_del_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
