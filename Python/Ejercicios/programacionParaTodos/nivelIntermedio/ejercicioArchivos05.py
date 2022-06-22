"""
script en Python que genere un diccionario con las llaves siendo las extensiones únicas de los archivos encontrados en una carpeta y los valores
una lista los nombres de cada uno de dichos archivos.
"""

import pathlib

def main():
    ruta = pathlib.Path('//home/mhcaballero/Pictures/wallpapers')
    # flitrar archiovo si tiene alguna extesion, dentro tenemos que poner el filtro.
    diccionario ={k : [v.name for v in ruta.glob(f'*{k}')] for k in {archivo.suffix for archivo in ruta.iterdir()}}

    for extension, archivos in diccionario.items():
        print(f'extension: {extension}')
        print(f'archivos: {archivos}')
    
    print(diccionario)
if __name__ == '__main__':
    main()

