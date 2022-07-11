# Escribe un programa capaz de mostrar todos los números impares desde un número de inicio y otro final.
# Por ejemplo: teniendo numero_inicial = 2 y numero_final = 8, el programa debe imprimir por consola: [3, 5, 7]

def odd(start, end):
    for i in range(start, end+1):
        if not not(i%2):
            print(i)
odd(2,8)

