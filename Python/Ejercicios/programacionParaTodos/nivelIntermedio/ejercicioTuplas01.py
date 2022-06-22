"""
script en Python que permita almacenar registros de las mascotas del usuario. Para cada mascota se 
solicitará el nombre, edad, el peso y el tipo de mascosa; dichos valores serán guardados en una tupla. 
Para permitir la posibilidad de tener varias mascotas se creará una lista en la cual se guarden los 
registros de cada mascota, es decir una lista de tuplas. 
El programa deberá contar con un menú cíclico que permita registrar y consultar las mascotas.
"""
import os 
REGISTRAR = 1
CONSULTAR = 2
SALIR = 0

def ingresarMascota(mascotas):
    os.system('clear')
    print(f"""              Datos de tu mascota""""")
    nombre = input("Nombre: ")
    edad = input('Edad: ')
    peso = input('Peso (kg): ')
    tipo = input('Tipo: ')
    mascotas.append((nombre, edad, peso, tipo))

def consultarMascota(mascotas):
    os.system('clear') 
    print('''            Consulta de mascotas''')
    if not len(mascotas):
       print('Aun no hay mascotas registradas.')
    else:
        for mascota in mascotas:
           nombre, edad, peso, tipo = mascota 
           print(f'Nombre: {nombre}')
           print(f'Edad: {edad}')
           print(f'Peso: {peso}')
           print(f'Tipo: {tipo}')
           print(' ^.^  ´O.O` ')

def menu():
    os.system('clear')
    print(f"""               Mis mascotas
    {REGISTRAR}) Registrar
    {CONSULTAR}) Consultar
    {SALIR}) Salir""")

def main():
    misMascotas = []
    continuar = True
    while continuar:
        menu()
        opc = int(input('Seleccione una opción: '))
        if opc == REGISTRAR:
            ingresarMascota(misMascotas)
        elif opc == CONSULTAR:
            consultarMascota(misMascotas)
        elif opc == SALIR:
            continuar = False
        else:
            print('Opcion no valida')
        input('Enter para continuar....')
    input('Nos vemos')

if __name__ == "__main__":
    main()
