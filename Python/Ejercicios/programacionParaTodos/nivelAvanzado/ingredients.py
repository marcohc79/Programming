"""
atributos:
    - nombre
    - cantidad
    - unidad de medidad
"""

class Ingredients:
    def __init__(self, name='', cant=None, unit_measurement=''):
        self._name = name
        self._cant = cant
        self._unit_measurement = unit_measurement

    @property
    def name(self):
        return self._name
    @name.setter
    def name(self,value):
        self._name = value
    @name.deleter
    def name(self):
        del self._name

    @property
    def cant(self):
        return self._cant
    @cant.setter
    def cant(self,value):
        self._cant = value
    @cant.deleter
    def cant(self):
        del self._cant

    @property
    def unit_measurement(self):
        return self._unit_measurement
    @unit_measurement.setter
    def unit_measurement(self,value):
        self._unit_measurement = value
    @unit_measurement.deleter
    def unit_measurement(self):
        del self._unit_measurement

    def __str__(self):
        return f'''Name: {self.name}
Cant: {self.cant}{self.unit_measurement}'''
