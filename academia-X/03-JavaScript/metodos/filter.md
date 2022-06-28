# Filter

Cuando tenemos un arreglo u objeto en algun momento vamos a  querer seleccionar algunos elementos que cumplan alguna condición y es para esto que utilizamos **filter**. Tambien recordar que al igual que _map_, **filter** retorna una nuevo arreglo.

Ejemplo:
~~~
let result = students.filter(function (student) {
  if (student.course === 'Web Development') {
    return true
  };
});
~~~
Todoa esa linea se puede modificar de la siguiente forma:
~~~
let resultV2 = students.filter(student => student.age > 20);

