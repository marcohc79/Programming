"""
Modelo sencillo de un deportista. Hera de la clase Persona.
Atributos:
    sport -- Deporte que practica la persona.
Comportamiento:
    entrar -- Entra el deporte asignado.
"""

from person import Person

class Athlete(Person):
    def __init__(self, name='', year=None, sport=''):
        super().__init__(name, year)
        self._sport = sport

    @property
    def sport(self):
        return self._sport
    @sport.setter
    def sport(self, value):
        self._sport = value
    @sport.deleter
    def sport(self):
        del self._sport

    def train(self):
        print(f'{self.name} is trainning {self.sport}')

    def __str__(self):
        return f'''{super().__str__()}
Sport: {self.sport}'''
