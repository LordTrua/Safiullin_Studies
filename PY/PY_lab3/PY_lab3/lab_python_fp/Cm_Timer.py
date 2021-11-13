from contextlib import *
import time
class Cm_Timer(object):
    def cm_timer1(t2,selft2):
        print(selft2)
    def __enter__(self):
        self.t1=time.time()
        
        return 0
    def __exit__(self,a,b,c):
        self.t2=time.time()
        self.t2=self.t2- self.t1
        return self.cm_timer1(self.t2)

    @contextmanager
    def cm_timer2():
        try:
            t1=time.time()
            yield {}
        finally:
            t2=time.time()-t1
            print (t2)
         