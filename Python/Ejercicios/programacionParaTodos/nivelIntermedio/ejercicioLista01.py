import os

AGREGAR = 1
INSERTAR = 2
MOSTRAR = 3
BUSCAR = 4
ELIMINAR = 5 
ORDENAR = 6
LIMPIAR = 7
SALIR = 0

frutas = []

def imprimir_menu():
    os.system('clear')
    print(f'''       Frutas
        {AGREGAR}) Agregar
        {INSERTAR}) Insertar 
        {MOSTRAR}) Mostrar 
        {BUSCAR}) Buscar 
        {ELIMINAR}) Eliminar 
        {ORDENAR}) Ordenar 
        {LIMPIAR}) Limpiar lista
        {SALIR}) Salir''')

def agregar_registro():
    print("                 Agregar")
    nombre = input('Nombre: ')
    frutas.append(nombre)
    print('Registro agregado.')

def insertar_registro():
    print("                 Insertar")
    nombre = input('Nombre: ')
    posicion = int(input('Posicion: '))
    frutas.insert(posicion-1, nombre)
    print('Registro agregado.')

def mostrar_registros():
    print("                 Mostrar")
    if len(frutas):
        for fruta in frutas:
            print(fruta)
    else:
        print('Lista vacia.')

def buscar_registro():
    print("                 Buscar")
    if len(frutas):
        nombre = input('Nombre a buscar: ')
        if nombre in frutas:
            cantidad = frutas.count(nombre)
            inicio = 0
            for indice in range(cantidad):
                posicion = frutas.index(nombre, inicio)
                print(f'{nombre} se encuentra en la posicion {posicion+1}.')
                inicio = posicion+1
        else:
            print(f'{nombre} no esta en la lista.')
    else:
        print('Lista vacia.')

def eliminar_registro():
    print("                 Eliminar")
    if len(frutas):
        for indice in range(len(frutas)):
            print(f'{indice+1}. {frutas[indice]}')
        print('0. Cancelar')
        posicion = int(input(f'Posicion a eliminar (1 - {len(frutas)}): '))
        if 0 < posicion <= len(frutas):
            frutas.pop(posicion-1)
            print('Eliminado con exito')
        else:
            print('No se eliminará ningun registro.')
    else:
        print('Lista vacia.')

def ordenar_registro():
    print("                 Ordenar")
    if len(frutas):
        frutas.sort()
        print('Registros ordenados.')
    else:
        print('Lista vacia.')

def limpiar_registro():
    print("                 Limpiar registro")
    frutas.clear()
    print('Lista limpia.')

def main():
    continuar = True
    while continuar:
        imprimir_menu()
        opcion = int(input('Ingrese una opcion: '))
        os.system('clear')
        if opcion == AGREGAR:
            agregar_registro()
        elif opcion == INSERTAR:
            insertar_registro()
        elif opcion == MOSTRAR:
            mostrar_registros()
        elif opcion == BUSCAR:
            buscar_registro()
        elif opcion == ELIMINAR:
            eliminar_registro()
        elif opcion == ORDENAR:
            ordenar_registro()
        elif opcion == LIMPIAR:
            limpiar_registro()
        elif opcion == SALIR:
            print('Gracias por pasar')
            break
        else:
            print('Ingrese una opcion correcta.')
        input('Precione enter para continuar...')

if __name__ == "__main__":
    main()
