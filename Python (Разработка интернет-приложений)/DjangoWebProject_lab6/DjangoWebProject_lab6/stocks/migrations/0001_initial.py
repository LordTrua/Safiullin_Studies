# Generated by Django 4.0 on 2021-12-14 22:44

from django.db import migrations, models


class Migration(migrations.Migration):

    initial = True

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='LearningGame',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('GameName', models.CharField(max_length=45)),
                ('GameDescription', models.CharField(max_length=450)),
            ],
            options={
                'db_table': 'app_games',
                'managed': False,
            },
        ),
        migrations.CreateModel(
            name='LearningGameTypes',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('NameGameTypes', models.CharField(max_length=45)),
                ('GameTypesDescription', models.CharField(max_length=450)),
            ],
            options={
                'db_table': 'app_gametypes',
                'managed': False,
            },
        ),
    ]
