from django.db import models

# Create your models here.

class LearningGameTypes (models.Model):
       NameGameTypes = models.CharField(max_length=45)
       GameTypesDescription = models.CharField(max_length=450)

       class Meta:
        managed = False
        db_table = 'app_gametypes'

       def __str__(self):
            return f'Type:{self.NameGameTypes}, Type Description: {self.GameTypesDescription}'


class LearningGame (models.Model):
       GameName= models.CharField(max_length=45)
       GameDescription = models.CharField(max_length=450)
       GameTypeId=models.ForeignKey(LearningGameTypes,on_delete=models.PROTECT)
       class Meta:
        managed = False
        db_table = 'app_games'

       def __str__(self):
            return f'Game:{self.GameName}, Game Description:{self.GameDescription}\t  {self.GameTypeId}\n'
    

