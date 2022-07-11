# Escribe una función que calcule el área de un triángulo, recibiendo la altura y la base como parámetros y otra función que calcule el área de un círculo recibiendo el radio del mismo.
import math

def areaTriangulo(altura, base):
    return (base * altura) / 2

def areaCirculo(radio):
    return math.pi * (radio**2)

def main():
    triangulo = areaTriangulo(10, 4)
    ciruclo = areaCirculo(2)

    print('Area Triangulo: ', triangulo)
    print('Area Circulo: ', ciruclo)

if __name__ == '__main__':
    main()
