# map

Nos permite recorrer elementos pero a diferencia de _forEach_ este si nos **retorna** un arreglo nuevo. En este cado **student** es el valor de cada iteración.
Por otro lado el arreglo/objeto original no fue modificado.
~~~
let fullname = students.map(funcion (student) {
  return student.name + ' ' + student.lastname
});
~~~
Tambien se puede utilizar la función flecha:
~~~
let fullname = students.map(student => student.name + " " + student.lastname)
~~~
Tambien puedo retornar distintas propiedad o distincas cosas como por ejemplo:
~~~
const fullNames = students.map(student => {
  return {
    fullname: student.name + ' ' + student.lastname,
    age: student.age,
    course: student.course
  }
})
~~~
Ahora si quiero copiar toda la informacion del objeto original y/o añadir o modificar lo hacemos con `...student` de la siguiente forma:
~~~
const fullNamesV3 = students.map(student => {
  return {
    ...student,
    title: `${student.name} - ${student.course}`
  }
})
~~~
Lo anterior tambien lo podemos resumir o mejor dicho formetar de la siguiente forma:
~~~
const fullNamesV3 = students.map(student =>( {
    ...student,
    title: `${student.name} - ${student.course}`
}))
~~~
Si tenemos estos bloques de codigo:
~~~
let newCourses = students.map(student => ({
  ...student,
  course: 'Programming'
}))

let double = newCourses.map(student => ({
  ...student,
  age: student.age * 2
}))
~~~
<br>

Como se puede ver, estoy declarando 2 variables para hacer dos modificaciones. Esto se puede mejorar de la siguiente forma y asi no tener que crear 2 variables:
~~~
let newCoursesV2 = student.map(student => ({...student, course: 'Programming'})).map(student => ({
  ...student, age: student.age * 2
}))
~~~
