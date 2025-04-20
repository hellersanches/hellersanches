from django.shortcuts import redirect
from django.contrib import admin
from django.urls import path, include

urlpatterns = [
    path('', lambda request: redirect('/api/')),
    path('admin/', admin.site.urls),
    path('api/', include('core.urls')),
]


