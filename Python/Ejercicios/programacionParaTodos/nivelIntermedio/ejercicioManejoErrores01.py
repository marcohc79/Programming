"""
script en Python que muestre un menú de seleccion de personaje y solicite al usuario seleccione uno de ellos para ver sus detalles. El script deberá poder tolerar fallos en la entrada por parte del usuario.
"""

import os

WIZARD = 1
WARRIOR = 2
PRIESTESS = 3
LEAVE = 0

def mostrarMenu():
    os.system('clear')
    print(f'''            Character
    {WIZARD}) Wizard
    {WARRIOR}) Warrior
    {PRIESTESS}) Priestess
    {LEAVE}) Leave''')


def main():
   flag = True 
   try:
       with open('savedGame.txt', 'r') as file:
           pass
   except:
       with open('savedGame.txt','w') as file:
           pass

   while flag:
        mostrarMenu()
        opc = input('Choose a character: ')
        try:
            opc = int(opc)
        except ValueError as error:
            opc = -1
            print(f'Error: {error}')
            input('Enter to continue')

        os.system('clear')
        if opc == WIZARD:
            print('             Wizard')
            print('features')
        elif opc == WARRIOR:
            print('             Warrior')
            print('features')
        elif opc == PRIESTESS:
            print('             Priestess')
            print('features')
        elif opc == LEAVE:
            print('Thanks for stopping by.')
            print('Enter...')
            flag = False
        else:
            print('Option error...')
        input('Enter to continue.')

if __name__== '__main__':
    main()

