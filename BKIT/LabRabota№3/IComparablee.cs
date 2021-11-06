using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace LabRabota_3
{
   
     interface IComparablee
    {
        public static GeomFigure[] Sort(GeomFigure[]mas) //Сортировка фигур по площади в массиве
        {
            {
                GeomFigure temp;
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (mas[i].area > mas[j].area)
                        {
                            temp = mas[i];
                            mas[i] = mas[j];
                            mas[j] = temp;
                        }
                    }
                }
                /*Console.WriteLine();
                Console.WriteLine("Площади по возрастанию: ");
                for (int i=0; i<mas.Length;i++)
                {
                    if (mas[i].name=="Квадрат") Console.WriteLine($"{i+1})Фигура: {mas[i].name}       Площадь:{mas[i].area}");
                    else if (mas[i].name == "Прямоугольник") Console.WriteLine($"{i + 1})Фигура: {mas[i].name} Площадь:{mas[i].area}");
                    else if (mas[i].name == "Круг") Console.WriteLine($"{i + 1})Фигура: {mas[i].name}          Площадь:{mas[i].area:f3}");
                }*/
                return mas;
            }
        }
        public static List<GeomFigure> Sort(List<GeomFigure> geomFigures) //Сортировка фигур в списке типа Лист
        {
            GeomFigure [] mas= new GeomFigure[geomFigures.Count]; //Создание массива размера массива лист
            int i = 0;
            foreach (var item in geomFigures)
            {
                mas[i] = item;// Запись элементов листа в массив 
                i++;
            }
            Sort(mas);// Сортировка массива
            geomFigures.Clear();//Очистка изначального массива 
            for (int j = 0; j < i; j++)// Перезапись массива отсортированными фигурами
            {
                geomFigures.Add(mas[j]);
            }
            return geomFigures;
        }
    }
}
