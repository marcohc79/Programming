"""
script en Python que muestre los nombres de todos los archivos contenidos en una carpeta.
"""

import pathlib

ruta = pathlib.Path('.')

for archivo in ruta.iterdir():
    print(archivo)

