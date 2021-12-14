from django.shortcuts import render
from rest_framework import viewsets
from stocks.serializers import LearningGameTypesSerializer
from stocks.models import  LearningGameTypes
from stocks.serializers import LearningGameSerializer
from stocks.models import  LearningGame
# Create your views here.



class LearningGameTypesSet(viewsets.ModelViewSet):
    """
    API endpoint
    """
    # queryset 
    queryset = LearningGameTypes.objects.all().order_by('NameGameTypes')
    serializer_class = LearningGameTypesSerializer 
class LearningGameSet(viewsets.ModelViewSet):
    """
    API endpoint
    """
    # queryset 
    queryset = LearningGame.objects.all().order_by('GameName')
    serializer_class = LearningGameSerializer 
