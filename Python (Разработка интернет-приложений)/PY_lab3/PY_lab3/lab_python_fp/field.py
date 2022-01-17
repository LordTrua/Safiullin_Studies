class Field(object):
    def test(self):
         print("Файл: field.py\n")
         search='title'
         search2='color'
         search3 ='price'
         goods = [
                {'title': 'Ковер', 'price': 2000, 'color': 'green'},
                {'title': 'Диван для отдыха', 'color': 'black'},
                {'title': 'Диван для гостей', 'color': 'black'},
                {'title': 'Ковер но другой', 'price': 4000},
            ]
         #print(type(goods))
         self.field(goods,search)
         self.field(goods,search,search2)
         self.field(goods,search,search2,search3)

    def field(self,items,*args):
        assert len(args)>0,'Количество аргументов меньше 1'
        if len(args)!=1:
            print("Результат поиска")
            for x in items:
               print("{",end='')
               for key,value in x.items():
                   for search in args:
                       if (key ==search):
                         print(key,":",value,",",end='')
                         print(" ",end='')
               print("}")
               print("")
        else:
            res=[]
            print("Результат поиска")
            for x in items:
                for key,value in x.items():
                    for search in args:
                        if key ==search :
                            print(value)
                            res.append(value)
            print("")
            return res