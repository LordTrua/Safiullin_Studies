class employee(object):
    """description of class"""
    did=0
    def __init__(self,second_name="",first_name="",patronymic="",pos="",zp=0,d_id=-1):
        self.name=[second_name,first_name,patronymic]
        self.position=pos
        self.profit=zp
        self.id=employee.did
        employee.did+=1
        self.Department_id=d_id


    def Get_Name(self):
        nm=""
        for i in self.name:
            nm=nm+" "+i
        return nm
    def Get_Position(self):
        return self.position
    def Get_Profit(self):
        return self.profit



