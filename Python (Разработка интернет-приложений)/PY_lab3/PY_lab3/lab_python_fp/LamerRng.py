#Алгоритм Ламера для генерации псевдослучайных чисел
class LamerRng(object):
        def __init__(self,sd):
            self.a=int(16807)
            self.m=int(2147483647)
            self.q=int(127773)
            self.r=int(2836)
            if (sd<=0 or sd >= 2147483647): 
                Exception("Bad seed")
            self.seed=sd

        def Next(self):
                hi=int(self.seed/self.q)
                lo=int (self.seed % self.q)
                self.seed = (self.a * lo) - (self.r*hi)
                if (self.seed<=0):
                    self.seed=self.seed+self.m
                return (self.seed*1.0)/self.m

