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
    public partial class Op_isks : Form
    {
        private String connectionString = null;
        private MySqlConnection sqlConnection = null;
        private MySqlDataAdapter sqlDataAdapter = null;
        private MySqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;
        public Op_isks()
        {
            
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            dataGridView1.SelectionChanged += new EventHandler(dataGridView1_SelectionChanged);
        }
            private void Op_isks_Load(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection(BDLogin.SQLLogin());
            selectQueryString = "Select `idИска`,`Изложение иска`,`Код налога`, concat_ws(' ', ФИО.`Фамилия`, ФИО.`Имя`, ФИО.`Отчество`) as 'ФИО подавшего' ,concat_ws(' ', ФИОп.`Фамилия`, ФИОп.`Имя`, ФИОп.`Отчество`) as 'ФИО получающего'FROM иски left join граждане as ФИО ON(`Подающий иск`= ФИО.`Номер Паспорта`) left join граждане as ФИОп ON(`Получающий иск`= ФИОп.`Номер Паспорта`)" ;
            sqlConnection.Open();
            sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
            dataGridView1.Columns[0].Visible = false;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
                column.Width = 250;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 50;
            textBox_num.Text = dataTable.Rows[0][0].ToString();
            OnLoad(e);
        }

        private void button_Add_Isk_Click(object sender, EventArgs e)
        {
            dob_Isk f1 = new dob_Isk();
            f1.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(BDLogin.SQLLogin()))
            {
                sqlConnection = new MySqlConnection(BDLogin.SQLLogin());
                selectQueryString = "Select `idИска`,`Изложение иска`,`Код налога`, concat_ws(' ', ФИО.`Фамилия`, ФИО.`Имя`, ФИО.`Отчество`) as 'ФИО подавшего' ,concat_ws(' ', ФИОп.`Фамилия`, ФИОп.`Имя`, ФИОп.`Отчество`) as 'ФИО получающего'FROM иски left join граждане as ФИО ON(`Подающий иск`= ФИО.`Номер Паспорта`) left join граждане as ФИОп ON(`Получающий иск`= ФИОп.`Номер Паспорта`)";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e) 

        {
            try
            {
                update();
            }
            catch
            {

            }
        }
         private void update()
        {
            try
            {
                textBox_num.Text = dataTable.Rows[dataGridView1.CurrentRow.Index][0].ToString();
            }
            catch
            {

            }
        }
    }
}
