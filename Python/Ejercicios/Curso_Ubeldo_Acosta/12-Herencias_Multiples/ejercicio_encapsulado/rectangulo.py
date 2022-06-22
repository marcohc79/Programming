from figura_geometrica import FiguraGeometrica
from color import Color

class Rectangulo(FiguraGeometrica, Color):
    def __init__(self, alto, ancho, color):
        FiguraGeometrica.__init__(self, alto, ancho)
        Color.__init__(self, color)

    def area(self):
        return self.get_alto()*self.get_ancho()

    def __str__(self):
        return FiguraGeometrica.__str__(self)+'\nArea: '+str(self.area())+'\nColor: '+self.get_color()
