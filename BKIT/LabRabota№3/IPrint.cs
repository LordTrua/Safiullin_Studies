 using System;
using System.Collections.Generic;
using System.Text;

namespace LabRabota_3
{
    interface IPrint
    {
        private static void cout(string per)
        {
            Console.WriteLine(per);
        }
        public void Print()
        {
           this.ToString();
        }
        public static void LPrint(List<GeomFigure> list, int k)
        {
            int i = 0;
            cout("\n");
            Console.SetCursorPosition(10, k+10);
            Console.WriteLine("Фигуры в массиве: ");
            Console.Write("Номер в массиве: "); ; Console.Write("Название фигуры: ");Console.WriteLine("  Площадь: ");
            foreach (var item in list)
            {
                Console.Write(i + 1);Console.SetCursorPosition(17, k+11+i+1);Console.Write(item.nameles); Console.SetCursorPosition(36, k+11+i+1); Console.WriteLine($"{item.area:f3}");
                i++;
            }
        }
    }
}
