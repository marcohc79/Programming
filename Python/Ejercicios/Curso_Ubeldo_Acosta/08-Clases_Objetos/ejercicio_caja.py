class Caja:
    def __init__(self, alto, ancho, largo):
        self.alto = alto
        self.ancho = ancho
        self.largo = largo

    def calcular_volumen(self):
        return self.alto * self.ancho * self.largo

def armar_caja():
    alto = int(input("Ingrese el alto: "))
    ancho = int(input("Ingrese el ancho: "))
    largo = int(input("Ingrese el largo: "))

    caja = Caja(alto, ancho, largo)

    print('El volumen de la caja es:', caja.calcular_volumen())

armar_caja()
