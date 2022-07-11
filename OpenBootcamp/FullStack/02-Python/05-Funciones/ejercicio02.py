# Escribe una función que pueda decirte si un número (número entero) es primo o no.

def primo(numero):
    for i in range(2,numero):
        if numero%i == 0:
            return False
    return True


print(primo(3))
