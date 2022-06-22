"""
script en Python que muestre los nombres de todos los archivos contenidos en una carpeta
y que tengan una extension determinada.
"""

import pathlib

ruta = pathlib.Path('//home/mhcaballero/Pictures/wallpapers/')

for archivos in ruta.glob('*.png'):
    print(archivos)
