using System;
using System.Collections.Generic;
using System.Text;

namespace LabRabota_3
{
    class Circle : GeomFigure, IPrint
    {
        private double radius;
        protected string newArea;
        public override double Areaa()
        {
            return Math.PI * radius * radius;
        }
        /// <summary>
        /// Создать фигуру круг
        /// </summary>
        /// <param name="R">Радиус</param>
        public Circle(double R)
        {
            radius = R;
            newArea = $"{radius * radius}*Pi";
            Area = R * R * Math.PI;
            Name = "Круг";
            Nameles = "Круг";
        }
        public Circle(double R,string n)
        {
            radius = R;
            newArea = $"{radius * radius}*Pi";
            Area = R * R * Math.PI;
            Name = "Круг";
            Nameles = "Круг "+n;
        }
        /// <summary>
        /// Вывод Радиуса
        /// </summary>
        public double Radius
        {
            get
            {
                return radius;
            }
        }
        /// <summary>
        /// Вывод названия фигуры
        /// </summary>
        public string name
        {
            get
            {
                return Name;
            }
        }
        public void display()
        {
            cout($"Радиус фигуры {Name}: {radius}");
        }
        public override string ToString()
        {
            return  Name.ToString() + " Радиус фигуры: " + Radius.ToString() + " Площадь фигуры: " + newArea.ToString();
        }
    }
}
