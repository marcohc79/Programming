# Definir una función max() que tome como argumento dos numeros y devuelva el mayor de ellos
def max(num01, num02):
    if num01>num02:
        return num01
    return num02

# Definir una función max_de_tres(), que tome tres números como argumentos y devuelva el mayor de ellos
def maxTres(num01, num02, num03):
    aux = max(num01, num02)
    if aux > num03:
        return aux
    return num03

# Escribir una función que tome un carácter y devuelva True si es una vocal, de lo contrario devuelve False
def esVocal(caracter):
    vocales = ['a','e','i','o','u']
    return caracter in vocales

# Escribir una función sum() y una función multip() que sumen y multipliquen respectivamente todos los números de una lista. Por ejemplo: sum([1,2,3,4]) debería devolver 10 y multip([1,2,3,4]) debería devolver 24.
def sum(lista):
    resultado = 0
    for num in lista:
        resultado += num
    return resultado
def mulpip(lista):
    resultado = 1
    for num in lista:
        resultado *= num
    return resultado

# Escribir los 6 primeros términos de la secuencia de Fibonacci (arranca en 0). Tu output debería ser: 0 1 1 2 3 5
def fibonacci(num):
    if num > 1:
        return fibonacci(num-1)+fibonacci(num-2)
    return num
def main():
    for i in range(6):
        print(fibonacci(i))

# Implementar un programa que muestre la siguiente secuencia:
     # 1, 2, 3, 4, 5, 4, 3, 2, 1, 0
# Utilizar 1 solo while, 1 solo if y 1 solo else
def contadores():
    contador = 1
    contenedor = []
    while contador != -1:
        if len(contenedor) < 4 :
            contenedor.append(contador)
            contador +=1
        else:
            contenedor.append(contador)
            contador -= 1
    print(contenedor)
contadores()

main()
