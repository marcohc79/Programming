# Sort 

Si quiero ordenar un objeto por alguna propiedad utilizaremos la propiedad `sort`.
Tomemos como ejemplo que quiero ordenar de menor a mayor con respecto a las edades, nuestro codigo será así:
~~~
let sortedStudents = students.sort(function (first, second) {
  if (first.age > second.age) {
    return 1
  }
  return -1
})
~~~
Tengamos encuenta que **first** y **second**  hacen referencia al **primero** y **segundo** (respectivamente) de nuestro objeto. En nuestro ejemplo si es verdad retorna _1_ y en caso contrario _-1_, tomandolo como verdadero y falso respectivamente.
<br>
Otra forma de escribir el codigo sería:
~~~
let sortedStudentsV2 = students.sort((first, second) => first.age > second.age ? 1 : -1)
~~~
Ó
~~~
let sortedStudentsV3 = students.sort((first, second) => first.age - second.age)
~~~

