"""
Definicion para la clase Prenda con los atributos tipo, talla.
"""


class Prenda:
    def __init__(self):
        self._tipo = ''
        self._talla = '' 

    @property
    def tipo(self):
        return self._tipo
    @tipo.setter
    def tipo(self, value):
        self._tipo = value
    @tipo.deleter
    def tipo(self):
        del self._tipo

    @property
    def talla(self):
        return self._talla
    @talla.setter
    def talla(self, value):
        self._talla = value
    @talla.deleter
    def talla(self):
        del self._talla

    def __str__(self):
        return f'''Tipo: {self.tipo}
Talla: {self.talla}'''
