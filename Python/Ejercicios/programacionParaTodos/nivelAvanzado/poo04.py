"""
poo_04.py
script en Python que cree y asigne valor a los atributos de un objeto tipo Ingrediente. Los ingredientes serán modelados dentro de una clase en un módulo separado y tendrán los siguientes atributos:
    - nombre
    - contidad
    - unidad de medida
además la clase Ingrediente podrá recibir como argumentos los valores iniciales para sus atributos a través del método contructor.
"""

from ingredients import Ingredients

def main():
    ingredient = Ingredients('Potato',3, 'Kg')
    print(ingredient)


if __name__ == '__main__':
    main()
