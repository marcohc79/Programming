# En este ejercicio tendréis que crear un módulo que contenga las operaciones básicas de una calculadora: sumar, restar, multiplicar y dividir.
# Este módulo lo importaréis a un archivo python y llamaréis a las funciones creadas. Los resultados tenéis que mostrarlos por consola.

from calculadora import Calc

def main():
    operacion = Calc(2,0)
    print('Dividir: ', operacion.dividir())
    print('Suma: ', operacion.suma())
    print('Resta: ', operacion.resta())
    print('Multiplicas: ', operacion.multiplicar())


if __name__ == '__main__':
    main()
