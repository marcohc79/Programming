class Aritmetica:
    def __init__(self, opertando1, opertando2):
        self.opertando1 = opertando1
        self.opertando2 = opertando2

    def sumar(self):
        return self.opertando1 + self.opertando2

    def restar(self):
        return self.opertando1 - self.opertando2

#Creamos un nuevo objeto.
suma = Aritmetica(2,4)
print(suma.sumar())

resta = Aritmetica(4,2)
print(resta.restar())
