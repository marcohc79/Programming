"""
script en Python que implemente una clase Figura que como atributo tenga la cantidad de lados.

Una vez creada la clase crear dos figuras (objetos) y mostrar su cantidad de lados.
"""

class Figure:
    def __init__(self):
        self._sides = None

    @property #getter : Regresa el valor asociado a la cantidad de Sides
    def sides(self):
        return self._sides

    @sides.setter # nombres_atributo.setter : Permite asiganarle valor al atributo Sides
    def sides(self, value):
        if value < 3:
            print('El valor tiene que ser mayor a 3')
            self._sides = None
        else:
            self._sides = value

    @sides.deleter
    def sides(self):
        del self._sides

def main():
    # Creo una instanancia
    triangle = Figure()
    square = Figure()

    triangle.sides = -3
    square.sides = 4
    del square.sides
    
    print(f'The triangle have {triangle.sides} sides.')
    print(f'The squere have {square.sides} sides.')

if __name__ == '__main__':
    main()
