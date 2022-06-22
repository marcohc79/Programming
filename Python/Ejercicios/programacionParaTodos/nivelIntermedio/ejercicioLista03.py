"""
Script en Python que implemente el clásico juego de "ahorcado".
El juego consiste en que le usuario intente adivinar una palabra secreta de la cual inicialmente
sólo se le muestra la cantidad de letras que contiene. Para esta versión del juego, el usuario 
deberá intentar adivinar el nombre de alguno de los 35 países conforman el continente americano.

El juego debe comenzar seleccionado de forma aleatoria el nombre de alguno de los países; dichos nombres 
deberán estar almacenados en una lista. Una vez seleccionado el país, se le mostrará al usuario una
cadena formada por tantos guiones bajos como letras y espacios en blanco haya en el nombre del país.

A partir de ahí el usuarios debe intentar adivinar las letras que conforman el nombre teniendo hasta
5 oportunidades para fallar. Si el usuario pronone una letra y existe en el nombre del país, entonces 
todas las ocurrencias de esa letra se reempla en la palabra secreta.

El juego termina si se han descubiertos todas las letras del nombre o el usuario se ha equivocado 6 veces.
"""

import random

PAISES = ['ARGENTINA', 'BRASIL', 'PERU', 'BOLIVIA']
MAXINTENTOS = 5
ESPECIAL = '-'

def armarGuionesPalabra():
    pais = random.choice(PAISES) 
    newPalabra = '-'*len(pais)
    return newPalabra, pais

def reemplazarLetra(pais, letra, newPalabra):
    for i in range(len(newPalabra)):
        if newPalabra[i] == ESPECIAL:
            if letra == pais[i]:
                newPalabra = newPalabra[:i] + letra + newPalabra[i+1:]
    return newPalabra

def reemplazarLetraV2(pais, letra, newPalabra):
    cantidad = pais.count(letra)
    inicio = 0
    for i in range(cantidad):
        pos = pais.find(letra, inicio)
        newPalabra = newPalabra[:pos] + letra + newPalabra[pos+1:]
        inicio = pos + 1
    return newPalabra

def buscarPalabra():
    newPalabra, pais = armarGuionesPalabra()
    print(newPalabra)
    intentos = 0
    while intentos < MAXINTENTOS:
        letra = input('Ingrese una letra: ').upper()
        if letra in pais:
            newPalabra = reemplazarLetraV2(pais, letra,newPalabra)
            print()
            print(newPalabra)
            if not ESPECIAL in newPalabra:
                print('Ganaste!!!')
                break
        else:
            intentos+=1

def main():
    buscarPalabra()

if __name__ == "__main__":
    main()
