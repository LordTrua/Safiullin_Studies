from lab_python_fp.field import *
from lab_python_fp.Unique import *
from lab_python_fp.gen_random import *
from lab_python_fp.Print_Result import *
class Process_Data(object):
    """description of class"""
    #@Print_Result.print_result
    def f1(data):
        return Field.field(Unique.unique(data,False),"job-name")
    #@Print_Result.print_result
    def f2(f1):
        return list(filter(lambda s: s  in f1, "Программист"))
    #@Print_Result.print_result
    def f3(f2):
        return list(map(lambda s: s+" знакомый с Python",f2))
    #@Print_Result.print_result
    def f4(f3):
        lis=[]
        for k,v in dict(zip(f3,Gen_random.gen_random(len(f3),100000,200000))): lis.append(str(k+"с зарплатой "+v))
        return lis


