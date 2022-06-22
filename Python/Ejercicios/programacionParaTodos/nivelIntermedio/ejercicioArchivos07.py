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
import pathlib

AGREGAR = 1
MOSTRAR = 2 
BUSCAR = 3 
SALIR = 0

def mostrarMenu():
    os.system('clear')
    print(f'''              Mi Agenda
{AGREGAR}) Agregar contacto
{MOSTRAR}) Mostrar contactos
{BUSCAR}) Buscar contacto
{SALIR}) Salir''')

def cargarAgenda(agenda, nombreArchivo):
    if pathlib.Path(nombreArchivo).exists():
        with open(nombreArchivo, 'r') as archivo:
            for linea in archivo:
                contacto, telefono, correo = linea.strip().split(',')
                agenda.setdefault(contacto, (telefono, correo))
    else:
        with open(nombreArchivo, 'w') as archivo:
            pass

def agregarContacto(agenda, nombreArchivo):
    os.system('clear')
    print('             Agregar Contacto')
    nombre = input('Nombre: ')
    if agenda.get(nombre):
        print('El contacto ya existe.')
    else:
        telefono = input('Telefono: ')
        correo = input('Correo: ')
        agenda.setdefault(nombre, (telefono, correo))
        with open(nombreArchivo, 'a') as archivo:
            archivo.write(f'{nombre},{telefono},{correo}\n')
        print('Contacto agregado con exito.')

def mostrarContactos(agenda):
    os.system('clear')
    print('                 Mis Contactos')
    if len(agenda):
        for contacto, datos in agenda.items():
            print(f'Nombre: {contacto}')
            print(f'Telefono: {datos[0]}')
            print(f'Correo: {datos[1]}')
            print('*'*50)
    else:
        print('No hay contactos.')

def buscarContacto(agenda):
    os.system('clear')
    print('                 Buscar Contacto')
    if len(agenda):
        nombre = input('Nombre: ')
        coincidencias = 0
        for contacto, datos in agenda.items():
            if nombre in contacto:
                print(f'Nombre: {contacto}')
                print(f'Telefono: {datos[0]}')
                print(f'Correo: {datos[1]}')
                print('*'*50)
                coincidencias += 1
        if coincidencias:
            print(f'Se encontraron  {coincidencias} contactos.')
        else:
            print('No se encontraron contactos.')
    else:
        print('No hay contactos registrados.')

def main():
    continuar = True
    agenda = dict()
    nombreArchivo = 'agenda.txt'
    cargarAgenda(agenda, nombreArchivo)

    while continuar:
        mostrarMenu()
        opc = int(input('Seleccione una opcion: '))
        if opc == AGREGAR:
            agregarContacto(agenda, nombreArchivo)
        elif opc == MOSTRAR:
            mostrarContactos(agenda)
        elif opc == BUSCAR:
            buscarContacto(agenda)
        elif opc == SALIR:
            continuar = False
        else:
            print('Opcion no valida.')
        input('Enter para continuar...')
    print('Nos vemos...')

if __name__ == '__main__':
    main()
