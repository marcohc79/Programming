/* 3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo: */
/* CADENA FUENTE: “La mar estaba serena" */
/* CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’ */
/* CADENA RESULTADO: “Li mir estibi sereni" */

using System;

namespace ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena, newCadena;
            char letterA, letterB;

            Console.WriteLine("Enter string: ");
            cadena = Console.ReadLine();

            Console.WriteLine("Letter A: ");
            letterA =  char.Parse(Console.ReadLine());
            Console.WriteLine("Letter B: ");
            letterB =  char.Parse(Console.ReadLine());

            newCadena = "";
            for(int i=0; i < cadena.Length; i++){
                newCadena += cadena[i];
                if(cadena[i] == letterA)
                    newCadena += letterB;
            }
            Console.WriteLine(newCadena);
        }
    }
}
