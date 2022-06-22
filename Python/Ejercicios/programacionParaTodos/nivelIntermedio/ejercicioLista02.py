"""
script en Python que calcule y muestre la suma de dos matrices cuadradas generadas aleatoriamenteselfself.
Utilizar compresión de listas para generar las matrices de forma aleatoria.
"""
import random

def generador_matrices(dimension):
    # ayuda para pensar una fila
    # fila = [random.randint(0,10) for i in range(dimension)]
    matriz = [[random.randint(0,9) for j in range(dimension)] for i in range(dimension)] 
    return matriz

def imprimir_matriz(matriz, dimension):
    for fila in range(dimension):
        for columna in range(dimension):
            print(matriz[fila][columna], end=' ')
        print('')

def suma_matrices(matriz01, matriz02, dimension):
    matriz = [[0]*dimension for i in range(dimension)] 
    for fila in range (dimension):
        for columna in range(dimension):
            matriz[fila][columna] = matriz01[fila][columna] + matriz02[fila][columna]
    return matriz

def main():
    dimension = 4
    matriz01 = generador_matrices(dimension)
    matriz02 = generador_matrices(dimension)
    matrizSuma = suma_matrices(matriz01, matriz02, dimension)

    imprimir_matriz(matriz01,dimension)
    print(' ')
    imprimir_matriz(matriz02, dimension)
    print(' ')
    imprimir_matriz(matrizSuma, dimension)
if __name__ == "__main__":
    main()
