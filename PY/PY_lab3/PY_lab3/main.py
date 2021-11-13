from lab_python_fp.field import *
from lab_python_fp.gen_random import *
from lab_python_fp.Unique import *
from lab_python_fp.Sort import *
from lab_python_fp.Print_Result import *
from lab_python_fp.Cm_Timer import *
from lab_python_fp.Process_Data import *
import time
import json
import sys

def main():
     
     fie = Field()
     fie.test()

     print ("gen_random.py")
     gr= Gen_random()
     data=gr.gen_random(50,1,5)
     print(data)

     print("\n\n")
     print ("Unique.py")
     print (Unique.unique(data))
     print("\n\n")
     print (Unique.unique(["anton","Anton","b","B","B","C","c"]))
     print("\n\n")
     print (Unique.unique(["anton","Anton","b","B","B","C","c"],True))
     
     print("\n\n")
     print ("Sort.py")
     Sort.sort(Unique.unique(data))
     print("\n\n")
     print ("Print_Result.py") 
     print (Print_Result.test_1())
     print (Print_Result.test_2())
     print (Print_Result.test_3())
     print (Print_Result.test_4())
     print("\n\n")
     print ("Cm_Timer.py") 
     with Cm_Timer():
         time.sleep(5.5)
     with Cm_Timer.cm_timer2():
         time.sleep(5.5)
     print("\n\n")
     print ("Process_Data.py") 

     path = 'data_light.json'
     with open(path, encoding='utf-8') as f:
        dataa = json.load(f)
     with Cm_Timer():
       print( Process_Data.f4(Process_Data.f3(Process_Data.f2(Process_Data.f1(dataa))))  )
if __name__ =="__main__":
    main()
