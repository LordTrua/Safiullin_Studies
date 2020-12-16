using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Лаба___6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ListInfo.Items.Add("Вывод информации о сборке:");
            Assembly i = Assembly.GetExecutingAssembly();
            this.ListInfo.Items.Add("Полное имя:" + i.FullName);
            this.ListInfo.Items.Add("Исполняемый файл:" + i.Location);
            this.ListInfo.Items.Add("");
            this.ListInfo.Items.Add("");
            Reflection.ForInspection obj = new Reflection.ForInspection();
            Type File = obj.GetType();
            //другой способ
            //Type t = typeof(ForInspection);
            this.ListInfo.Items.Add("\nИнформация о типе:");
            this.ListInfo.Items.Add("Тип " + File.FullName + " унаследован от " + File.BaseType.FullName);
            this.ListInfo.Items.Add("Пространство имен " + File.Namespace);
            this.ListInfo.Items.Add("Находится в сборке " + File.AssemblyQualifiedName);
            this.ListInfo.Items.Add("");
            this.ListInfo.Items.Add("\nКонструкторы:");
            foreach (var x in File.GetConstructors())
            {
                this.ListInfo.Items.Add(x);
            }
            this.ListInfo.Items.Add("");
            this.ListInfo.Items.Add("\nМетоды:");
            foreach (var x in File.GetMethods())
            {
                this.ListInfo.Items.Add(x);
            }
            this.ListInfo.Items.Add("");
            this.ListInfo.Items.Add("\nСвойства:");
            foreach (var x in File.GetProperties())
            {
                this.ListInfo.Items.Add(x);
            }
            this.ListInfo.Items.Add("");
            this.ListInfo.Items.Add("\nПоля данных (public):");
            foreach (var x in File.GetFields())
            {
                this.ListInfo.Items.Add(x);
            }
            this.ListInfo.Items.Add("");
            this.ListInfo.Items.Add("\nForInspection реализует IComparable -> " + File.GetInterfaces().Contains(typeof(IComparable))
);
        }

        private void ListInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
