# Find

Nos permite buscar un elemento dentro de un arreglo.
~~~
let result = students.find(function (student) {
  if (student.name === "Ryan") {
    return 1
  }
})
~~~
Esto nos retorna la primera aparición ya que hace una busqueda y no un filtro.
Otra forma de escribirlo sería:
~~~
let resultV2 = students.find(student => student.name === 'Ryan')
~~~
Y en caso que no exista retornará `undefined`.
