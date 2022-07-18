# Programacíon Oritentada a Objetos.
Es un paradigma de programación.

Se cread de la siguiente manera: `Class Name{}`. 

Los atribuso de una clase tienen que estar encapsuladas, esto quiere decir que un miembro de una clase no tendría que bajo ningún punto de vista ser accedido desde el exterior.
Y para ello anteponemos `private` antes de la declaración del atributo.

Y para acceder a ellos se crean funciones que en realidad se denominan **metodos** y tienen que ser `public void` para que se pueda acceder desde afuera. 

Ejemplo para modificarlo:
~~~
public void setEdad(int edad)
{
    edad = edad;
}
~~~

Ejemplo para obtener:
~~~
public int getEdad()
{
    return edad;
}
~~~
Y para utilizar dichos metodos:
~~~
Persona persona01 = new Persona();
persona01.setEdad(3);
Console.WriteLine(persona01.getEdad());
~~~

C# te propone hacerlo mediante Propiedades, utilizando el ejemplo anterior:
~~~
public int Capacidad
{
    get { return capacidad;}
    set {capacidad = value;}
}
~~~

Ahora para manipular:
~~~
Botella botella01 = new Botella();
botella01.Capacidad = 200;

//Lo guardo en otra variable
int algo = botella01.Capacidad;
~~~

Otra mas compacta:
~~~~
publit int Capacidad {get; set;}
~~~~

De dicha forma no puedo manipular los metodos, tambien puedo tener solamente `get` o `set`.
