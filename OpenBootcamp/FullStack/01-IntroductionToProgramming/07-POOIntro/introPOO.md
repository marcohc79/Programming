# Introducción a la Programación Orientada a Objetos.

~~~
public class Main{
  public static void main(String[] args){
    Coche coche = new Coche();

    //metodos
    coche.acelerar();
    coche.decelerar();
  }
}


class Coche{
  int numeroPuertas;
  int velocidadMaxima;
 
  //mismo nombre que el de la clase
  public Coche(){
    //aca inicializo mi clase y es lo primero que va ejecutarse.
    numeroPuertas = 5;
  }

  public void acelerar(){
    velocidadActual += 15;
  }
  public void decelerar(){}
}
~~~

## Constructor.
Es una fomra de inicializar las propiedades de una clase cuando la instanciamos.
