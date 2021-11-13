import cmath
import time
from lab_python_fp.LamerRng import *
class Gen_random(object):
    """description of class"""
    #def __init__(self):

    def gen_random(self,num_count, begin, end):
        nums=[]
        lemher = LamerRng(time.time()) #генерация случайного числа методом Ламера, с seed =time.time()
        for i in range(num_count): #Выборка из чисел нужного количества
            x=lemher.Next()
            num=int( ((end-begin)*x)+begin)
            nums.append(int(num))
            #print(int(num))
        return nums
