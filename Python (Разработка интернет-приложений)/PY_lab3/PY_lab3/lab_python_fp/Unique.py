class Unique(object):
    """description of class"""
    def unique(data,ignore_case=False):
        #data_len = len(data)
        out_data=[]
        
        #print (New_data)
        x_v=""
        strr=""
        if (ignore_case==True):
           for x in data:
               strr=strr+" "+x
           strr=strr.casefold()
           New_data=sorted(strr.split(), key=str.lower)
        else: 
            New_data= sorted(data)
        for x in New_data:
                
                if (x!=x_v):
                   out_data.append(x)
                   x_v=x

        return out_data    

