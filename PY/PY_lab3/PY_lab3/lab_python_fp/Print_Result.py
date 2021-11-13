class Print_Result(object):
    """description of class"""
    def print_result(func): 
        def wrapped(t=0):
            if (isinstance(func(),float) or isinstance(func(),int)or isinstance(func(),str)):
                print ("Функция:{}\n{}".format(str(func.__name__),func()))
            elif (isinstance(func(),dict)):
                print ("Функция:{}".format(str(func.__name__)))
                for key,value in func().items():
                    print(key,"=",value)
            elif (isinstance(func(),list)):
                print ("Функция:{}".format(str(func.__name__) ))
                for value in func():
                    print(value)
        return wrapped

    @print_result
    def test_1():
        return 1


    @print_result
    def test_2():
        return 'iu5'


    @print_result
    def test_3():
        return {'a': 1, 'b': 2}


    @print_result
    def test_4():
        return [1, 2]


