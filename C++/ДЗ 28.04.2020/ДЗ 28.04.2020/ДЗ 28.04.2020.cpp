// ДЗ 28.04.2020.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//Выполнил: Сафиуллин А.П. РТ5-21

#include <iostream>
#include<cmath>
#include <Windows.h>
#include <string>

using namespace std;
class complex 
{
public:
    int cel, comp;
    complex(int c, int d)
    {
        cel = c;
        comp = d;
    }
    void display()
    {
        cout << "Число: " << cel << "+" << comp << "i" << endl;
    }
};

complex operator + (complex c1, complex c2)
{
   cout << "Сложение: " << endl;
  int  c0 = c1.cel + c2.cel;
   int d0 = c1.comp + c2.comp;
   return complex(c0, d0);
}
complex operator *(complex c1, complex c2)
{
    cout << "Умножение: " << endl;
   int c0 = (c1.cel * c2.cel) - (c1.comp * c2.comp);
   int d0 = (c1.cel * c2.comp) + (c2.cel * c1.comp);
   return complex(c0, d0);
}

int main()
{
    setlocale(0, "rus");
    int a, b, c, d;
    cout << "Введите целую часть 1го числа: "; cin >> c;
    cout << "Введите комплексную часть 1го числа: "; cin >> d;
    complex c1(c, d);
    c1.display();
    cout << "Введите целую часть 2го числа: "; cin >> a;
    cout << "Введите комплексную часть 2го числа: "; cin >> b;
    complex c2(a, b);
    c2.display();
    complex c3 = c1 + c2;
    c3.display();
    complex c4 = c1 * c2;
    c4.display();
}

