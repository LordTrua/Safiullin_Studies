using System;
using System.Collections.Generic;
using System.Text;

namespace LabRabota_3
{
    /// <summary>
    /// Класс геометрическая фигура 
    /// </summary>
     abstract class GeomFigure : IComparable
    {
        public abstract double Areaa();
        protected double Area;
        protected string Name;
        protected string Nameles;
        public  double area
        {
            get
            {
                return Area;
            }
        }
        public string name
        {
            get
            {
                return Name;
            }
            set { Name = value; }
        }
        public string nameles
        {
            get
            {
                return Nameles;
            }
            set { Nameles = value; }
        }
        public static bool operator > (GeomFigure F1, GeomFigure F2) // операторы сравнения 
        {
            if (F1.area > F2.area)
            {
                return true;
            }
            else { return false;}
        }
        public static bool operator <(GeomFigure F1, GeomFigure F2)// операторы сравнения 
        {
            if (F1.area < F2.area)
            {
                return true;
            }
            else { return false; }
        }
        public int CompareTo(object obj)
        {
            //Приведение параметра к типу "фигура"
            GeomFigure p = (GeomFigure)obj;
            //Сравнение
            if (this.Areaa() < p.Areaa()) return -1;
            else if (this.Areaa() == p.Areaa()) return 0;
            else return 1; //(this.Area() > p.Area())

        }
        /// <summary>
        /// Вывод
        /// </summary>
        /// <param name="per">выводимая переменная</param>
        public static void cout(string per)
        {
            Console.WriteLine(per);
        }
        /// <summary>
        /// Ввод переменой типа double 
        /// </summary>
        /// <returns></returns>
        public static double dcin()
        {
            int error = 1;
            double pev;
            while (error == 1)//Вввод переменной 
            {
                try
                {
                    string per = Console.ReadLine();
                    pev = double.Parse(per);
                    return pev;
                }
                catch
                {
                    cout("Введите корректную переменную: ");
                }
                finally { }
            }
            return 0;
        }

    }
}
