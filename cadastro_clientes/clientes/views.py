# Create your views here.
from django.shortcuts import render, redirect
from .forms import ClienteForm
from .models import Cliente

def cadastrar_cliente(request):
    if request.method == 'POST':
        form = ClienteForm(request.POST)
        if form.is_valid():
            form.save()
            return render(request, 'clientes/sucesso.html')
    else:
        form = ClienteForm()
    return render(request, 'clientes/cadastro.html', {'form': form})

def listar_clientes(request):
    clientes = Cliente.objects.all()
    return render(request, 'clientes/listar_clientes.html', {'clientes': clientes})