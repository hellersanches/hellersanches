# Create your models here.

from django.db import models


class Cliente(models.Model):
    nome = models.CharField(max_length=100)
    primeiro_sobrenome = models.CharField(max_length=100)
    segundo_sobrenome = models.CharField(max_length=100, blank=True, null=True)
    data_nascimento = models.DateField()

    GENERO_CHOICES = [
        ('M', 'Masculino'),
        ('F', 'Feminino'),
        ('O', 'Outro'),
    ]
    genero = models.CharField(max_length=1, choices=GENERO_CHOICES)

    email = models.EmailField()
    telefone = models.CharField(max_length=20)

    rua1 = models.CharField(max_length=100)
    rua2 = models.CharField(max_length=100, blank=True, null=True)
    rua3 = models.CharField(max_length=100, blank=True, null=True)
    cidade = models.CharField(max_length=100)
    estado = models.CharField(max_length=100)
    pais = models.CharField(max_length=100)

    def __str__(self):
        return f"{self.nome} {self.primeiro_sobrenome}"
