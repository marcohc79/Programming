"""Consiste en convertir un objeto o una casa en una serie de datos que puede escribir en disco"""
import pickle

class Juguete:
    nombre = ''
    precio = 0.0

    def __init__(self, nombre, precio):
        self.nombre = nombre
        self.precio = precio


    def getNombre(self):
        return self.nombre


# Escritura
j1 = Juguete('Potato', 10.5)
f = open('datos.bin', 'wb')
pickle.dump(j1,f)
f.close()

# Deserializar
f = open('datos.bin', 'rb')
potato = pickle.load(f)
f.close()

