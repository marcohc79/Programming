"""
Atributos:
    promedio -- del 01 al 10
    pardon -- es el codigo del estudiante
Comportamiento:
    estudiar_materia
"""
from person import Person

class Student(Person):
    def __init__(self, name='', year=None, padron=None, average=None):
        super().__init__(name, year)
        self._padron = padron
        self._average = average

        @property
        def padron(self):
            return self._padron
        @padron.setter
        def padron(self, value):
            self._padron = value
        @padron.deleter
        def padron(self):
            del self._padron

        @property
        def average(self):
            return self._average
        @average.setter
        def average(self, value):
            self._average = value
        @average.deleter
        def average(self):
            del self._average
