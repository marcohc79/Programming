# Programación Orientada a Objetos.

Un objeto es una representacion de "algo" en el mundo real. Tiene metodos (acciones que realizamos).
Funcion y propiedad son publicos por defecto.
~~~
class Dino:
    encendido = False    
    
    def enciende(self):
        pass

d = Dino()
d.enciende()


clas Estatica:
    numero = 1

    def incrementa():
        Estatica.numero +=1

~~~
Las clases tienen herencia, que pueden ser propiedades y metodos.

~~~
class MiClase(claseBase):
    def __init__(self):
        super().__init__() #instancio el constructor de la claseBase
~~~

Clases abstractas

~~~
from abc import ABC, abstractmethod

class Animal(ABC):
    @abstractmethod
    def sonido(self):
        pass

    def diHola(self):
        print('hola')

class Perro(Animal):
    def sonido(self):
        print('Guau')

p = Perro()
p.sonido
>$ Guau
~~~

Relaciones HAS-A
Contiene -> Composicion dice que una clase esta compuesta de otras clases.

~~~
class Motor:
    tipo = 'Diesel'

class Ventanas:
    cantidad = 5

class Ruedas:
    cantidad = 4

class Carroceria:
    ventanas = Ventanas()
    ruedas = Ruedas()

class Coche:
    motor = Motor()
    carroceria = Carroceria()

c = Coche()
print("Motor es ", c.motor.tipo)
>$ Motor es Diesel
print('Ventanas: ', c.carroceria.ventanas.cantidad)
>$ Ventanas: 5
~~~

