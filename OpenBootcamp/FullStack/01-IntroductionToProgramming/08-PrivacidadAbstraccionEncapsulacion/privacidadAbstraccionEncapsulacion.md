# Privacidad, abstracción y encapsulación.

~~~
public class Main{
  public static void main(String[] args) {
    Vehiculo vehiculo = new Vehiculo();
    vehiculo.tipo = "Coche";

    String tipo = vehiculo.getTipo();
    System.out.println(tipo);
  }
}

class Vehiculo{
  > String tipo;
  private String tipo;

  public void setTipo(String valor){
    this.tipo = valor;
  }

  public String getTipo(){
    return this.tipo;
  }
}
~~~

Si tengo algo así
CLASE MICLASE
  PRIVADA PROPIEDAD1;
  PRIVADA PROPIEDAD2;

  FUNCION SETTERPROPIEDAD(TEXTO valor)
    ESTA_CLASE.PROPIEDAD1 = valor

  FUNCION GETTERPROPIEDAD1()TEXTO
    DEVUELVE EL VALOR DE ESTA_CLASE.PROPIEDAD1

- PROGRAMA PRINCIPAL -
  VAR unaclase INSTACIA DE MICLASE

  unaclase.PROPIEDAD1 = valor
  IMPRIME unaclase.PROPIEDAD2


> Una clase abstracta, tiene como calificador. Quiere decir que el lenguaje puede implemetar el codigo de algunas funciones y puede decir que esa funcion abstracta lo puede implementar una clase hija.
> 
