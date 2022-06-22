"""
script en Python que implemente una agenda de contactos haciendo uso de un diccionario. Para el diccionario 
las llaves serán los nombres de los contactos y como valor estará una tupla que contenga el número telefónico
y el correo electrónico. Se tendrá un menú con las siguientes opciones:

    1) Agregar contacto
    2) Mostrar contactos 
    3) Buscar contactos
    4) Modificar contactos
    5) Eliminar contactos
    0) Salir
"""

import os

AGREGAR = 1
MOSTRAR = 2 
BUSCAR = 3 
MODIFICAR = 4
ELIMINAR = 5 
SALIR = 0

def mostrarMenu():
    os.system('clear')
    print(f'''              Mi Agenda
{AGREGAR}) Agregar contacto
{MOSTRAR}) Mostrar contactos
{BUSCAR}) Buscar contacto
{MODIFICAR}) Modificar contacto
{ELIMINAR}) Eliminar contacto
{SALIR}) Salir''')

def agregarContacto(agenda):
    nombre = input('Apellido: ')
    telefono = input('Número Teléfono/Celular: ')
    correo = input('Email: ')
    agenda[nombre] = (telefono, correo)

def mostrarTodosContactos(agenda):
    os.system('clear')
    print(f'''              Mostrar Agenda''')
    for k, v in agenda.items():
        telefono, correo = v
        print(f'Apellido: {k}')
        print(f'Telefono: {telefono}')
        print(f'Correo: {correo}')
        print('')

def buscarContacto(agenda):
    os.system('clear')
    print(f'            Buscar contacto')
    if not len(agenda):
        print('La agenda está vacia.')
    else:
        apellido = input('Apellido a buscar: ')
        if apellido in agenda:
            telefono, correo = agenda.get(apellido)
            print(f'Apellido: {apellido}')
            print(f'Telefono: {telefono}')
            print(f'Correo: {correo}')
        else:
            print('No existe el apellido.')

def modificarContacto(agenda):
    os.system('clear')
    print('             Modificar contacto')
    apellido = input('Ingrese el apellido a modificar: ')
    if apellido in agenda:
        telefono = input('Telefono: ')
        correo = input('Correo: ')
        agenda[apellido]= (telefono, correo)
        print('Listo, se modifico')
    else:
        print('El contacto no existe.')

def eliminarContacto(agenda):
    os.system('clear')
    print('             Eliminar contacto')
    apellido = input('Contacto a eliminar: ')
    if apellido in agenda:
        agenda.pop(apellido)
    else:
        print('Contacto no existe.')
    
def main():
    agenda = {}
    estado = True
    while estado:
        mostrarMenu()
        opc = int(input('Seleccione una opcion: '))
        if opc == AGREGAR:
            agregarContacto(agenda)
            input('Enter...')
        elif opc == MOSTRAR:
            mostrarTodosContactos(agenda)
            input('Enter...')
        elif opc == BUSCAR:
            buscarContacto(agenda)
            input('Enter...')
        elif opc == MODIFICAR:
            modificarContacto(agenda)
            input('Enter...')
        elif opc == ELIMINAR:
            eliminarContacto(agenda)
            input('Enter...')
        elif opc == SALIR:
            estado = False
            print('Gracias por pasar.')
        else:
            print('Opcion equivocado.')

if __name__ == "__main__":
    main()
