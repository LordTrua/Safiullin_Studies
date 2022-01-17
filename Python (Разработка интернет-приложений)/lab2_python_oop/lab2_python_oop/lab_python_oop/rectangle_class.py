from lab_python_oop.Color import *
from lab_python_oop.G_Figure import *
class rectangle_class(G_Figure):
    """description of class"""
  
    def __init__(self,w,l,c):
        self.width =w
        self.length =l
        self.colour = Color(c)
        self.Name="Прямоугольник"
        self.Square()
       # print ("Фигура "+self.Name+" создана")
        #print ("Ширина фигуры: "+str(self.width)+"\nВысота фигуры:"+str(self.length)+"\nЦвет фигуры:"+str(self.colour.get_color()))
        pass
    def Square(self):
       self.square= self.width*self.length
    def __repr__(self):
        return  ('Название фигуры: {0}\nШирина фигуры: {1}\nВысота фигуры:{2}\nЦвет фигуры:{3}\nПлощадь фигуры:{4}\n').format(str(self.Name),str(self.width),str(self.length),str(self.colour.get_color()),str(self.Get_Square()))