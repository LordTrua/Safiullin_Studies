from RK2.models import  Department, Employeers
from rest_framework import serializers

class DepartmentSerializer(serializers.ModelSerializer):
    class Meta:
        model = Department
        fields = "__all__"

class EmployeersSerializer(serializers.ModelSerializer):
    class Meta:
        model = Employeers
        fields =  "__all__"
