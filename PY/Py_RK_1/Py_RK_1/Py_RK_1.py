#
#1)«Отдел» и «Сотрудник» связаны соотношением один-ко-многим. 
#Выведите список всех отделов, у которых в названии присутствует слово «отдел», и список работающих в них сотрудников.
#2)«Отдел» и «Сотрудник» связаны соотношением один-ко-многим.
# Выведите список отделов со средней зарплатой сотрудников в каждом отделе, отсортированный по средней зарплате. 
# Средняя зарплата должна быть округлена до 2 знака после запятой (отдельной функции вычисления среднего значения в Python нет,
#  нужно использовать комбинацию функций вычисления суммы и количества значений; 
#  для округления необходимо использовать функцию https://docs.python.org/3/library/functions.html#round).
#3)«Отдел» и «Сотрудник» связаны соотношением многие-ко-многим.
# Выведите список всех сотрудников, у которых фамилия начинается с буквы «А», и названия их отделов. 
from employee import *
from Department import *

def main():
  dep= Department ("Отдел закупок")
  #print(dep.Get_Name())
  Vasya= employee("Зайцев","Василий",pos="Плодов стола вкусилий",zp=300000)
  Egor= employee("Лохматенко","Егор",pos="Глава отдела",zp=122000)
  Ivan= employee("Пончиков","Иван",pos="Закупщик",zp=30000)
  dep.Add_Employee(Vasya)
  dep.Add_Employee(Egor)
  dep.Add_Employee(Ivan)
  dep.Get_Employee()

  dep2= Department("Отдел продаж", employee(first_name="Иван",second_name="Романов",pos="Закупщик",zp=52145), employee(first_name="Пётр",second_name="Пономарёв",pos="Перекупщик",zp=15321), employee(first_name="Иван ",pos="Продажщик",zp=33400))
  dep2.Add_Employee(Ivan) # попытка перепривязать работника
  dep2.Get_Employee()
  dep3= Department("Бухгалтерия", employee(first_name="Пётр",second_name="Иванов",pos="Глав.Бух.",zp=64305), employee(first_name="Пётр",second_name="Иванов",pos="Бухгалтер",zp=19321), employee(first_name="Иван ",second_name="Петров",pos="Продажщик",zp=33400))
  dep3.Get_Employee()
  print("")
  Department.Sort_By_Departments_Name("Отдел",dep,dep2,dep3)
  print("")
  Department.Output_By_Median_Profit(dep,dep2)
  print("")
  Department.Output_Employee_In_Departments_Sort_By_Second_Name("П",dep,dep2,dep3)



if(__name__=="__main__"):
    main()

