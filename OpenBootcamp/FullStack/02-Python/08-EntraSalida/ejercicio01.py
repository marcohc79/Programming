# En este ejercicio, tendréis que crear un archivo py donde creéis un archivo txt, lo abráis y escribáis dentro del archivo. Para ello, tendréis que acceder dos veces al archivo creado.



# Creo el archivo
def escribir():
    fichero = open('ejercicio01.txt', 'w')
    while True:
        linea = input("Escribe: ")
        fichero.write(linea+'\n')

        salida = input('Continue...(s/n): ')
        if salida == 'n':
            break
    fichero.close()

def leer():
    fichero = open('ejercicio01.txt','r')
    datos = fichero.readlines()
    fichero.close()
    for linea in datos:
        print(linea,end='')

def main():
    escribir()
    leer()

if __name__ == '__main__':
    main()
