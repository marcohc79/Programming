"""
script en Python que organice el contenido de la carpeta actual de trabajo.
Se deberá generar una carpeta para cada tipo de arhivo y todos los arhivos del tipo
correspondiente deberán ser movidos a la carpeta según su tipo.
"""

import pathlib

def main():
    ruta = pathlib.Path('//home/mhcaballero/Downloads/prueba')
    diccionario = {k : [v for v in ruta.glob(f'*{k}')] for k in {archivo.suffix for archivo in ruta.iterdir()}}

    for extesion, archivos in diccionario.items():
        carpeta = ruta / extesion[1:]
        carpeta.mkdir()
        for archivo in archivos:
            archivo.replace(carpeta / archivo.name)


if __name__ == '__main__':
    main()
