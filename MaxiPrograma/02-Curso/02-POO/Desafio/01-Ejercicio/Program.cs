//Crear un proyecto de consola .Net Framework.
//Crear la clase Telefono (recordemos que una clase va en un archivo nuevo; click derecho en el proyecto, agregar, class).
//Agregale los siguientes atributos:
//    Modelo string.
//    Marca string.
//    NumeroTelefonico string.
//    CodigoOperador int(1, 2 o 3).
//    Agregale las propiedades correspondientes. Podés hacer el formato largo o el corto.
//    Modelo: solo lectura.Es decir, solo get.
//    Marca: solo lectura.
//    NumeroTelefonico: lectura y escritura.
//    CodigoOperador: lectura y escritura.Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.
//    Agregar Constructor que reciba Modelo y Marca.
//    Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.
//    Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
//    Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto
//Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono samsungS22 = new Telefono("Samsung", "S22Plus");
            samsungS22.CodigoOperador = 0;
            samsungS22.NumeroTelefonico = "1122449393";

            Console.WriteLine(samsungS22.Marca);
            Console.WriteLine(samsungS22.Modelo);
            Console.WriteLine("Codigo de operador: "+samsungS22.CodigoOperador);
            Console.WriteLine(samsungS22.NumeroTelefonico);
            Console.WriteLine(samsungS22.Llamar());
            Console.WriteLine(samsungS22.Llamar("Enrique"));
        }
    }
}
