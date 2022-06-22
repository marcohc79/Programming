"""
script en Python que muestra todas las extensiones únicas de archivos existentes en una carpeta.
"""

import pathlib

def main():
    ruta = pathlib.Path('//home/mhcaballero/Downloads/')
    # for archivo in ruta.iterdir():
    #     # Accedo a la extesion de un archivo
    #     print(archivo.suffix)

    extesiones = {archivo.suffix for archivo in ruta.iterdir()}
    print(f'extesiones: {extesiones}')

if __name__ == '__main__':
    main()
