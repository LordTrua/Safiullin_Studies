class Color(object):
    """description of class"""
    def __init__(self,col="Белый"):
        self.set_color(col)

    def set_color(self,col):
        if col=="Белый":
            self.color=col
        elif col =="Голубой":
            self.color=col
        elif col =="Синий":
            self.color=col
        elif col =="Фиолетовый":
            self.color=col
        elif col =="Чёрный":
            self.color=col
        elif col =="Зеленый":
            self.color=col
        elif col =="Красный":
            self.color=col
        else:
            self.color="Белый"

    def get_color(self):
        return str(self.color)

    _color= property(set_color,get_color)