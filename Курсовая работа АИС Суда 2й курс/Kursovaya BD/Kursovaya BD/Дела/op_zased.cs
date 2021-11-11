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
    public partial class op_zased : Form
    {
        int delnum;
        private String connectionString = null;
        private MySqlConnection sqlConnection = null;
        private MySqlDataAdapter sqlDataAdapter = null;
        private MySqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;
        string pod, pol;
        public op_zased(int dm)
        {
            delnum = dm;
            InitializeComponent();
        }
        string coddela;
        private void op_zased_Load(object sender, EventArgs e)
        {
   
            sqlConnection = new MySqlConnection(BDLogin.SQLLogin());
            selectQueryString = "SELECT `idАктивного дела`,`Ход дела`,`Статус дела`,`Состав суда`,`Подающий иск`,`Получающий иск`,concat_ws(' ',ФИО.`Фамилия`,ФИО.`Имя`,ФИО.`Отчество`) as 'ФИО подающего' ,concat_ws(' ',ФИОп.`Фамилия`,ФИОп.`Имя`,ФИОп.`Отчество`) as 'ФИО получающего' FROM активные_дела left join иски ON (`Иск`=`idИска`) left join граждане as ФИО ON (`Подающий иск`=ФИО.`Номер Паспорта`)  left join граждане as ФИОп ON (`Получающий иск`=ФИОп.`Номер Паспорта`) WHERE `idАктивного дела`=" + delnum;
            //SELECT `idАктивного дела`,`Ход дела`,`Статус дела`,`Состав суда`,concat_ws(" ",ФИО.`Фамилия`,ФИО.`Имя`,ФИО.`Отчество`) as "ФИО подающего" ,concat_ws(" ",ФИОп.`Фамилия`,ФИОп.`Имя`,ФИОп.`Отчество`) as "ФИО получающего" FROM активные_дела left join иски ON (`Иск`=`idИска`) left join граждане as ФИО ON (`Подающий иск`=ФИО.`Номер Паспорта`)  left join граждане as ФИОп ON (`Получающий иск`=ФИОп.`Номер Паспорта`)
            sqlConnection.Open();
            sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            pod = dataTable.Rows[0][4].ToString();
            pol = dataTable.Rows[0][5].ToString();
            coddela =  dataTable.Rows[0][0].ToString();
            textBox_num_delo.Text = dataTable.Rows[0][0].ToString();
            textBox_st.Text = dataTable.Rows[0][2].ToString();
            textBox_ist.Text = dataTable.Rows[0][6].ToString();
            textBox_otv.Text = dataTable.Rows[0][7].ToString();
            richTextBox_hod_dela.Text = dataTable.Rows[0][1].ToString();
            timer_time.Start();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_otv_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer_time_Tick(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now - dateTimePicker2.Value.TimeOfDay;
        }

        private void button_end_zased_Click(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection(BDLogin.SQLLogin());
            selectQueryString = "SELECT `Статус дела` FROM активные_дела WHERE `idАктивного дела`=" + delnum;
            //SELECT `idАктивного дела`,`Ход дела`,`Статус дела`,`Состав суда`,concat_ws(" ",ФИО.`Фамилия`,ФИО.`Имя`,ФИО.`Отчество`) as "ФИО подающего" ,concat_ws(" ",ФИОп.`Фамилия`,ФИОп.`Имя`,ФИОп.`Отчество`) as "ФИО получающего" FROM активные_дела left join иски ON (`Иск`=`idИска`) left join граждане as ФИО ON (`Подающий иск`=ФИО.`Номер Паспорта`)  left join граждане as ФИОп ON (`Получающий иск`=ФИОп.`Номер Паспорта`)
            sqlConnection.Open();
            sqlDataAdapter = new MySqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            string f = textBox_st.Text;
            if ( f == "Закрыто"|| f == "закрыто")
            {
                add_Resh f1 = new add_Resh(delnum,pod,pol);
                f1.Show();
                f = "Издано решение";
            }
            else
            {
                end_zas(f);
            }
   
        }
        void add_arkh(string f)
        {

            if (dataTable.Rows[0][0].ToString()== "Издано решение")
            {
                try
                {
                    string saveStaff = "INSERT INTO `kursovaya`.`архив` (`Архивное дело`, `Статус архивного дела`, `Дата начала хранения`, `Дата окончания хранения`) VALUES (@num, @st, curdate(), adddate(curdate(),INTERVAL 10 YEAR));";
                    using (MySqlCommand querySaveStaff = new MySqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = sqlConnection;
                        querySaveStaff.Parameters.AddWithValue("st", f);
                        querySaveStaff.Parameters.AddWithValue("num", delnum);
                        querySaveStaff.ExecuteNonQuery();
                    }
                    MessageBox.Show("Заседание окончено успешно");
                    textBox_st.Text = dataTable.Rows[0][0].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка не удалось завершить заседание");
                }
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_pred f1 = new add_pred(coddela);
            f1.Show();
        }

        private void button_sp_p_Click(object sender, EventArgs e)
        {
            Pred_sp_p f1 =new Pred_sp_p(coddela);
            f1.Show();
        }

        void end_zas(string f)
        {

            try
            {
                string saveStaff = "UPDATE `kursovaya`.`активные_дела` SET `Ход дела` = @hod, `Статус дела` = @st WHERE (`idАктивного дела` = @num)";
                using (MySqlCommand querySaveStaff = new MySqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = sqlConnection;
                    querySaveStaff.Parameters.AddWithValue("hod", richTextBox_hod_dela.Text);
                    querySaveStaff.Parameters.AddWithValue("st",f);
                    querySaveStaff.Parameters.AddWithValue("num", delnum);
                    querySaveStaff.ExecuteNonQuery();
                }
                MessageBox.Show("Заседание окончено успешно");
                add_arkh(f);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка не удалось завершить заседание");
            }
        }
}
    }

