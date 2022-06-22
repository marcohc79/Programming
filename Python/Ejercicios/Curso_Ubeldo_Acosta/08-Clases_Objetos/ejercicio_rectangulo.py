class Rectangulo:
    def __init__(self, base, altura):
        self.base = base
        self.altura = altura

    def calcular_area(self):
        return self.base * self.altura


def area_rectangulo():
    base = input("Ingrese la base: ")
    altura = input("Ingrese la base: ")
    rectangulo = Rectangulo(int(base),int(altura))

    print("El area es:", rectangulo.calcular_area())

area_rectangulo()
