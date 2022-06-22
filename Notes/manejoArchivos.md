# Manejo de Archivos

**Estructura para abrir un archivo:** <br>
`open(nombreArchivo.extension, modo)`
<br>
<br>
**Modos de apertura de los archivos**:
+ Modo de **sólo lecura** ('**r**'). En este caso no es posible realizar modificaciones sobre el archivo, solamente su contenido.
+ Modo de **sólo escritura** ('**w**'). En este caso el archivo es truncado (vaciado) si existe, y se lo crea sino existe.
+ Modo **sólo escritura posicionándose al final del archivo** ('**a**'). En este caso se crea el archivo, si no existe, pero en caso de que exista se posiona al final, manteniendo el contenido original.

~~~
r --> solo lectura
w --> escritura
a --> agregar
r+ --> lectura y escritura
b --> binario
~~~

Ejemplo de escritura: <br>
~~~
archivo = open('miArchivo.txt', 'w')
arcivo.write('Hola Mundo')
arcivo.close()
~~~

Ejemplo de lectura: <br>
~~~
archivo = open('miArchivo.txt', 'r')
arcivo.read()
arcivo.close()
~~~

Ejemplo de lectura y escritura: <br>
~~~
archivo = open('miArchivo.txt', 'r+')
arcivo.write()
arcivo.close()
~~~

Ejemplo de open: <br>
~~~
archivo = open('miArchivo.txt', 'a')
arcivo.write('Otra cadena')
arcivo.close()
~~~

Para evitar estar colocando `archivo.close()` todo el tiempo, utilizamos:
~~~
with open('miArchivo.txt','w') as nombreArchivo
    for i in range(11):
        nombreArchivo.write(f'{i}\n')
~~~
