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



## Herencia

A muy groso modo es que una clase herede los metodos y propiedades de otro. Tambien tener encuenta la jerarquia la cual es abajo hacia arriba.

Tipos Valor: Variables en espacio en momoria (int, string, char)
Tipos Referencial: Son los objetos, la caracteristica es cuando ejecuto `new` aca se genera la referencia de variable en el objeto.

## Colecciones
Es una evolucion de los vectores. Una de las características importantes es que su tamaño es dinámico.
Al momento de crearlos:
~~~
using System.Collections.Generic;

//<> nos definen un tipo generico, vamos a decir que tipos de objetos vamos manejar.
List<Camioneta> listaCamionetas = new Lista<Camioneta>();
~~~

## Sobre escritura

Tomar un metodo que ya existe y redefinirlo pero no lo tengo en la clase actual. Es un metodo heredado.

En el metodo que quiero sobre escribir tengo que colocar **override** de la siguiente forma:
~~~
public override string ToString()
{
    return "Modifco: ";
}
~~~

El anterio lo puedo modificar sin hacer nada ya que es un metodo default, ahora si quiero hacerlo en alguno que fue generado por nosotros.
`public virutal string comunicarse(){}` Como Se ve `virtual` 

## Modelo de donimio
Se utiliza: Notacion UML.
 

 ## Tipos de clases
  
  Abstracta: Por lo tanto no se puede crear una instancia. Pero si las clases hijas.
  Sealed: Es contraria a abastrac, no permite heredar. Puede servir para marcar el final de una jerarquia.
  Static: Si la clase es estatica el metodo tambien lo tiene que ser. Se puede utilizar directamente sin necesidad de instanciarla.
