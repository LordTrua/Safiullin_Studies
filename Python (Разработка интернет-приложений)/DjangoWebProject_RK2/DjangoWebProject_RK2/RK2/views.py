from django.shortcuts import render
from rest_framework import viewsets
from RK2.serializers import DepartmentSerializer, EmployeersSerializer
from RK2.models import Department, Employeers
# Create your views here.

class DepartmentSet(viewsets.ModelViewSet):
    """
    API endpoint
    """
    # queryset 
    queryset = Department.objects.all()
    serializer_class = DepartmentSerializer  

class EmployeersSet(viewsets.ModelViewSet):
    """
    API endpoint
    """
    # queryset 
    queryset = Employeers.objects.all().order_by('id')
    serializer_class = EmployeersSerializer 

def report(request):
    return render (request, 'RK2\\rep.html' , {'data':{'Emps':Employeers.objects.select_related('Dep')}})
