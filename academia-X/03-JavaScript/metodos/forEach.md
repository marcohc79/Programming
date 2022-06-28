# forEach()

De esta forma itero por cada valor del objeto sin necesidad de utilizar el indice. Dentro de forEach va un callback que en este caso va ser una funcio anonima el cual puede tener varios parametros.
<br>
En este ejemplo:
~~~
students.forEach(function (student, index, students) {
  console.log(student);
  console.log(index);
  console.log(students)
})
~~~~~~
* **student** $\to$ es el valor.
* **index** $\to$ es el indice o key.
* **students** $\to$ estaria obteniendo nuevamente cada objeto en cada ronda.

<br>

Tambien se puede utilizr una funcion flecha:
~~~
students.forEach((student, index) => {
  console.log(student)
  console.log(index)
})
~~~
