from stocks.models import LearningGameTypes
from stocks.models import LearningGame
from rest_framework import serializers


class LearningGameTypesSerializer(serializers.ModelSerializer):
    class Meta:
        # Модель, которую мы сериализуем
        model = LearningGameTypes
        # Поля, которые мы сериализуем
        fields = ["pk", "NameGameTypes", "GameTypesDescription"]
class LearningGameSerializer(serializers.ModelSerializer):
    class Meta:
        # Модель, которую мы сериализуем
        model = LearningGame
        # Поля, которые мы сериализуем
        fields = ["pk", "GameName", "GameDescription","GameTypeId"]