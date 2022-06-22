# Metodos Diccionario

diccionario = {key : value}

+ `diccionario[key] : value` --> Agrega, key / value.
+ `.setdefault(key, value)` --> Agrega informacion, si existe la key retorna value.
+ `.get()` --> Consulta la key y sino existe retorna `none`.
+ `get(key, 'texto por si no existe')`
+ `.pop(key)` --> Regresa valu y elimana la key. Pero sino existe retorna error.
+ `popitem()` --> Elimina key - value.
+ `len(diccionario)` --> Retorna el tamaño.
+ `keys()` --> Retorna todas las keys.
+ `values()` --> Retorna todos los valores.
+ .`items()` --> Retorna una lista de tuplas de keys - values.
+ `for key, value in diccionario.items():`
