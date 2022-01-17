from stocks.models import LearningGameTypes
from stocks.models import LearningGame
from rest_framework import serializers


class LearningGameTypesSerializer(serializers.ModelSerializer):
    class Meta:
        # ������, ������� �� �����������
        model = LearningGameTypes
        # ����, ������� �� �����������
        fields = ["pk", "NameGameTypes", "GameTypesDescription"]
class LearningGameSerializer(serializers.ModelSerializer):
    class Meta:
        # ������, ������� �� �����������
        model = LearningGame
        # ����, ������� �� �����������
        fields = ["pk", "GameName", "GameDescription","GameTypeId"]