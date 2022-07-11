# En este segundo ejercicio, tendréis que crear un archivo py y dentro crearéis una clase Vehículo, haréis un objeto de ella, lo guardaréis en un archivo y luego lo cargamos.

def crear():
    class Vehiculo:
        ventanasV = 5
        puertasV = 6
        def puertas(self):
            return self.puertasV
        def ventanas(self):
            return self.ventanasV
    
    vehiculo = Vehiculo()
    fichero = open('ejercicio02.txt', 'w')
    fichero.write(str(vehiculo))
    fichero.close()

def leer():
    fichero = open('ejercicio02.txt','r')
    datos = fichero.readlines()
    print(datos)

def main():
    crear()
    leer()

if __name__ == '__main__':
    main()
