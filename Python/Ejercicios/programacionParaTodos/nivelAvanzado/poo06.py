"""
poo_06.py
script en Python que cree e imprima la información de un objeto de tipo Persona y de otro de tipo Deportista.
La clase Deportista heredará la clase Persona, es decir que será un tipo particular de persona.
"""

import person
import athlete

def main():
   per_01 = person.Person('Hector', 44) 
   athlete_01 = athlete.Athlete('Pepe',33,'Basktball') 
   per_02 = person.Person('Javier', 18)

   print(f'''Datos de la persona:
{per_01} 
{per_02}''')
   print('-'*30)
   print(f'''Datos del deportista
{athlete_01}''')
   athlete_01.train()
   per_01.speak('Hello')
   per_02.speak('Ok')

if __name__ == '__main__':
    main()
