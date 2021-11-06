using System;
using System.Collections.Generic;

namespace LabRabota_3
{
    class Program
    {
        public static void cout(string per)
        {
            Console.WriteLine(per);
        }
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
        static void Main(string[] args)
        {
            cout("Программу создал Сафиуллин А.П. РТ5-31Б");
            Rectangle KK, KK1;
            Sqare TT,TT1;
            Circle KR1, KR2, KR3;
            TT = new Sqare(4);
            TT1 = new Sqare(10);
            KK = new Rectangle(5, 4);
            KK1 = new Rectangle(6, 4, "2");
            KR1 = new Circle(4);// Добавим круг
            KR2 = new Circle(5, "2");// Добавим круг 2
            KR3 = new Circle(7, "3");// Добавим круг 3
            KK.Print();
            TT.Print();

            List<GeomFigure> geomFigures= new List<GeomFigure> {TT,KK};

            geomFigures.Add(KK1);
            geomFigures.Add(KK);
            geomFigures.Add(TT);
            geomFigures.Add(TT1);
            geomFigures.Add(KR1);
            geomFigures.Add(KR2);
            geomFigures.Add(KR3);
            cout("До сортировки: ");
            IPrint.LPrint(geomFigures,-6);
            IComparablee.Sort(geomFigures);
            cout(""); cout("");
            cout("После сортировки: ");
            IPrint.LPrint(geomFigures,8);

            Console.WriteLine("\nМатрица");
            Matrix<GeomFigure> matrix = new Matrix<GeomFigure>(5,5,5, new FigureMatrixCheckEmpty() );
            int x = 1, y = 1, z = 1;
            foreach (var item in geomFigures)
            {
                if (item.name == "Квадрат") {
                    matrix[x, 0, 0] = item; 
                    x++;
                }
                if (item.name == "Прямоугольник") {
                    matrix[0, y, 0] = item; 
                    y++; 
                }
                if (item.name == "Круг") { 
                    matrix[0, 0, z] = item; 
                    z++;
                }
            }
            Console.WriteLine(matrix.ToString());
            cout(""); cout(""); cout("");
            cout("СТЭК");
            SimpleStack<GeomFigure> stack = new SimpleStack<GeomFigure>();
            stack.Push(TT);
            stack.Push(TT1);
            Console.WriteLine(stack.Pop().ToString());
            stack.Push(KK1);
            stack.Push(KK);
            Console.WriteLine(stack.Pop().ToString());
            Console.WriteLine(stack.Pop().ToString());
            Console.WriteLine(stack.Pop().ToString());
            Console.WriteLine("Элементов в стеке: {0}", stack.Count);
        }
    }
}
