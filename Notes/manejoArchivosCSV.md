# Archivos CSV.

Al momento de abrir archivos CSV tener encuenta: `with open(nameFile, 'a', newline=''):`, siempre hay que agregar `newline=''` como tercer argumento.

### Leer un archivo.
Hay dos formas de leer:
1. `linea = archivo.readline()` --> Lee una línea de texto del archivo. Si la cadena devuelta es vacía, es que se ha llegado al final del archivo.
2. `for linea in archivo:` --> Itera sobre las lineas del archivo.

`lineas = archivo.readlines()` --> Devuelve una lista con todas las líneas del archivo.

### Escribir en un archivo.
Hay dos formas leer
1. `archivo.write(cadena)` 
2. `archivo.writelines(lista_de_cadenas)`
