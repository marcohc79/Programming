# Reduce

Para entenderlo mejor...
Supongamos que dado un objeto quiero obtener la suma de todas las edades de cada estudiante y almacenarlo en una variable.

El codigo sería:
~~~
let sumaTotal = students.reduce(function (total, student) {
    return total + student.age;
}, 0)
~~~
* total &#8594; hace referencia al acumulador y para poder inicializarla tenemos que declarar el valor despues de cerrar las `{}`.
* student &#8594; es el valor en cada vuelta del recorrido.

El codigo anterior se puede reducir de la siguiente forma:
~~~
let sumaTotalV2 = students.reduce((total, student) => total + student.age, 0)
~~~
Pongamos el ejemplo que ahora tengo un objeto donde tengo como skills el lenguaje de programación que sabe cada estudiante y quiero obtener una lista con todos los lenguajes.

~~~
let skills = developers.reduce(function (allSkills, student) {
    return [...allSkills, student.skills]
}, [])
~~~
Esta forma lo que obtengo es una lista de lista: `[['lenguaje01','lenguaje02'], [lenguaje01,lenguaje02]]`, pero lo que yo quiero es tener una lista con todas las propiedades y no una lista de listas. Para ello haremos lo sigueitne:

~~~
let skills = developers.reduce(function (allSkills, student) {
    return [...allSkills, ...student.skills]
}, [])
~~~
Pero el problema es que apareceran todos los valores sin importar que esten o no repeditos y para solucionar este problema utilizaremo `Set`, que filtra todos los valores repetidos pero esto me devuelve un conjunto de datos de tipo **Set** y si quiero volver a cambiarlos a un arreglo utilizaremos la funcion **Array**, y nuestro codigo quedará de la sigueinte forma:

~~~
let skillsV2 = developers.reduce(function (allSkills, student) {
    return Array.from(new Set([...allSkills, ...student.skills]))
}, [])
~~~
