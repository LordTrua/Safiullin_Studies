using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба___6
{

    public partial class Form1 : Form
    {
        public delegate T TextBoxConverter<T0, T1, T2, T>(T0 p1, T1 p2, T2 str);
        public delegate string connect(TextBoxConverter<int, int, string, string> p1, string p2, TextBoxConverter<int, int, string, string> p3);
        public Form1()
        {
            InitializeComponent();
        }
        public static string TxTPlus(int p1, int p2, string str)
        {
            int p3 = p1 + p2;
            return str + " " + p1.ToString() + "+" + p2.ToString() + "=" + p3.ToString();
        }
        public static string TxTMinus(int p1, int p2, string str)
        {
            int p3 = p1 - p2;
            return str + " " + p1.ToString() + "-" + p2.ToString() + "=" + p3.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Text1 = Param2_textBox.Text.Trim();
            int Txt1 = Convert.ToInt32(Text1);
            string Text2 = Param3_textBox.Text.Trim();
            int Txt2 = Convert.ToInt32(Text1);
            string Text3 = Param1_textBox.Text;
            TextBoxConverter<int, int, string, string> strink= TxTPlus;
            TextBoxConverter<int, int, string, string> strink1 = TxTPlus;
            connect p1 = (TextBoxConverter<int, int, string, string> f1, string s, TextBoxConverter<int, int, string, string> f2) =>
            {
                f1 = TxTPlus;
                f2 = IntPlus(f1, 2);
                return f1(Txt1,Txt2,Text3) +s+ f2 (Txt1, Txt2, Text3);
            };
            this.listBox1.Items.Add(p1(strink, " Прибавим ещё 2 ", strink1));
        }

        public TextBoxConverter<int,int,string,string> IntPlus (TextBoxConverter<int,int,string,string> strink, int p3)
        {
             strink = (int p1, int p2, string str) =>
             {
                 int t4 = p1 + p2 + p3;
                 return str + " " + p1.ToString() + "+" + p2.ToString()+ "+" + p3.ToString() + "=" + t4.ToString() ;
             };
            return strink;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Param1_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Param2_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Param3_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

         }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
        }
    }

}

