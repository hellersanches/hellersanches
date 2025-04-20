from django.db import models

class Guest(models.Model):
    name = models.CharField(max_length=100)
    email = models.EmailField()
    phone = models.CharField(max_length=20)

class Room(models.Model):
    number = models.CharField(max_length=10)
    capacity = models.IntegerField()
    available = models.BooleanField(default=True)

class Booking(models.Model):
    guest = models.ForeignKey(Guest, on_delete=models.CASCADE)
    room = models.ForeignKey(Room, on_delete=models.CASCADE)
    check_in = models.DateField()
    check_out = models.DateField()
