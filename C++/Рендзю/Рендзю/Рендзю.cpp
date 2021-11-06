//Программа Рендзю.  Выполнил: Сафиуллин Антон Павлович 18.04.2020
//Программа нуждается в тесте, добавлен режим два игрока (Мало ли вам захочется поиграть в это чудо)
//Привинчена какая никакая визуалка (просто захотелось)

#include <iostream>
#include <string>// Ну... Тоже добавлено на всякий.
#include <fstream>//Ну мало ли, надо будет потом доделать лог игры , вот оно тут и стоит
#include<iomanip> //Просто надо...
#include <Windows.h> // Подключаем локалку
#include<vector>

using namespace std;



class field
{

public:
    field() { create(); }
    int fid[15][15];
    void create()
    {
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                fid[i][j] = 0;
            }
        }
    }
protected:
    void visual()
    {
        cout << "столбцы" << endl;
        cout << "1   2   3   4   5   6   7   8   9   10  11  12  13  14  15 строки" << endl;
        for (int i = 0; i <= 14; i++)
        {
            for (int j = 0; j <= 14; j++)
            {

                if (j <= 13)
                {
                    if (fid[i][j] == 0)
                    {
                        cout << "0" << "---";
                    }
                    else if (fid[i][j] == 1)
                    {
                        cout << "G" << "---";
                    }
                    else if (fid[i][j] == 2)
                    {
                        cout << "M" << "---";
                    }

                }
                else
                {
                    if (fid[i][j] == 0)
                    {
                        cout << "0" << "  " << i + 1;
                    }
                    else if (fid[i][j] == 1)
                    {
                        cout << "G" << "  " << i + 1;
                    }
                    else if (fid[i][j] == 2)
                    {
                        cout << "M" << "  " << i + 1;
                    }
                }
            }
            if (i <= 13)
            {
                cout << endl;
                cout << "|   |   |   |   |   |   |   |   |   |   |   |   |   |   |";
                cout << endl;
            }
            else cout << endl;
        }
    }
};



class game : public field
{
protected:
    int GrandR1 = -1, GrandR2 = -1;// Координата точки интереса
    vector <int> Grand;
    string Vnap="E";
   // vector <vector<int>> Gpoint, Kpoint;
    int First;
    int getRandomNumber(int lower_bound, int upper_bound)
    {
        return lower_bound + (upper_bound - lower_bound) * static_cast<int>(static_cast<double>(rand()) / RAND_MAX);
    }
public:
    int first = 0;// Маркер того, кто начинает, необходим для проверки правил
    int hodi()
    {
        int random = getRandomNumber(0, 1);
        if (random == 1) // Первый ход и установка камешка ( в соответствии с правилами первого хода на H8) "Небесное Начало"
        {
            cout << "Начинает игрок 1" << endl;
            fid[7][7] = 1;
            random = 0;
            first = 1;
        }
        else if (random == 0)
        {
            cout << "Начинает Компьютер/Игрок 2" << endl;
            fid[7][7] = 2;
            random = 1;
            first = 2;
        }
        visual();
        return random;
    }
    void gamez()
    {
        int random = hodi();
        int r1 = -1, r2 = -1, r3, r4, breack=0;
        while (1)
        {
            if (random == 2000)
            {
                cout << endl << endl;
                visual();
                break;
            }
            if (random == 0)
            {
              random= Ai(r1,r2);
              while (fid[r1][r2] == 1 || fid[r1][r2] == 2)
              {
                  random = Ai(r1, r2);
                  breack++;
                  if (breack > 10)
                  {
                      breack = 0;
                      r1 = -1;
                      r2 = -1;
                  }
              }
              fid[r1][r2] = 2;
              r1 = -1;
              r2 = -1;
              visual();
            }
            else if (random == 1)
            {
                cout << "Введите поле, в которое хотите поставить камешек" << endl;
                cout << "строка: ";
                cin >> r3;
                cout << endl << "столбец: ";
                cin >> r4;
                cout << endl;
                r3--;
                r4--;
                while ((fid[r3][r4] == 1) || (fid[r3][r4] == 2) || r3 >= 15 || r4 >= 15 || r3 < 0 || r4 < 0)
                {
                    if (r3 >= 15 || r4 >= 15 || r3 < 0 || r4 < 0) { cout << "клетки не существует" << endl; }
                    else { cout << "Клетка уже занята" << endl; }
                    cout << "Введите поле, в которое хотите поставить камешек" << endl;
                    cout << "строка: ";
                    cin >> r3;
                    cout << endl << "столбец: ";
                    cin >> r4;
                    cout << endl;
                    r3--;
                    r4--;
                }
                system("cls");
                fid[r3][r4] = 1;
                random = 0;
            }
            random = rule(random);
        }



    }
    int rule(int random)  
    {
        //////////////Проврка столбцов и  строк на выйгрышные комбинации 
        for (int j = 0; j < 15; j++)// проверка строк на победную комбинацию столбцы
        {
            for (int k = 0; k < 11; k++)
            {
                if ( ( (fid[k][j] == 1) && (fid[k + 1][j] == 1) && (fid[k + 2][j] == 1) && (fid[k + 3][j] == 1) && (fid[k + 4][j] == 1) )  || ( (fid[k][j] == 2) && (fid[k + 1][j] == 2) && (fid[k + 2][j] == 2) && (fid[k + 3][j] == 2) && (fid[k + 4][j] == 2) )) //проверка победных пятёрок в столбце
                {
                    if (fid[k][j] == 1) // Проверка пятёрок игрока
                    {
                        if (first == 2)// Если игрок начинал вторым, то вне зависимости от того пятёрка это или шестёрка он победил
                        {
                            cout << "Игрок победил... " << endl;
                            return 2000;
                        }
                        else if (first == 1) // Если игрок ходил первым проверяем, не является ли его пятёрка . шестёркой
                        {
                            if (k == 0) //Проверка крайней левой клетки 
                            {
                                if (fid[k + 5][j] == 1)
                                {
                                    cout << "Компьютер победил... " << endl;
                                    return 2000;
                                }
                                else
                                {
                                    cout << "Игрок победил... " << endl;
                                    return 2000;
                                }
                            }
                            else if (k > 0 || k < 10) // проверка промежуточных клеток
                            {
                                if ((fid[k + 5][j] == 1) || (fid[k - 1][j] == 1))
                                {
                                    cout << "Компьютер победил... " << endl;
                                    return 2000;
                                }
                                else
                                {
                                    cout << "Игрок победил... " << endl;
                                    return 2000;
                                }
                            }
                            else if (k == 10) //проверка клеток при построении пятёрки/шестёрки от правого угла
                            {
                                if (fid[k - 1][j] == 1)
                                {
                                    cout << "Компьютер победил... " << endl;
                                    return 2000;
                                }
                                else
                                {
                                    cout << "Игрок победил... " << endl;
                                    return 2000;
                                }
                            }
                        }
                    }

                    else if (fid[k][j] == 2)
                    {
                        if (first == 2)// Если компьютер начинал вторым, то вне зависимости от того пятёрка это или шестёрка он победил
                        {
                            cout << "Компьютер победил... " << endl;
                            return 2000;
                        }
                        else if (first == 1) // Если компьютер ходил первым, проверяем, не является ли его пятёрка . шестёркой
                        {
                            if (k == 0) //Проверка крайней левой клетки 
                            {
                                if (fid[k + 5][j] == 1)
                                {
                                    cout << "Игрок победил... " << endl;
                                    return 2000;
                                }
                                else
                                {
                                    cout << "Компьютер победил... " << endl;
                                    return 2000;
                                }
                            }
                            else if (k > 0 || k < 10) // проверка промежуточных клеток
                            {
                                if ((fid[k + 5][j] == 1) || (fid[k - 1][j] == 1))
                                {
                                    cout << "Игрок победил... " << endl;
                                    return 2000;
                                }
                                else
                                {
                                    cout << "Компьютер победил... " << endl;
                                    return 2000;
                                }
                            }
                            else if (k == 10) //проверка клеток при построении пятёрки/шестёрки от правого угла
                            {
                                if (fid[k - 1][j] == 1)
                                {
                                    cout << "Игрок победил... " << endl;
                                    return 2000;
                                }
                                else
                                {
                                    cout << "Компьютер победил... " << endl;
                                    return 2000;
                                }
                            }
                        }
                    }
                }
            }
        }
        for (int j = 0; j < 15; j++)// проверка строк на победную комбинацию ряду
        {
            for (int k = 0; k < 11; k++)
            {
                if ( ( (fid[j][k] == 1) && (fid[j][k + 1] == 1) && (fid[j][k + 2] == 1) && (fid[j][k + 3] == 1) && (fid[j][k + 4] == 1) ) || ( (fid[j][k] == 2) && (fid[j][k + 1] == 2) && (fid[j][k + 2] == 2) && (fid[j][k + 3] == 2) && (fid[j][k + 4] == 2) ) ) //проверка победных пятёрок в ряду
                {
                    if (fid[j][k] == 1) // Проверка пятёрок игрока
                    {
                        if (first == 2)// Если игрок начинал вторым, то вне зависимости от того пятёрка это или шестёрка он победил
                        {
                            cout << "Игрок победил... " << endl;
                            return 2000;
                        }
                        else if (first == 1) // Если игрок ходил первым проверяем, не является ли его пятёрка . шестёркой
                        {
                            if (k == 0) //Проверка крайней левой клетки 
                            {
                                if (fid[j][k + 5] == 1 )
                                {
                                    cout << "Компьютер победил... " << endl;
                                    return 2000;
                                }
                                else
                                {
                                    cout << "Игрок победил... " << endl;
                                    return 2000;
                                }
                            }
                            else if (k > 0 || k < 10) // проверка промежуточных клеток
                            {
                                if ((fid[j][k + 5] == 1) || (fid[j][k - 1] == 1))
                                {
                                    cout << "Компьютер победил... " << endl;
                                    return 2000;
                                }
                                else
                                {
                                    cout << "Игрок победил... " << endl;
                                    return 2000;
                                }
                            }
                            else if (k == 10) //проверка клеток при построении пятёрки/шестёрки от правого угла
                            {
                                if (fid[j][k - 1] == 1)
                                {
                                    cout << "Компьютер победил... " << endl;
                                    return 2000;
                                }
                                else
                                {
                                    cout << "Игрок победил... " << endl;
                                    return 2000;
                                }
                            }
                        }
                    }

                    else if (fid[k][j] == 2)
                    {
                        if (first == 2)// Если компьютер начинал вторым, то вне зависимости от того пятёрка это или шестёрка он победил
                        {
                            cout << "Компьютер победил... " << endl;
                            return 2000;
                        }
                        else if (first == 1) // Если компьютер ходил первым, проверяем, не является ли его пятёрка . шестёркой
                        {
                            if (k == 0) //Проверка крайней левой клетки 
                            {
                                if (fid[j][k + 5] == 1)
                                {
                                    cout << "Игрок победил... " << endl;
                                    return 2000;
                                }
                                else
                                {
                                    cout << "Компьютер победил... " << endl;
                                    return 2000;
                                }
                            }
                            else if (k > 0 || k < 10) // проверка промежуточных клеток
                            {
                                if ((fid[j][k + 5] == 1) || (fid[j][k - 1] == 1))
                                {
                                    cout << "Игрок победил... " << endl;
                                    return 2000;
                                }
                                else
                                {
                                    cout << "Компьютер победил... " << endl;
                                    return 2000;
                                }
                            }
                            else if (k == 10) //проверка клеток при построении пятёрки/шестёрки от правого угла
                            {
                                if (fid[j][k - 1] == 1)
                                {
                                    cout << "Игрок победил... " << endl;
                                    return 2000;
                                }
                                else
                                {
                                    cout << "Компьютер победил... " << endl;
                                    return 2000;
                                }
                            }
                        }
                    }
                }
            }
        }
        ///////////////////////////////////////Проверка диагоналей соответсвующим верхним и нижним от главной диагонали \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\/
        for (int n = 0; n < 11; n++)// Проверка верхней половины диагоналей
        {
            for (int k = 14 - n, l = 14; k >= 0, l >= 0; k--, l--)
            {
                if (((fid[k][l] == 1) && (fid[k - 1][l - 1] == 1) && (fid[k - 2][l - 2] == 1) && (fid[k - 3][l - 3] == 1) && (fid[k - 4][l - 4] == 1)) || ((fid[k][l] == 2) && (fid[k - 1][l - 1] == 2) && (fid[k - 2][l - 2] == 2) && (fid[k - 3][l - 3] == 2) && (fid[k - 4][l - 4] == 2)))
                {
                    if (fid[k][l] == 1) // Проверка пятёрок игрока
                    {
                        if (first == 2)// Если игрок начинал вторым, то вне зависимости от того пятёрка это или шестёрка он победил
                        {
                            cout << "Игрок победил... " << endl;
                            return 2000;
                        }
                        else if (first == 1)//проверка шестёрок
                        {
                            if (k == 0)
                            {
                                cout << "Игрок победил... " << endl;
                                return 2000;
                            }
                            else
                            {
                                if (fid[k - 5][l - 5] == 1 || fid[k+1][l + 1] == 1)
                                {
                                    cout << "Компьютер победил... " << endl;
                                    return 2000;
                                }
                                else
                                {
                                    cout << "Игрок победил... " << endl;
                                    return 2000;
                                }
                            }

                        }

                    }
                    else if (fid[k][l] == 2)
                    {
                        if (first == 1)// Если Компьютер начинал вторым, то вне зависимости от того пятёрка это или шестёрка он победил
                        {
                            cout << "Компьютер победил... " << endl;
                            return 2000;
                        }
                        else if (first == 2)//проверка шестёрок
                        {
                            if (k == 0)
                            {
                                cout << "Компьютер победил... " << endl;
                                return 2000;
                            }
                            else
                            {
                                if (fid[k - 5][l - 5] == 2 || fid[k+1][l + 1] == 2)
                                {
                                    cout << "Игрок победил... " << endl;
                                    return 2000;
                                }
                                else
                                {
                                    cout << "Компьютер победил... " << endl;
                                    return 2000;
                                }
                            }

                        }
                    }
                }
            }
        }

        for (int n = 0; n < 11; n++)// Проверка нижней половины диагоналей
        {
            for (int k = 14, l = 14 - n; k >= 0, l >= 0; k--, l--)
            {
                if (((fid[k][l] == 1) && (fid[k - 1][l - 1] == 1) && (fid[k - 2][l - 2] == 1) && (fid[k - 3][l - 3] == 1) && (fid[k - 4][l - 4] == 1)) || ((fid[k][l] == 2) && (fid[k - 1][l - 1] == 2) && (fid[k - 2][l - 2] == 2) && (fid[k - 3][l - 3] == 2) && (fid[k - 4][l - 4] == 2)))
                {
                    if (fid[k][l] == 1) // Проверка пятёрок игрока
                    {
                        if (first == 2)// Если игрок начинал вторым, то вне зависимости от того пятёрка это или шестёрка он победил
                        {
                            cout << "Игрок победил... " << endl;
                            return 2000;
                        }
                        else if (first == 1)//проверка шестёрок
                        {
                            if (k == 0)
                            {
                                cout << "Игрок победил... " << endl;
                                return 2000;
                            }
                            else
                            {
                                if (fid[k - 5][l - 5] == 1 || fid[k+1][l + 1] == 1)
                                {
                                    cout << "Компьютер победил... " << endl;
                                    return 2000;
                                }
                                else
                                {
                                    cout << "Игрок победил... " << endl;
                                    return 2000;
                                }
                            }

                        }

                    }
                    else if (fid[k][l] == 2)
                    {
                        if (first == 1)// Если Компьютер начинал вторым, то вне зависимости от того пятёрка это или шестёрка он победил
                        {
                            cout << "Компьютер победил... " << endl;
                            return 2000;
                        }
                        else if (first == 2)//проверка шестёрок
                        {
                            if (k == 0)
                            {
                                cout << "Компьютер победил... " << endl;
                                return 2000;
                            }
                            else
                            {
                                if (fid[k - 5][l - 5] == 2 || fid[k+1][l + 1] == 2)
                                {
                                    cout << "Игрок победил... " << endl;
                                    return 2000;
                                }
                                else
                                {
                                    cout << "Компьютер победил... " << endl;
                                    return 2000;
                                }
                            }

                        }
                    }
                }
            }
        }
        ////////////////////////////////////////////////////////////\\\\\\\\\\\\\\\\\\\\.
        ////Проверка Диагоналей противополоным главной\\\\\\\\\\\\/
        for (int n = 0; n < 11; n++)//Проверка Верхних Обратныхх Диагоналей
        {
            for (int k = 14 - n, l = 0; k >= 0, l < 15; k--, l++)
            {
                if (((fid[k][l] == 1) && (fid[k - 1][l + 1] == 1) && (fid[k - 2][l + 2] == 1) && (fid[k - 3][l + 3] == 1) && (fid[k - 4][l + 4] == 1)) || ((fid[k][l] == 2) && (fid[k - 1][l + 1] == 2) && (fid[k - 2][l + 2] == 2) && (fid[k - 3][l + 3] == 2) && (fid[k - 4][l + 4] == 2)))
                {
                    if (fid[k][l] == 1) // Проверка пятёрок игрока
                    {
                        if (first == 2)// Если игрок начинал вторым, то вне зависимости от того пятёрка это или шестёрка он победил
                        {
                            cout << "Игрок победил... " << endl;
                            return 2000;
                        }
                        else if (first == 1)//проверка шестёрок
                        {
                            if (k == 4)
                            {
                                cout << "Игрок победил... " << endl;
                                return 2000;
                            }
                            else
                            {
                                if (fid[k - 5][l + 5] == 1 || fid[k+1][l - 1] == 1)
                                {
                                    cout << "Компьютер победил... " << endl;
                                    return 2000;
                                }
                                else
                                {
                                    cout << "Игрок победил... " << endl;
                                    return 2000;
                                }
                            }
                        }
                    }
                    else if (fid[k][l] == 2)
                    {
                        if (first == 1)// Если Компьютер начинал вторым, то вне зависимости от того пятёрка это или шестёрка он победил
                        {
                            cout << "Компьютер победил... " << endl;
                            return 2000;
                        }
                        else if (first == 2)//проверка шестёрок
                        {
                            if (k == 4)
                            {
                                cout << "Компьютер победил... " << endl;
                                return 2000;
                            }
                            else
                            {
                                if (fid[k - 5][l + 5] == 1 || fid[k + 1][l - 1] == 1)
                                {
                                    cout << "Игрок победил... " << endl;
                                    return 2000;
                                }
                                else
                                {
                                    cout << "Компьютер победил... " << endl;
                                    return 2000;
                                }
                            }
                        }
                    }
                }
            }

        }

        for (int n = 0; n < 11; n++)//Проверка нижних Обратныхх Диагоналей
        {
            for (int k = 14, l = 0 + n; k >= 0, l < 15; k--, l++)
            {
                if (((fid[k][l] == 1) && (fid[k - 1][l + 1] == 1) && (fid[k - 2][l + 2] == 1) && (fid[k - 3][l + 3] == 1) && (fid[k - 4][l + 4] == 1)) || ((fid[k][l] == 2) && (fid[k - 1][l + 1] == 2) && (fid[k - 2][l + 2] == 2) && (fid[k - 3][l + 3] == 2) && (fid[k - 4][l + 4] == 2)))
                {
                    if (fid[k][l] == 1) // Проверка пятёрок игрока
                    {
                        if (first == 2)// Если игрок начинал вторым, то вне зависимости от того пятёрка это или шестёрка он победил
                        {
                            cout << "Игрок победил... " << endl;
                            return 2000;
                        }
                        else if (first == 1)//проверка шестёрок
                        {
                            if (k == 4)
                            {
                                cout << "Игрок победил... " << endl;
                                return 2000;
                            }
                            else
                            {
                                if (fid[k - 5][l + 5] == 1 ||fid[k+1][l - 1] == 1)
                                {
                                    cout << "Компьютер победил... " << endl;
                                    return 2000;
                                }
                                else
                                {
                                    cout << "Игрок победил... " << endl;
                                    return 2000;
                                }
                            }
                        }
                    }
                    else if (fid[k][l] == 2)
                    {
                        if (first == 1)// Если Компьютер начинал вторым, то вне зависимости от того пятёрка это или шестёрка он победил
                        {
                            cout << "Компьютер победил... " << endl;
                            return 2000;
                        }
                        else if (first == 2)//проверка шестёрок
                        {
                            if (k == 4)
                            {
                                cout << "Компьютер победил... " << endl;
                                return 2000;
                            }
                            else
                            {
                                if (fid[k - 5][l + 5] == 2 || fid[k + 1][l - 1] == 2)
                                {
                                    cout << "Игрок победил... " << endl;
                                    return 2000;
                                }
                                else
                                {
                                    cout << "Компьютер победил... " << endl;
                                    return 2000;
                                }
                            }
                        }
                    }
                }
            }
        }
        return random;
    }
    void games()  // Игра 2х игроков 
    {
        {
            int random = hodi();
            int r1, r2;
            while (1)
            {
                if (random == 0)
                {
                    cout << "                Ход игрока 2      " << endl;
                    cout << "Введите поле, в которое хотите поставить камешек" << endl;
                    cout << "строка: ";
                    cin >> r1;
                    cout << endl << "столбец: ";
                    cin >> r2;
                    cout << endl;
                    r1--;
                    r2--;
                    while ((fid[r1][r2] == 1) || (fid[r1][r2] == 2) || r1 > 15 || r2 > 15 || r1 < 1 || r2 < 1)
                    {
                        if (r1 >= 15 || r2 > 15) { cout << "клетки не существует" << endl; }
                        else { cout << "Клетка уже занята" << endl; }
                        cout << "Введите поле, в которое хотите поставить камешек" << endl;
                        cout << "строка: ";
                        cin >> r1;
                        cout << endl << "столбец: ";
                        cin >> r2;
                        cout << endl;
                    }
                    fid[r1 - 1][r2 - 1] = 2;
                    random = 1;
                    visual();
                }
                else if (random == 1)
                {
                    cout << "  Ход игрока 1    " << endl;
                    cout << "Введите поле, в которое хотите поставить камешек" << endl;
                    cout << "строка: ";
                    cin >> r1;
                    cout << endl << "столбец: ";
                    cin >> r2;
                    cout << endl;
                    r1--;
                    r2--;
                    while ((fid[r1][r2] == 1) || (fid[r1][r2] == 2) || r1 > 15 || r2 > 15 || r1 < 1 || r2 < 1)
                    {
                        if (r1 >= 15 || r2 > 15) { cout << "клетки не существует" << endl; }
                        else { cout << "Клетка уже занята" << endl; }
                        cout << "Введите поле, в которое хотите поставить камешек" << endl;
                        cout << "строка: ";
                        cin >> r1;
                        cout << endl << "столбец: ";
                        cin >> r2;
                        cout << endl;
                        r1--;
                        r2--;
                    }
                    fid[r1][r2] = 1;
                    random = 0;
                    visual();
                }
                else if (random == 2000)
                {
                    cout << endl << endl;
                    visual();
                    break;
                }
                random = rule(random);
            }
        }
    };
    int Ai(int& r1, int& r2)
    {
            if (GrandR1 == -1)// Случайная точка интереса
            {
                GrandR1 = getRandomNumber(6, 8);
                GrandR2 = getRandomNumber(6, 8);
                while (fid[GrandR1][GrandR2] != 0)
                {
                    GrandR1 = getRandomNumber(6, 8);
                    GrandR2 = getRandomNumber(6, 8);
                }
               
            }
            if (GrandR1 != -1) // Защита 
            {
                
                for (int i = 0; i < 15; i++)
                {
                    int stop = -1;
                    if (stop == -1)
                    {
                        for (int j = 0; j < 15; j++)
                        {
                            if (i <= 13 && j <= 13 && i > 0 && j > 0)
                            {
                                ///////Для строк
                                if ((fid[i][j] == 1) && (fid[i][j + 1] == 1))//Если, совпадают строки, или стобцы проверяем
                                {
                                    if ((j + 3 < 15) && fid[i][j + 2] == 1)
                                    {
                                        r1 = i;
                                        r2 = j + 3;
                                        if (fid[r1][r2] != 0)
                                        {
                                            if (fid[i][j - 1] == 0) { r1 = i; r2 = j - 1; stop = 0; break; }
                                            else if (j + 4 < 15 && fid[i][j + 4] == 0) { r1 = i; r2 = j + 4; stop = 0; break; }
                                            else
                                            {
                                                r1 = -1;
                                                r2 = -1;
                                                stop = 0; break;
                                            }
                                        }
                                        stop = 0; break;
                                    }
                                    else if ((j + 4 < 15) && fid[i][j + 2] == 0)
                                    {
                                        r1 = i;
                                        r2 = j + 2;
                                        if (fid[r1][r2] != 0)
                                        {
                                            r2 = j + 3;
                                            stop = 0; break;
                                        }
                                        stop = 0; break;
                                    }
                                    else
                                    { r1 = -1; r2 = -1; stop = 0; break;}

                                }
                                if ((fid[i][j] == 1 && fid[i][j - 1] == 1))
                                {
                                    if ((j - 3 >= 0) && fid[i][j - 2] == 1)
                                    {
                                        r1 = i;
                                        r2 = j - 3;
                                        if (fid[r1][r2] != 0)
                                        {

                                            if (fid[i][j + 1] == 0) { r1 = i; r2 = j - 1; stop = 0; break; }
                                            else if (j - 4 >= 0 && fid[i][j - 4] == 0) { r1 = i; r2 = j - 4; stop = 0; break; }
                                            else { r1 = -1; r2 = -1; stop = 0; break;}
                                        }
                                        stop = 0; break;
                                    }
                                    else if ((j - 3 >= 0) && fid[i][j - 2] == 0)
                                    {
                                        r1 = i;
                                        r2 = j - 2;
                                        if (fid[i][j - 2] == 1)
                                        {
                                            r2 = j - 3;
                                            stop = 0; break;
                                        }
                                    }
                                    else { r1 = -1; r2 = -1; stop = 0; break; }
                                }
                                ////////
                                //////// Для столбцов 
                                if ((fid[i][j] == 1 && fid[i + 1][j] == 1))
                                {
                                    if ((i + 3 < 15) && fid[i + 2][j] == 1)
                                    {
                                        r1 = i + 3;
                                        r2 = j;
                                        if (fid[r1][r2] != 0)
                                        {
                                            if (fid[i - 1][j] == 0) { r1 = i - 1; stop = 0; break; }
                                        }
                                        stop = 0; break;
                                    }
                                    else
                                    {
                                        r1 = -1;
                                        r2 = -1;
                                        stop = 0; break;
                                    }
                                }
                                if ((fid[i][j] == 1 && fid[i - 1][j] == 1))
                                {
                                    if ((i - 3 >= 0) && fid[i - 2][j] == 1)
                                    {
                                        r1 = i - 3;
                                        r2 = j;
                                        if (fid[r1][r2] != 0)
                                        {
                                            if (fid[i - 1][j] == 0) { r1 = i - 1; stop = 0; break; }
                                        }
                                        stop = 0; break;
                                    }
                                    else
                                    {
                                        r1 = -1;
                                        r2 = -1;
                                        stop = 0; break;
                                    }
                                }
                                //Для диагоналей
                                if (fid[i][j] == 1 && (fid[i + 1][j + 1] == 1 || fid[i - 1][j - 1] == 1 || fid[i + 1][j - 1] == 1 || fid[i - 1][j + 1] == 1))
                                {
                                    if (fid[i][j] == 1 && (fid[i + 1][j + 1] == 1))
                                    {
                                        if (i + 3 < 15 && j + 3 < 15)
                                        {
                                            if (fid[i + 3][j + 3] == 1 && fid[i + 2][j + 2] != 1 && fid[i + 1][j + 1] == 1)
                                            {
                                                r1 = i + 2;
                                                r2 = j + 2;
                                                stop = 0; break;

                                            }
                                            else if (fid[i + 1][j + 1] == 1 && fid[i + 2][j + 2] == 1)
                                            {
                                                r1 = i + 3;
                                                r2 = j + 3;
                                                if (fid[r1][r2] != 0 && i-1>=0 && j-1>=0)
                                                {
                                                    r1 = i - 1;
                                                    r2 = j - 1;
                                                    stop = 0; break;
                                                }
                                                stop = 0; break;
                                            }

                                        }
                                    }
                                    if (fid[i][j] == 1 && fid[i - 1][j - 1] == 1)
                                    {
                                        if (i - 3 >= 0 && j - 3 >= 0)
                                        {
                                            if (fid[i - 3][j - 3] == 1 && fid[i - 2][j - 2] == 0 && fid[i - 1][j - 1] == 1)
                                            {
                                                r1 = i - 2;
                                                r2 = j - 2;
                                                stop = 0; break;
                                            }
                                            else if (fid[i - 3][j - 3] == 1 && fid[i - 2][j - 2] == 1 && fid[i + 1][j + 1] == 0)
                                            {
                                                r1 = i + 1;
                                                r2 = j + 1;
                                                stop = 0; break;
                                            }
                                            else if (fid[i + 1][j + 1] == 1 && fid[i+2][j+2]==0)
                                            {
                                                r1 = i + 2;
                                                r2 = j + 2;
                                                stop = 0; break;
                                            }
                                        }
                                    }
                                    if (fid[i][j] == 1 && fid[i - 1][j + 1] == 1)
                                    {
                                        if (i - 3 >= 0 && j + 3 < 15)
                                        {
                                            if (fid[i - 3][j + 3] == 1 && fid[i - 2][j + 2] != 1)
                                            {
                                                r1 = i - 2;
                                                r2 = j + 2;
                                                stop = 0; break;
                                            }
                                            else if (fid[i - 3][j + 3] == 1 && fid[i - 2][j + 2] == 1 && fid [i+1][j-1]==0)
                                            {
                                                r1 = i + 1;
                                                r2 = j - 1;
                                                stop = 0; break;
                                            }
                                        }
                                    }
                                    if (fid[i][j] == 1 && fid[i + 1][j - 1] == 1)
                                    {
                                        if (i + 3 < 15 && j + 3 >= 0)
                                        {
                                            if (fid[i + 3][j - 3] == 1 && fid[i + 2][j - 2] != 1 && fid[i + 1][j - 1] == 1)
                                            {
                                                r1 = i + 2;
                                                r2 = j - 2;
                                                stop = 0; break;
                                            }
                                            else if (fid[i + 3][j - 3] == 1 && fid[i + 2][j - 2] == 1 && fid[i - 1][j + 1] == 0)
                                            {
                                                r1 = i - 1;
                                                r2 = j + 1;
                                                stop = 0; break;
                                            }
                                            else if (fid[i + 2][j - 2] == 1 && fid[i - 1][j + 1] == 0)
                                            {
                                                r1 = i - 1;
                                                r2 = j + 1;
                                                stop = 0; break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        r1 = -1;
                                        r2 = -1;
                                    }
                                    stop = 0; break;
                                }

                            }
                            else if (i == 0 || j == 0 || j == 14 || i == 14)
                            {
                                if (i == 0 && j > 0 && j < 14)
                                {
                                    if (fid[i][j] == 1 && fid[i][j + 1] == 1)
                                    {
                                        if (j + 3 <= 14 && fid[i][j + 2] == 1 && (fid[i][j+3]!=1||fid[i][j+3]!=2) )
                                        {
                                            r1 = i;
                                            r2 = j + 3;
                                            stop = 0; break;
                                        }
                                        else if (j+3 <= 14 && fid[i][j + 2] == 0 && fid[i][j + 3] == 1 && fid[i][j + 3] != 2)
                                        {
                                            r1 = i; r2 = j + 2;
                                            stop = 0; break;
                                        }
                                        else
                                        {
                                            r1 = -1;
                                            r2 = -1;
                                            stop = 0; break;
                                        }
                                    
                                    }

                                }
                                if (j == 0 && i > 0 && i < 14)
                                {
                                    if (fid[i][j] == 1 && fid[i + 1][j] == 1)
                                    {
                                        if (i + 3 <= 14 && fid[i + 2][j] == 1 && fid[i + 3][j] == 0)
                                        {
                                            r1 = i + 3;
                                            r2 = j;
                                            stop = 0; break;
                                        }
                                        else if (i + 3 <= 14 && fid[i + 2][j] == 0 && fid[i + 3][j] == 1 && fid[i + 3][j] != 2)
                                        {
                                            r1 = i + 2; r2 = j;
                                            stop = 0; break;
                                        }
                                        else
                                        {
                                            r1 = -1;
                                            r2 = -1;
                                            stop = 0; break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (stop == 0 && fid[r1][r2] == 0){ break;}
                }
            }
            if (r1 == -1 || r2 == -1) // Атака
            {
                r1 = GrandR1;
                r2 = GrandR2;
                if (fid[r1 - 1][r2 - 1] == 0 && r1-1>=0 && r2-1>=0)
                {
                 
                        r1 = r1 - 1;
                        r2 = r2 - 1;
                        GrandR1 = r1;
                        GrandR2 = r2;
                }
                 if (fid[r1][r2 - 1] == 0 && r2 - 1 >= 0)
                {
                          r1 = r1;
                         r2 = r2 - 1;
                         GrandR1 = r1;
                         GrandR2 = r2;
                }
                 if (fid[r1-1][r2] == 0 && r1 - 1 >= 0)
                {
                    r1 = r1-1;
                    r2 = r2;
                    GrandR1 = r1;
                    GrandR2 = r2;
                }
                 if (fid[r1 + 1][r2 - 1] == 0 && r1 + 1 <15 && r2 - 1 >= 0)
                {
                    r1 = r1 + 1;
                    r2 = r2-1;
                    GrandR1 = r1;
                    GrandR2 = r2;
                }
                 if (fid[r1 + 1][r2] == 0 && r1 + 1 < 15)
                {
                    r1 = r1 + 1;
                    r2 = r2;
                    GrandR1 = r1;
                    GrandR2 = r2;
                }
                 if (fid[r1 + 1][r2+1] == 0 && r1 + 1 < 15 && r2 + 1 < 15)
                {
                    r1 = r1 + 1;
                    r2 = r2+1;
                    GrandR1 = r1;
                    GrandR2 = r2;
                }
                 if (fid[r1][r2 + 1] == 0 && r2 + 1 < 15)
                {
                    r1 = r1;
                    r2 = r2 + 1;
                    GrandR1 = r1;
                    GrandR2 = r2;
                }
                 if (fid[r1 - 1][r2 + 1] == 0&& r1 - 1 >= 0 && r2 + 1 < 15)
                {
                    r1 = r1-1;
                    r2 = r2 + 1;
                    GrandR1 = r1;
                    GrandR2 = r2;
                }
                 
                 if (fid[r1 - 1][r2 + 1] != 0 &&
                     fid[r1][r2 + 1] != 0 && 
                     fid[r1 + 1][r2 + 1] != 0 && 
                     fid[r1 + 1][r2] != 0 && 
                     fid[r1 + 1][r2 - 1] != 0 && 
                     fid[r1 - 1][r2] != 0 && 
                     fid[r1][r2 - 1] != 0 && 
                     fid[r1 - 1][r2 - 1] != 0)
                 {
                     while (fid[GrandR1][GrandR2] != 0)
                     {
                         GrandR1 = getRandomNumber(3, 12);
                         GrandR2 = getRandomNumber(3, 12);
                     }
                 }
            }
            int random = 1;
            return random;
    }

 
};




int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    cout << "Играете  один или с другом ? (1,2)" << endl;
    int ruller;
    cin >> ruller;
    if (ruller == 1)
    {
        game gm;
        gm.gamez();
    }
    else if (ruller == 2)
    {
        game gm;
        gm.games();
    }

}