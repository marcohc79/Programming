# Funciones

Si las variables de una funcion no sean fijas:
~~~
# Es en este momento que args se convierte en una lista.
def miFuncion(*args):
    resultado = 0
    for arg in args:
        resultado += arg
miFuncion(1,2,3,4,5,6,7,8,9)
~~~
Otro ejemplo:
~~~
# kwargs es un diccionario.
def suma(**kwargs):
    for key, value in kwargs.items():
        print(key, '=', value)
suma(vivienda='piso', coche='rojo')

>$ vivienda = piso
>$ coche = rojo

def buscar(**kwargs):
    if 'coche' in kwargs and kwargs['coche']=='bonito':
        print('Tu coche es bonito')
~~~

# Funcion lambda

Es una funcion anonima.
~~~
nameVariable = lambda nombre, nombre2: print('Hola', nombre, 'adios ', nombre2)
nameVariable('Pepe', 'Camino')
>$ Hola Pepe adios Camino

sumatoria = lambda x: x+x
print(sumatoria(2))
>$4
~~~
