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

<br>

## Constructores y destructores.
`new` convoca el constructor de la calase.
Para ello vamos a crear una función con el mismo nombre que la clase.
~~~
public Botella(string color, string material)
{
    this.color = color;
    this.material = material;
}
~~~

Y al momento de crear vamos a tener que brindar dichos valores.
`Botella b1 = new Botella("Rojo", "Plástico");`

Esta forma siempre que cree el objeto tengo que brindar esos datos. Ahora si en caso que yo quiera tener la posiblidad tambien de crearlo vacio realizaremos una **sobrecarga el constructor**.
~~~
public Botella(){}
~~~
Esto se agrega a lo anterios.

## Metodos.

No es mas que una función.
Va exclusivamente dentro de una clase que va hacer una acción dentro de la cual esta trabajando.

<br>
<br>

## Sobrecargas metodos.

Copiar un metodo y modificarlo. De esta forma no estoy perdiendo un metodo sino que creo otro con dichas funcionalidades.
Ej:
~~~
public string saludar()
{
    return "Hola soy...." + nombre;
}

//Sobrecargo
public string saludar(string personaje)
{
    return "Hola " + personaje + ", " + "soy " + this.nombre;
}
~~~