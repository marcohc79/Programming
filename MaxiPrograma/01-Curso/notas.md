# Notas

* Para crear un nuevo proyecto ejecutamos: `dotnet new console -o nameFile` 
* Si queremos ejecutar un programa: `dotnet run`
* Para crear on proyecto con otra version: `dotnet new console -o nameProyec --framework net5.0`
### Tipos de variables
`int float double chart bool`

Mostrar por pantalla:
`Console.WriteLine()`

Capturar por teclado un `int`:
`int.Parse(Console.ReadLine())`

### Tipos de datos

Si quiero asignar el número 1.3 a una fariable _float_, se tiene que hacer `float precio; precio=1.3F;`

### Ciclos

For
`for(int i=0; i < 5 ;i++)`{}

While
`while ()`{}

Do While
~~~
do{

}while();
~~~
### Vectores
Declaración: `int[] numeros = new int[10];`

String: `string nombreVariable;`


### Parametors

El valor que se envia hacia una funcion se denomina argumentos, mientras que cuando se recibe se denomina parametros.

* Por Valor -> Solamente estoy dando el valor. Se genera una copia en memoria. 
* Por Referencia -> Para enviar y recepcion se antepone `res`, en este caso uno tiene acceso al valor original.


