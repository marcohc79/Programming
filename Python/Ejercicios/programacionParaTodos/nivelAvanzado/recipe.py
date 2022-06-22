"""
recipe.py
Modelo sencillo de una receta de cocina.
atributos:
    ingredientes    --> Lista de ingredientes para la receta
    pasos           --> Lista de pasos o instrucciones para la receta
    nombre          --> Nombre de la receta
comportamientos:
    menu            --> Menú de operaciones
    agregar_ingredientes --> Permite agregar ingredientes a la receta
    consutlar_ingredientes --> Permite consultar los ingredientes
    agregar_paso        --> Permite agregar pasos a la receta
    consultar_pasos     --> Permite consultar los pasos para la receta
"""

import os
from ingredients import Ingredients

class Recipe:
    OPC_ADD_INGREDIENT = 1
    OPC_SEE_INGREDIENT = 2
    OPC_ADD_STEPS = 3
    OPC_SEE_STEPS = 4
    OPC_EXIT = 0

    def __init__(self, name=''):
        self._name = name 
        self._ingredients = []
        self._steps = []
    
    def __str__(self):
        s = f'          {self.name}'
        s += 'Ingredients: '
        for ingredient in self.ingredients:
            s += f'{ingredient}'
        s += 'Steps: '
        for i, step in enumerate(self.steps):
            s += f'{i+1}. {step}'
        return s

    @property
    def name(self):
        return self._name
    @name.setter
    def name(self,value):
        self._name = value
    @name.deleter
    def name(self):
        del self._name

    @property
    def ingredients(self):
        return self._ingredients
    @ingredients.setter
    def ingredients(self,value):
        self._ingredients = value
    @ingredients.deleter
    def ingredients(self):
        del self._ingredients

    @property
    def steps(self):
        return self._steps
    @steps.setter
    def steps(self,value):
        self._steps = value
    @steps.deleter
    def steps(self):
        del self._steps

    def menu(self):
        flag = True
        while flag:
            os.system('clear')
            print(f'''      {self.name}
{self.OPC_ADD_INGREDIENT}) Add Ingredient
{self.OPC_SEE_INGREDIENT}) See Ingredient
{self.OPC_ADD_STEPS}) Add Steps
{self.OPC_SEE_STEPS}) See Steps
{self.OPC_EXIT}) Exit''')
            opc = int(input('Seleccion an opcion: '))
            if opc == self.OPC_ADD_INGREDIENT:
                self.add_ingredients()
            elif opc == self.OPC_SEE_INGREDIENT:
                self.see_ingredients()
            elif opc == self.OPC_ADD_STEPS:
                self.add_steps()
            elif opc == self.OPC_SEE_STEPS:
                self.see_steps()
            elif opc == self.OPC_EXIT:
                flag = False
            else:
                print('Option error....')
            input('Enter to continue...')
        print('See you soon')
    
    def add_ingredients(self):
        next = True
        while next:
            os.system('clear')
            print('                 Add Ingredients')
            name = input('Name: ')
            quantity = -1
            while quantity <=0:
                quantity = input('Amount: ')
                try:
                    quantity = float(quantity)
                except:
                    quantity = 0
            unit = input('Unit: ')
            ingredient = Ingredients(name, quantity, unit)
            self.ingredients.append(ingredient)
            answer = input('Do you want to add other ingredient? (y/n)').lower()
            if answer != 'y':
                next = False

    def see_ingredients(self):
        os.system('clear')
        print('             Ingredientes')
        if len(self.ingredients) == 0:
            print('There aren\'t ingredientes')
        else:
            for ingredient in self.ingredients:
                print(f'{ingredient}')

    def add_steps(self):
        next = True
        while next:
            os.system('clear')
            print('             Add Step')
            step = input('Step: ')
            self.steps.append(step)
            answer = input('Do you want to add other step? (y/n)').lower()
            if answer != 'y':
                next = False

    def see_steps(self):
        os.system('clear')
        print('             Steps')
        if len(self.steps) == 0:
            print('There aren\'t steps.')
        else:
            for i, step in enumerate(self.steps):
                print(f'{i+1}. {step}')
