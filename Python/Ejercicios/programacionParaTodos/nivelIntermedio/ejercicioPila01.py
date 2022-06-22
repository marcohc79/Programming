"""
Script en Python que solicite al usuario escribir una expresión aritmética y el programa le indique 
si dicha expresión está balanceada, es decir, si tiene la misma cantidad de parentesis de apertura y
cierre.
"""

def validarExpression(expresion):
    pila = []
    for simbolo in expresion:
        if simbolo == '(':
            pila.append(simbolo)
        elif simbolo == ')':
            if len(pila) > 0:
                pila.pop()
            else:
                return False
    return not len(pila)

def main():
    print('Escribe una expresión aritmética y te indicaré si está balanceada \
            con respecto a pararentesis')
    expresion = input('expresión: ')
    valida = validarExpression(expresion)
    if valida:
        print('La expresión está balanceada.')
    else:
        print('La expresión  no está balanceda.')


if __name__ == "__main__":
    main()
