using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace LabRabota___7
{
    class Department
    {
        private int ID_o;
        private string d_Name;
        public List<Workers> D_Workers;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name">Department Name</param>
        /// <param name="id">Department ID </param>
        public Department(int id,string Name)
        {
            ID_o = id;
            d_Name = Name;
            D_Workers = new List<Workers>();
        }
        public int get_id_o() { return this.ID_o; }
        /// <summary>
        /// Добавление работника в отдел
        /// </summary>
        /// <param name="i">Работник</param>
        public void addWorker (Workers i)
        {
            i.set_id_o(this.ID_o);
            D_Workers.Add(i);
            Workers[] mas = new Workers[D_Workers.Count];
            int l = 0;
            foreach (Workers p in D_Workers)
            {
                mas[l] = p;
                l++;
            }
            D_Workers.Clear();
            Sort.BubbleSort(mas);
            for (int k = 0; k<l; k++)
            {
                D_Workers.Add(mas[k]);
            }
        }
        public void deleteWorker(Workers i)
        {
            int Num = 0;
            foreach (Workers p in D_Workers)
            { 
                if ( p.get_id()==i.get_id() )
                {
                    break;
                }
                Num++;
            }
            D_Workers.RemoveAt(Num);
        }
        public void cout ()
        {
            Console.WriteLine("\n\nID отдела: "+this.ID_o+"\nНазание отдела: " + this.d_Name+"\nКол-во сотрудников:"+this.D_Workers.Count );
            Console.WriteLine("ID        Фамилия");
            foreach (Workers p in D_Workers) 
            {
                if (p.get_id()<10) Console.WriteLine(p.get_id() + "         " + p.get_FIO());
                else Console.WriteLine(p.get_id() + "        " + p.get_FIO());
            }
        }
        public int coutName (string Buk)
        {
            var selectedNames = from w in D_Workers
                                where w.FIO.ToUpper().StartsWith(Buk)
                                orderby w.get_id()
                                select w;

            if (selectedNames.Count() != 0)
            {
                Console.WriteLine("\n\nID отдела: " + this.ID_o + "\nНазание отдела: " + this.d_Name + "\nКол-во сотрудников:" + this.D_Workers.Count);
                Console.WriteLine("ID        Фамилия");
                foreach (Workers w in selectedNames)
                {
                    if (w.get_id() < 10) Console.WriteLine(w.get_id() + "         " + w.get_FIO());
                    else if (w.get_id() < 1000) Console.WriteLine(w.get_id() + "        " + w.get_FIO());
                    else Console.WriteLine(w.get_id() + "       " + w.get_FIO());
                }
                return selectedNames.Count();
            }
            else return 0;
            
        }
        public int AllcoutName(string Buk)
        {
            var selectedNames = from w in D_Workers
                                where w.FIO.ToUpper().StartsWith(Buk)
                                orderby w.get_id()
                                select w;

            if (selectedNames.Count() != 0 && selectedNames.Count()== D_Workers.Count())
            {
                Console.WriteLine("\n\nID отдела: " + this.ID_o + "\nНазание отдела: " + this.d_Name + "\nКол-во сотрудников:" + this.D_Workers.Count);
                Console.WriteLine("ID        Фамилия");
                foreach (Workers w in selectedNames)
                {
                    if (w.get_id() < 10) Console.WriteLine(w.get_id() + "         " + w.get_FIO());
                    else if (w.get_id() < 1000) Console.WriteLine(w.get_id() + "        " + w.get_FIO());
                    else Console.WriteLine(w.get_id() + "       " + w.get_FIO());
                }
                return selectedNames.Count();
            }
            else return 0;

        }
    }
}
