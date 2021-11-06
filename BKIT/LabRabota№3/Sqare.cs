using System;
using System.Collections.Generic;
using System.Text;

namespace LabRabota_3
{
    class Sqare : Rectangle, IPrint
    {
        public Sqare(double W) : base(W, W)
        {
            Name = "Квадрат";
            Nameles = "Квадрат";
        }
        public Sqare(double W,string n) : base(W, W)
        {
            Name = "Квадрат";
            Nameles = "Квадрат "+n;
        }
        public override string ToString()
        {
            return  Name.ToString() + " Ширина && Длина фигуры: " + Width.ToString() + " Площадь фигуры: " + Area.ToString();
        }
   
    }
}
