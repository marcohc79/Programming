"""
script en Python que permita al usuario registrar eventos en su agenda; cada evento se agregará en 
una cola de prioridad de forma tal que aquellos con mayor prioridad salgan  primero de la estructura. 
Para manejar la agenda se le mostrará al usuario un menú con las opciones de agregar evento y 
atender evento.
"""

import os 
import queue

AGENDAR = 1
ATENDER = 2 
SALIR = 0

def mostrarMenu():
    os.system('clear')
    print(f'''                Mi agenda
            {AGENDAR}) Agendar evento
            {ATENDER}) Atender evento
            {SALIR}) Salir''')

def agendarEvento(agenda):
    print('                 Agendar evento')
    tarea = input('Ingrese la tarea a agendar: ')
    agenda.put(tarea)

def atenderEvento(agenda):
    print('                 Atender evento')
    if agenda.empty():
        print('No hay eventos por atender.')
    else:
        evento = agenda.get()
        print(f'Evento: {evento}')

def main():
    agenda = queue.PriorityQueue()
    continuar = True
    while continuar:
        mostrarMenu()
        opcion = int(input('Selecciona una opción: '))
        os.system('clear')
        if opcion == AGENDAR:
            agendarEvento(agenda)
        elif opcion == ATENDER:
            atenderEvento(agenda)
        elif opcion == SALIR:
            continuar = False
        else:
            print('Opcion no valida....')
        input('Precione enter para continuar...')
    print('Nos vemos...')

if __name__ == "__main__":
    main()
