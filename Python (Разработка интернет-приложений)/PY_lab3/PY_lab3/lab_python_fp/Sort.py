class Sort(object):
    """description of class"""
    def sort(data):
        print ("Без лямбда функции")
        result=sorted(data,reverse=True)
        print (result)
        print("\n\n")
        print ("С лямбда функцией")
        result_with_lambda= lambda d: sorted(d,reverse=True)
        print (result_with_lambda(data))
        


