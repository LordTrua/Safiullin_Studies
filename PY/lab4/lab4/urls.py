"""lab4 URL Configuration

The `urlpatterns` list routes URLs to views. For more information please see:
    https://docs.djangoproject.com/en/3.2/topics/http/urls/
Examples:
Function views
    1. Add an import:  from my_app import views
    2. Add a URL to urlpatterns:  path('', views.home, name='home')
Class-based views
    1. Add an import:  from other_app.views import Home
    2. Add a URL to urlpatterns:  path('', Home.as_view(), name='home')
Including another URLconf
    1. Import the include() function: from django.urls import include, path
    2. Add a URL to urlpatterns:  path('blog/', include('blog.urls'))
"""
from django.contrib import admin
from django.urls import path
from PY_lab_4 import views
from django.urls import re_path

urlpatterns = [
    path('', views.index),
    #path('detail/<genre>/', views.detail),  # Запрос к странице адрес/detail_1
    #path('detail', views.detail),
]

# r'^$' http://127.0.0.1/ (корень сайта)
# r'^about' http://127.0.0.1/about/
# r'^about/contact' http://127.0.0.1/about/contact
# r'^products/\d+/'  http://127.0.0.1/products/23/ или http://127.0.0.1/products/6459/abc Но не соответствует запросу http://127.0.0.1/products/abc/
# r'^products/\D+/'
# r'^products/phones|tablets/'
# r'^products/\w+'
# r'^products/[-\w]+/'
# r'^products/[A-Z]{2}/'
#
# ^(начало адреса)
# $(конец адреса)
# +(1 и более символов)
# ?(0 или 1 символ)
# {n}(n символов)
# {n, m}(от n до m символов)
# .(любой символ)
# \d+(одна или несколько цифр)
# \D+(одна или несколько НЕ цифр)
# \w+(один или несколько буквенных символов)