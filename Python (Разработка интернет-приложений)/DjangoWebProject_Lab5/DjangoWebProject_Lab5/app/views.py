"""
Definition of views.
"""

from datetime import datetime
from django.shortcuts import render
from django.http import HttpRequest
from .models import LearningGameTypes
from .models import LearningGame


def home(request):
    """Renders the home page."""
    assert isinstance(request, HttpRequest)
    Game = LearningGame.objects.all()

    return render(
        request,
        'app/LearningPage.html',
        {
            'Name':'All Games',
            'Game':Game
            }
    )

def rpg(request):
    """Renders the home page."""
    assert isinstance(request, HttpRequest)
    Game = LearningGame.objects.filter(GameTypeId_id=1)

    return render(
        request,
        'app/LearningPage.html',
        {
            'Name':'RPG',
            'Game':Game
            }
    )

def strategy(request):
    """Renders the home page."""
    assert isinstance(request, HttpRequest)
    Game = LearningGame.objects.filter(GameTypeId_id=4)

    return render(
        request,
        'app/LearningPage.html',
        {
            'Name':'Strategy',
            'Game':Game
            }
    )

def ection(request):
    """Renders the home page."""
    assert isinstance(request, HttpRequest)
    Game = LearningGame.objects.filter(GameTypeId_id=3)

    return render(
        request,
        'app/LearningPage.html',
        {
            'Name':'Action',
            'Game':Game
            }
    )

def mmo(request):
    """Renders the home page."""
    assert isinstance(request, HttpRequest)
    Game = LearningGame.objects.filter(GameTypeId_id=2)

    return render(
        request,
        'app/LearningPage.html',
        {
            'Name':'MMO',
            'Game':Game
            }
    )