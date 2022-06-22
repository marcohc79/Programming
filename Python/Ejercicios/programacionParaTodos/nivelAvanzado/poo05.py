"""
script en Python que utilice el menu de una clase Receta dentro de la cual habrá una lista de ingredientes. Cada Ingrediente tendrá como atributos los siguientes:
    - nombre
    - cantidad
    - unidad de medida
La clase Receta además de contener un menú y una lista de ingredientes deberá tener un nombre y una lista de pasos o instrucciones así como los siguientes comportamientos:
    - Agregar ingredientes
    - Consultar ingredientes
    - Agregar Paso
    - Consultar Pasos
"""

from recipe import Recipe

def main():
    recipe = Recipe('Pizza')
    
    recipe.menu()

    print(recipe)


if __name__ == '__main__':
    main()
