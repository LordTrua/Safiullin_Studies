from lab_python_oop.rectangle_class import *
from lab_python_oop.circle_class import *
from lab_python_oop.square_class import *
def main():
    t= rectangle_class(14,15,"Синий")
    print(t)
    print ("\n")
    r=circle_class(15,"Зелёный")
    print(r)
    print ("\n")
    s=square_class(15,"Красный")
    print(s)


if __name__ =="__main__":
    main()