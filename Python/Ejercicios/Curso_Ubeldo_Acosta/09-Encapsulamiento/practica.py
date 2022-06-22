class Persona:
    def __init__(self, nombre, apellido_paterno, apellido_materno):
        self.nombre = nombre
        self._apellido_paterno = apellido_paterno
        self.__apellido_materno = apellido_materno

    def __metodo_privado(self):
        print(self.nombre)
        print(self._apellido_paterno)
        print(self.__apellido_materno)

    def metodo_publico(self):
        self.__metodo_privado()

    def get_apellido_materno(self):
        return self.__apellido_materno
    def set_apellido_materno(self, apellido_materno):
        self.__apellido_materno = apellido_materno



p1 = Persona('Marco', 'Huamani', 'Caballero')
p1.metodo_publico()

print(p1.nombre)
print(p1._apellido_paterno)
# print(p1.__apellido_materno) No se puede acceder

print(p1.get_apellido_materno())

p1.set_apellido_materno('Antonio')
print(p1.get_apellido_materno())
