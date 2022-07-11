# Modulos

Cuando quiera importar carpetas, esto es dentro de la carpeta raiz tenemos otra con varios modulos. Ahora para importar todo esa carpeta es necesario tener un archivo `__init__.py`
En nuestro archivo main si queremos importar `from nameFile import *` se deberá ir al archivo `__init__.py` y dentro se tendrá que colocar los modulos a importar `__all__ = ['file', 'file02','file03']`

Si quiero imprimir las fanciones que tiene un modulo:
~~~
import  pprint
pprint.pprint(dir(mifuncion))
~~~

