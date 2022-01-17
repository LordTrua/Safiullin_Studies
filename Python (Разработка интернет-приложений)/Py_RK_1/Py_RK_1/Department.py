from employee import *
from prettytable import PrettyTable

class Department(object):
    """description of class"""
    did=0
    def __init__(self,ne="Отдел без имени", *emps):
        self.Department_id=Department.did
        Department.did+=1
        self.name=ne
        emp=employee()
        self.employeers=[emp]
        self.employeers.pop(0)
        for i in emps:
             self.employeers.append(i)
             i.Department_id=self.Department_id

    def Set_Name(self,nm):
        self.name=nm

    def Get_Name(self):
        return self.name

    def Add_Employee(self, employee):
        
        if(employee.Department_id==-1):
            employee.Department_id=self.Department_id
            self.employeers.append(employee)
        else:
            print ("Работник уже привязан, добавим sub-id")
            employee.Set_Sub_Id(self.Department_id)
            self.employeers.append(employee)

    def Get_Employee(self):
        mytable =PrettyTable()
        print(self.Get_Name())
        if (len(self.employeers)!=0):
            mytable.field_names=["id","Имя","Должность","Заработок(Р)"]
            #print("id "+str(self.Department_id)+" Сотрудники подразделения "+self.Get_Name()+": ")
            #print("id:           Имя:            Должность:                Заработок(P):")
        else: 
            #print("id "+Department_id+"Сотрудники подразделения "+self.Get_Name()+": ")
            print("Работников в отделе нет")
        for i in self.employeers:
            #print(str(i.id)+""+i.Get_Name()+"        "+i.Get_Position()+"         "+str(i.Get_Profit()))
            mytable.add_row([i.id,i.Get_Name(),i.Get_Position(),i.Get_Profit()])
        print(mytable)

    def Sort_By_Departments_Name(sorter="",*Departments):  #Сортировка по наличию слова sorted в имени отдела
        print ("Сортировка по слову: ",sorter)
        for i in Departments:
            if (any( word in  sorter.lower() for word in  i.Get_Name().lower().split())):   # Если имя отдела вне зависимости от кодировки начинается со слова Отдел то вывод
                i.Get_Employee()

    def Output_By_Median_Profit(*Departments) :                  #Вывод средней ЗП по отделу                      
       print("Средняя зп по отделам")
       for dep in Departments:
            medprofit=0  #Переменная для зарплаты в отделе
            for emp in dep.employeers:
                medprofit=medprofit+emp.Get_Profit()
            if(len(dep.employeers)!=0): medprofit=medprofit/len(dep.employeers)
            medprofit=round(medprofit,2)
            dep.Get_Employee()
            print("Средняя заработная плата по подразделению ",dep.Get_Name(),": ",str(medprofit))
            print("")

    def Output_Employee_In_Departments_Sort_By_Second_Name(check="",*Departments):
        mytable =PrettyTable()
        print ("Поиск по букве: ",check)
        mytable.field_names=["Id сотрудника","Сотрудник","Отдел"]
        for dep in Departments:
            for emp in dep.employeers:
                if(emp.name[0].lower().startswith(check.lower())):
                    mytable.add_row([emp.id,emp.Get_Name(),dep.Get_Name()])
                    #print ("Сотрудник: ",emp.Get_Name(),"Из отдела:",dep.Get_Name())
        print(mytable)
        return 0