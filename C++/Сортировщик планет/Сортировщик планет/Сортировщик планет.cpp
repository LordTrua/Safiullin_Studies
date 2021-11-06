// Сортировщик планет.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <iomanip>

#include <fstream>
#include <math.h>

#include<string.h>
#include<string>

#include <stdio.h>
#include <Windows.h>

#include<cstdio>
#include<cassert>

using namespace std;
class planet
{

public:

	void sortname()
	{
		ifstream merk;
		ifstream ven;
		ifstream Earth;
		ifstream Mars;
		ifstream Jupiter;
		ifstream Saturn;
		ifstream Uran;
		ifstream Neptun;
		merk.open("C:\\Users\\antoh\\Source\\Repos\\Планеты\\Obol\\Biblio\\Меркурий.txt");
		ven.open("C:\\Users\\antoh\\Source\\Repos\\Планеты\\Obol\\Biblio\\Венера.txt");
		Earth.open("C:\\Users\\antoh\\Source\\Repos\\Планеты\\Obol\\Biblio\\Земля.txt");
		Mars.open("C:\\Users\\antoh\\Source\\Repos\\Планеты\\Obol\\Biblio\\Марс.txt");
		Jupiter.open("C:\\Users\\antoh\\Source\\Repos\\Планеты\\Obol\\Biblio\\Юпитер.txt");
		Saturn.open("C:\\Users\\antoh\\Source\\Repos\\Планеты\\Obol\\Biblio\\Сатурн.txt");
		Uran.open("C:\\Users\\antoh\\Source\\Repos\\Планеты\\Obol\\Biblio\\Уран.txt");
		Neptun.open("C:\\Users\\antoh\\Source\\Repos\\Планеты\\Obol\\Biblio\\Нептун.txt");
		char Buf1[100]; char Buf2[100]; char Buf3[100]; char Buf4[100]; char Buf5[100]; char Buf6[100]; char Buf7[100]; char Buf8[100];
		char name1[30]; char name2[30]; char name3[30]; char name4[30]; char name5[30]; char name6[30]; char name7[30]; char name8[30];
		char pereg1[30];	char pereg2[30];	char pereg3[30];	char pereg4[30];	char pereg5[30];	char pereg6[30];	char pereg7[30];	char pereg8[30];
		char afel1[30]; char afel2[30]; char afel3[30]; char afel4[30]; char afel5[30]; char afel6[30]; char afel7[30]; char afel8[30];
		char colvo1[30];	char colvo2[30];	char colvo3[30];	char colvo4[30];	char colvo5[30];	char colvo6[30];	char colvo7[30];	char colvo8[30];
		while (!merk.eof())
		{
			merk.getline(Buf1, 100, ':');
			if (!strcmp(Buf1, "Название планеты"))
			{
				merk.getline(name1, 100);
			}
			if (!strcmp(Buf1, "Перегелий"))
			{
				merk.getline(pereg1, 100);
			}
			if (!strcmp(Buf1, "Афелий"))
			{
				merk.getline(afel1, 100);
			}
			if (!strcmp(Buf1, "Количество спутников"))
			{
				merk.getline(colvo1, 100);
			}
		}
		ven.getline(Buf2, 100, ':');
		ven.getline(Buf2, 100);
		Earth.getline(Buf3, 100, ':');
		Earth.getline(Buf3, 100);
		Mars.getline(Buf4, 100, ':');
		Mars.getline(Buf4, 100);
		Jupiter.getline(Buf5, 100, ':');
		Jupiter.getline(Buf5, 100);
		Saturn.getline(Buf6, 100, ':');
		Saturn.getline(Buf6, 100);
		Uran.getline(Buf7, 100, ':');
		Uran.getline(Buf7, 100);
		Neptun.getline(Buf8, 100, ':');
		Neptun.getline(Buf8, 100);

		cout << "Таблица сортировки по именам" << endl;
		cout << std::setw(10) << " Название планеты" << std::setw(12) << "Перегелий" << std::setw(8) << "Афелий" << std::setw(25) << "Количество спутников" << std::setw(10) << endl;
		cout << "1)" << name1 << pereg1 << afel1 << colvo1 << endl;
		cout << "2)" << endl;
		cout << "3)" << endl;
		cout << "4)" << endl;
		cout << "5)" << endl;
		cout << "6)" << endl;
		cout << "7)" << endl;
		cout << "8)" << endl;
		cout << "9)" << endl;
		cout << "10)" << endl;
	}

};
int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	planet plan;
	plan.sortname();
}


