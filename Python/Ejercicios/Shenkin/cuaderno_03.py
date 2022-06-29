# Definir una función max() que tome como argumento dos numeros y devuelva el mayor de ellos
def max(num01, num02):
    if num01>num02:
        return num01
    return num02

# Definir una función max_de_tres(), que tome tres números como argumentos y devuelva el mayor de ellos
def max_de_tres(num01, num02, num03):
    aux = max(num01, num02)
    if aux > num03:
        return aux
    return num03

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
