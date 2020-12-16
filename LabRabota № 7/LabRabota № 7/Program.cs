using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LabRabota___7
{
    class Program
    {

        static void Main(string[] args)
        {
            Department D1 = new Department(1, "Юридический отдел");
            Department D2 = new Department(2, "IT отдел");
            Department D3 = new Department(3, "Отдел разработок");
            Department D4 = new Department(4, "Отдел Управления");

            Workers w1 = new Workers(1, "Аленин");
            Workers w2 = new Workers(2, "Миль");
            Workers w3 = new Workers(3, "Васянин");
            Workers w4 = new Workers(4, "Перчиков");
            Workers w5 = new Workers(5, "Петров");
            Workers w6 = new Workers(6, "Полянин");
            Workers w7 = new Workers(7, "Иванов");
            Workers w8 = new Workers(8, "Аликов");
            Workers w9 = new Workers(9, "Азизов");
            Workers w10 = new Workers(10, "Абрамян");

            D1.addWorker(w8);
            D1.addWorker(w2);
            D1.addWorker(w1);
            D1.addWorker(w7);
            D1.addWorker(w3);
            D3.addWorker(w4);
            D2.addWorker(w5);
            D2.addWorker(w6);
            D1.addWorker(w10);
            D4.addWorker(w9);
            Console.WriteLine("\n");
            List<Workers> AllWorkers = new List<Workers>() { w1, w2, w3, w4, w5, w6, w7, w8, w9, w10 };
            Department[] Company = new Department[] { D4, D2, D3, D1 };
            Console.WriteLine("\nВыведите список всех сотрудников и отделов, отсортированный по отделам.");
            var selectedName = from k in Company
                               where k.get_id_o() != 0
                               orderby k.get_id_o()
                               select k;

            foreach (Department k in selectedName)
            {
                k.cout();
            }
            Console.WriteLine("\n");

            Console.WriteLine("\nВыведите список всех сотрудников, у которых фамилия начинается с буквы «А».");
            var selectedNames = from w in AllWorkers where w.FIO.ToUpper().StartsWith("А") orderby w.get_id() select w;
            Console.WriteLine("ID        Фамилия");
            foreach (Workers w in selectedNames)
            {
                if (w.get_id() < 10) Console.WriteLine(w.get_id() + "         " + w.get_FIO());
                else if (w.get_id() < 1000) Console.WriteLine(w.get_id() + "        " + w.get_FIO());
                else Console.WriteLine(w.get_id() + "       " + w.get_FIO());
            }
            Console.WriteLine("\n");

            Console.WriteLine("\nВыведите список отделов, в которых у всех сотрудников фамилия начинается с буквы «А»\n");
            foreach (Department t in Company)
            {
                t.AllcoutName("А");
            }
            Console.WriteLine("\n");
            Console.WriteLine("\nВыведите список отделов, в которых хотя бы у одного сотрудника фамилия начинается с буквы «А».\n");
            foreach (Department f in Company)
            {
                f.coutName("А");
            }
            Console.WriteLine("\n");
            Console.WriteLine("\nВыведите список всех отделов и список сотрудников в каждом отделе.\n");
            List<Workers_and_Department> WD = new List<Workers_and_Department>();
            foreach (Department Dep in Company)
            {
                foreach (Workers wor in Dep.D_Workers)
                {
                    Workers_and_Department k = new Workers_and_Department(wor, Dep);
                    WD.Add(k);
                }
            }

            var selectedWD_All = from wd in WD
                                 where wd.get_W().get_id() != 0 && wd.get_D().get_id_o() != 0
                                 orderby wd.get_D().D_Workers.Count()
                                 select wd;
            List<int> Depu = new List<int>();
            Depu.Add(0);
            foreach (Workers_and_Department Wdk in selectedWD_All)
            {
                if (!Depu.Contains(Wdk.get_D().get_id_o()  ))
                    {
                    Wdk.get_D().cout();
                    Depu.Add(Wdk.get_D().get_id_o());
                    }

            }
            Console.WriteLine("\n");
        }
    }
}
        


    
