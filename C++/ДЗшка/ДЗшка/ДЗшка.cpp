// ДЗшка.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
/*

Родительский класс бронемашина , развился дочерний классОБТ,
обладающий св-вами бронемашины и своими качествами, но вместе с ним появилась универсальна
боевая платформа, база для узких решений(САУ(с усиленным орудием), БМП(танк с дес. отделением),
БТР для борьбы с танками, для инженерных войск и т.д. и т.д.
*/

#include <iostream>
#include<string>
#include<Windows.h>


using namespace std;

class Panzerwagen
{
public:
    string Armor;
    string Gun;
    string name;
    string Classname;
    Panzerwagen(string n)
    {
        name = n;
        Armor = "Есть броня";
        Gun = "Орудие или пулемёт";
        Classname = "Танкетка/ броневик";
    }
    Panzerwagen(string n,string CN)
    {
        name = n;
        Armor = "Есть броня";
        Gun = "Орудие и пулемёт";
        Classname = CN;
    }
   
    void display()
    {
        cout << "Название техники: " << name << "\nКласс: " << Classname << "\nБроня: " << Armor << "\nВооружение: " << Gun << endl<<endl;
    }
};
class Panzers : public Panzerwagen
{
public:
    string Bulletprot;
    string shellprot;
    string EngineType;
    Panzers(string n, string CN) : Panzerwagen(n, CN)
    {
        Bulletprot = "Противопульное бронирование";
        shellprot = "Противоснарядное бронирование";
        EngineType = "Дизель";
    }
    Panzers(string n, string CN, string ET) : Panzerwagen(n, CN)
    {
        Bulletprot = "Противопульное бронирование";
        shellprot = "Противоснарядное бронирование";
        EngineType = ET;
    }
    void display()
    {
        cout << "Название техники: " << name << "\nКласс: " << Classname << "\nБроня: " << Armor << ": " << Bulletprot << "," << shellprot << "\nВооружение: " << Gun<<"\nТип двигателя:"<<EngineType<<endl<<endl;

    }

};
class OBT : public Panzers
{
public:
    string actprot;
    string platf;
     string Gunz;
    OBT(string n, string CN, string ET, int plat) : Panzers(n, CN, ET)
    {
        actprot = "Активная защита";
        Gunz = Gunt;
        if (plat == 1)
        {
            platf = "Да";

        }
        else if (plat == 0)
        {
            platf = "нет";
        }
    }
    OBT(string n, string CN, string ET,int plat,string GZ) : Panzers(n, CN, ET)
    {
        actprot = "Активная защита";
        Gunz = GZ;
        platf = "Да";
    }

    void display()
    {
        cout << "Название техники: " << name << "\nКласс: " << Classname << "\nБроня: " << Armor << ": " << Bulletprot << "," << shellprot<<","<< actprot << "\nВооружение: " << Gunz << "\nТип двигателя:" << EngineType <<"\nНа базе универсальной платформы: "<<platf<< endl<<endl;
    }
private:
    string Gunt="Универсальное орудие с многоцелевым снарядом";
};
class Platform : public OBT
{
public:
    Platform(string n, string CN, string ET, string GZ,string MT) : OBT(n, CN, ET, 1, GZ)
    {
        MachineType = MT;
    }
    void display()
    {
        cout << "Название техники: " << name << "\nКласс: " << Classname << "\nБроня: " << Armor << ": " << Bulletprot << "," << shellprot << "," << actprot << "\nВооружение: " << Gunz << "\nТип двигателя:" << EngineType << "\nНа базе универсальной платформы: " << platf<<"\nНазначение машины: "<<MachineType << endl << endl;
    }
private:
    string  MachineType;
};
int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    Panzerwagen BA10 ("Ба-10");
    BA10.display();
    Panzers Pz4("PzKpfw IV", "Танк");
    Pz4.display();
    OBT Armata("T-14 (Армата)", "ОБТ", "Универсальный", 1);
    Armata.display();
    Platform ArmataТ("T-15", "ОБТ", "Универсальный","Крупнокалиберный пулемёт","БТР");
    ArmataТ.display();
    OBT Abrams("Abrams", "ОБТ", "Универсальный", 0);
    Abrams.display();
}


