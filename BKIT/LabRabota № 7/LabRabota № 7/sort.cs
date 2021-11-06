using System;
using System.Collections.Generic;
using System.Text;

namespace LabRabota___7
{
    class Sort
    {
public static Workers[] BubbleSort(Workers[] mas)
        {
            Workers temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i].get_id() > mas[j].get_id())
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }
    }
}
