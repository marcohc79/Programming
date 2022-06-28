# Some

Si quiero hacer una comprobacion y obtener un `true` o un `false`. 
 En el siguiente ejemplo veremos si alguna persona es mayor que 24.
~~~
let studentsM = students.some(function(student) {
    if (student.age > 24) {
        return true
    }
})
~~~
Otra forma de escrbir sería:
~~~
let result = students.some(student => student.lastname === 'Doe');
~~~

