from django.db import models



class Department(models.Model):
    Name = models.CharField(max_length=45)

    class Meta:
       managed = False
       db_table = 'Department'



class Employeers(models.Model):
    First_Name =models.CharField("First_Name",max_length=45)
    Second_Name =models.CharField("Second_Name",max_length=45)
    Patronimic =models.CharField("Patronimic",max_length=45)
    Position = models.CharField("Position",max_length=45)
    Dep = models.ForeignKey(Department, models.DO_NOTHING)


    class Meta:
        managed = False
        db_table = 'Employeers'


# Create your models here.
