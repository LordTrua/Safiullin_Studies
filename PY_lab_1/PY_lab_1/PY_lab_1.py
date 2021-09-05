#Задание:
#Разработать программу для решения биквадратного уравнения.
#Программа должна быть разработана в виде консольного приложения на языке Python.
#Программа осуществляет ввод с клавиатуры коэффициентов А, В, С, вычисляет дискриминант 
#  и ДЕЙСТВИТЕЛЬНЫЕ корни уравнения (в зависимости от дискриминанта).
#
#Коэффициенты А, В, С могут быть заданы в виде параметров 
#командной строки ( вариант задания параметров приведен в конце файла с примером кода ). 
#Если они не заданы, то вводятся с клавиатуры в соответствии с пунктом 2. 
#Описание работы с параметрами командной строки.
#Если коэффициент А, В, С введен или задан в командной строке некорректно, 
#то необходимо проигнорировать некорректное значение и вводить коэффициент повторно 
#пока коэффициент не будет введен корректно. 
#Корректно заданный коэффициент - это коэффициент, з
#начение которого может быть без ошибок преобразовано в действительное число.

import cmath
import colorama
from colorama import init
init()
from colorama import Fore, Back, Style
print ("Ax^4+Bx^2+C\nВведите A,B,C:")
A=""
B=""
C=""
while ((isinstance(A,int) or isinstance (A,float))!=True): #Проверка на тип переменной A
    try:
        A =float( input ("Введите А: "))
        print(type(A))
    except :
        print ("A введено некорректно")
        print(type(A))

while ((isinstance(B,int) or isinstance (B,float))!=True): #Проверка на тип переменной B
    try:
        B =float( input ("Введите B: "))
        print(type(B))
    except :
        print ("B введено некорректно")
        print(type(B))

while ((isinstance(C,int) or isinstance (C,float))!=True): #Проверка на тип переменной C
    try:
        C =float( input ("Введите C: "))
        print(type(C))
    except :
        print ("C введено некорректно")
        print(type(C))

print ("Выражение: "+str(A)+"x^4+"+str(B)+"x^2+"+str(C))
print ("Считаем...")
if (A!=0):
   Dxpp=cmath.sqrt( (-B+cmath.sqrt((B*B)-4*A*C ))/(2*A) )
   Dxpm=cmath.sqrt( (-B-cmath.sqrt((B*B)-(4*A*C))) /(2*A))
   Dxmp=-cmath.sqrt( (-B+cmath.sqrt((B*B)-(4*A*C))) /(2*A))
   Dxmm=-cmath.sqrt( (-B-cmath.sqrt( (B*B) - (4*A*C) )) /(2*A))

   if Dxpp.imag==0:
       print (Fore.GREEN+"x1= "+str(Dxpp.real))
       
   else:
       print (Fore.RED+"x1= "+str(Dxpp))

   if Dxpm.imag==0:
       print (Fore.GREEN+"x2= "+str(Dxpm.real))
   else:
       print (Fore.RED+"x2= "+str(Dxpm))

   if Dxmp.imag==0:
       print (Fore.GREEN+"x3= "+str(Dxmp.real))
   else:
       print (Fore.RED+"x3= "+str(Dxmp))

   if Dxmm.imag==0:
       print (Fore.GREEN+"x4= "+str(Dxmm.real))
   else:
       print (Fore.RED+"x4= "+str(Dxmm))
else:
    X=cmath.sqrt(-C/B)
    Xm=cmath.sqrt(-C/B)
    if X.imag==0:
        print (Fore.GREEN+"x1= "+str(X.real))
    else:
        print (Fore.RED+"x1= "+str(X))
    if Xm.imag==0:
        print (Fore.GREEN+"x1= "+str(Xm.real))
    else:
        print (Fore.RED+"x1= "+str(Xm))