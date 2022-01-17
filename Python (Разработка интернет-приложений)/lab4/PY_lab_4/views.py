from django.shortcuts import render
from django.http import HttpResponse
from .forms import UserForm
def index(request):
    userform=UserForm()
    if request.method=="POST":
        name = request.POST.get("name")
        if name =="Action":
            #output="<title>Жанр игр Action</title><h2>Жанры игр {0}</h2><h3>Action (транслит. - «экшен» или «экшн»; в переводе с англ. - «действие») - жанр компьютерных игр, в которых успех игрока в большой степени зависит от его скорости реакции и способности быстро принимать тактические решения. Действие таких игр развивается очень динамично и требует высокую концентрацию внимания и быстрой реакции на происходящие в игре события.</h3><input type='submit' value='Send'>".format(name)
            #return HttpResponse(output)
            return render(request,"t_lab_4/Action.html")
        elif name=="RPG":
            return render(request,"t_lab_4/RPG.html")
        elif name=="MMO":
            return render(request,"t_lab_4/MMO.html")
        else:
            return render(request,"index.html",{"form": userform}) 
    else:
        return render(request,"index.html",{"form": userform}) #использование шаблона html 
    #return HttpResponse("<h2>Жанры игр</h2>")
 

# Create your views here.
