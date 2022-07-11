# Entrada y Salida

## Formateo de una cadena

Hasta el 3.6
~~~
numero = 511
texto = 'hola'
otromas = 1.2

print('El numero es {num} y el texto es {txt} y tiene {flt}'.format(num=numero, txt=texto, flt=otromas))
~~~

Desde el 3.6
~~~
print(f'El numero es {numero} y el texto es {texto} y tiene {otromas}')
~~~

### Representaciones textuales de una clase.

Si quiero convertir un _int_  a _str_ podemos utlizar **str** y **repr**. La diferencia es que _str_ es para generar una salida informal para el usuario final, mientras que _repr_ es para generar salidas de depuración y desarrollo (salida técnica).

En una clase queremos modificar la salida, utilizaremos `__str__`. A esto se lo llama sobrecargar el metodo.
Ejemplo
~~~
class Jugute:
    def __init__(self, nombre, precio):
        self.nombre = nombre
        self.precio = precio

    def __str__(self):
        return f'Mi nombre es {self.nombre} y mi precio {self.precio}'

    def __repr__(self):
        return f'Potato({self.nombre}, {self.precio})'

j1 = Jugute('Potato', 10.5)
print(j1)
>$ Mi nombre es Potato y mi precio 10.5
print(repr(j1))
>$ Potato(Potato, 10.5)
~~~
`.isdigit()` 




### Manipulación de ficheros.

Estructura
`f = open('ruta','permiso')`

Permisos
* r: lectura   -> es solo leer
* a: append    -> escribir pero al final del mismo
* w: escritura -> voy a sobrescribir el fichero pisando lo que tenia
* x: create    -> crear el fichero sino existe

* t: texto     -> texto
* b: binary    -> binario
* +: plus      -> le sa un plus


Leer un fichero
~~~
f = open('/etc/passwd', 'r')
datos = f.read()
datos = f.readln() #lee por linea
f.close()
~~~
Forma de recorrer un archivo.
~~~
while datos != '':
    datos = f.readln()
    print(datos)
~~~
**Leer el fichero.**
~~~
def main():
    usuarios = listarUsuarios()
    for usuario in usuarios:
        print(f'Usuario: {usuario}')

def listarUsuario():
    f = open('/etc/passwd', 'r')
    datos = f.readlnes()
    f.close()
    resultados = [] 
    for linea in datos:
        if linea[0] == '#' or linea[0] == '_':
            continue
        partes = linea.split(':')
        resultados.append(partes[0])
    return resultados


if __name__ == '__main__':
    main()
~~~


**Escribir ficheros**

~~~
f = open('mifichero.txt', 'w')
f.write('datos\n')
f.close()
~~~
 ~~
f = open('mifichero.txt', 'w')
lista = ['linea\n','linea02\n','linea03\n']
f.writelines('datos\n')
f.close()
 ~~

~~~
def escribe(fichero, datos):
    f = open(fichero, 'w')
    for linea in datos:
        if not linea.endswith('\n'):
            linea = linea + '\n'
        f.write(linea)
    
lista = ['linea\n','linea02\n','linea03\n']
escribe('mifichero.txt',lista)
~~~






