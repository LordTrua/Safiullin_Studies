from lab_python_oop.rectangle_class import *
class square_class(rectangle_class):
    """description of class"""
    def __init__(self,w,c):
        self.length=w
        self.width=w
        self.colour=Color(c)
        self.Name="Квадрат"
        self.Square()
        #print ("Фигура "+self.Name+" создана")
        #print ("Ширина фигуры: "+str(self.width)+"\nВысота фигуры:"+str(self.length)+"\nЦвет фигуры:"+str(self.colour.get_color()))