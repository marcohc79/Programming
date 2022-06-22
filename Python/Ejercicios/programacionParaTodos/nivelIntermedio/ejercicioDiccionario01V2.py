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
    os.system('clear')
    print('                 Agregar contacto')
    contacto = input('Contacto: ')
    if agenda.get(contacto):
        print('Existe ese Contacto')
    else:
        telefono = input('Número Teléfono/Celular: ')
        correo = input('Email: ')
        agenda.setdefault(contacto,(telefono, correo))
        print('Contacto agregado con exito.')

def mostrarTodosContactos(agenda):
    os.system('clear')
    print(f'''              Mostrar Agenda''')
    if not len(agenda):
        print('La agenda esta vacia.')
    else:
        for k, v in agenda.items():
            telefono, correo = v
            print(f'Apellido: {k}')
            print(f'Telefono: {telefono}')
            print(f'Correo: {correo}')
            print('~'*50)

def buscarContacto(agenda):
    os.system('clear')
    print(f'            Buscar contacto')
    contacto = 0
    if not len(agenda):
        print('La agenda está vacia.')
    else:
        nombre = input('Apellido a buscar: ')
        for contacto, datos in agenda.items():
            if nombre in contacto:
                telefono, correo = agenda.get(contacto)
                print(f'Contacto: {contacto}')
                print(f'Telefono: {telefono}')
                print(f'Correo: {correo}')
                print('~'*50)
                contacto += 1
        if not contacto:
            print('No existe el contacto.')

def modificarContacto(agenda):
    os.system('clear')
    print('             Modificar contacto')
    if not len(agenda):
        print('No hay contactos registrados.')
    else:
        contacto = input('Ingrese el contacto a modificar: ')
        if agenda.get(contacto):
            datos = agenda.get(contacto)
            print(f'Informacion actual: ')
            print(f'Nombre: {contacto}')
            print(f'Telefono: {datos[0]}')
            print(f'Correo: {datos[1]}')
            print('*'*50)
            telefono = input('Telefono: ')
            correo = input('Correo: ')
            agenda[apellido]= (telefono, correo)
            print('Listo, se modifico')
        else:
            print('El contacto no existe.')

def eliminarContacto(agenda):
    os.system('clear')
    print('             Eliminar contacto')
    if not len(agenda):
        print('No hay contactos agendados')
    else:
        contacto = input('Contacto a eliminar: ')
        if agenda.get(contacto):
            agenda.pop(apellido)
            print('Contacto eliminado con exito.')
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
