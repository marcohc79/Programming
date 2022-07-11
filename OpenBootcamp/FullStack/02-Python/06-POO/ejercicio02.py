# En este segundo ejercicio, tendréis que crear un programa que tenga una clase llamada Alumno que tenga como atributos su nombre y su nota. Deberéis de definir los métodos para inicializar sus atributos, imprimirlos y mostrar un mensaje con el resultado de la nota y si ha aprobado o no.

class Alumno:
    def __init__(self, nombre, nota):
        self.nombre = nombre
        self.nota = nota

    def estadoAlumno(self):
        if self.nota >=4:
            print(f'{self.nombre} aprobó.')
        else:
            print(f'{self.nombre} lamentablemente no aprobó.')

alumno = Alumno('Pepe', 2)
alumno.estadoAlumno()
