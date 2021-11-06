using System;
using System.Collections.Generic;
using System.Text;

namespace LabRabota_3
{
    /// <summary>
    /// Класс прямоугольник, наследник класса фигура
    /// </summary>
    class Rectangle : GeomFigure, IPrint
    {
        public override double Areaa()
        {
            return Width * Length;
        }
        protected double Width;
        protected double Length;
       
        protected Rectangle()
        {
            Area = Width * Length;
        }
        /// <summary>
        /// Создание фигуры
        /// </summary>
        /// <param name="W">Ширина фигуры</param>
        /// <param name="L">Длина фигуры</param>
        public Rectangle(double W, double L)
        {

            Width = W;
            Length = L;
            Area = Width * Length;
            Name = "Прямоугольник";
            Nameles = "Прямоугольник";
        }
        public Rectangle(double W, double L,string s)
        {

            Width = W;
            Length = L;
            Area = Width * Length;
            Name = "Прямоугольник";
            Nameles = "Прямоугольник "+s;
        }
        public void Display()
        {
            cout($"Ширина фигуры {Name} равна:{Width}");
            cout($"Длина фигуры {Name} равна:{Length}");
            cout($"Площадь фигуры {Name} равна:{Area}");
        }
        public override string ToString()
        {
            if (Name == "Прямоугольник") return Name.ToString() + " Ширина: " + Width.ToString() + " Длина: " + Length.ToString() + " Площадь фигуры: " + Area.ToString();
            else return "";
        }
        public  void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
