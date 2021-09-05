from lab_python_oop.Color import *
from lab_python_oop.G_Figure import *
import math
class circle_class(G_Figure):
    """description of class"""
    def __init__(self,r,c):
        self.radius=r
        self.colour = Color(c)
        self.Name="Круг"
        self.Square()
        #print ("Фигура "+self.Name+" создана")
        #print ("Радиус фигуры: "+str(self.radius)+"\nЦвет фигуры:"+str(self.colour.get_color()))
    def get_radius(self):
        return self.radius
    def Square(self):
        self.square= math.pi* self.radius*self.radius
    def __repr__(self):
           return  "Название фигуры: {0}\nРадиус фигуры: {1}\nЦвет фигуры: {2}\nПлощадь фигуры:{3}\n".format(self.Name,str(self.radius),str(self.colour.get_color()),str(self.Get_Square()) )