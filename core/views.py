from rest_framework import viewsets
from .models import Guest, Room, Booking
from .serializers import GuestSerializer, RoomSerializer, BookingSerializer
from django.shortcuts import render
from .models import Guest

def guest_list(request):
    guests = Guest.objects.all()
    return render(request, 'guest_list.html', {'guests': guests})


class GuestViewSet(viewsets.ModelViewSet):
    queryset = Guest.objects.all()
    serializer_class = GuestSerializer

class RoomViewSet(viewsets.ModelViewSet):
    queryset = Room.objects.all()
    serializer_class = RoomSerializer

class BookingViewSet(viewsets.ModelViewSet):
    queryset = Booking.objects.all()
    serializer_class = BookingSerializer
