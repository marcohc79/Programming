/* 3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo: */
/* CADENA FUENTE: “La mar estaba serena" */
/* CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’ */
/* CADENA RESULTADO: “Li mir estibi sereni" */
using System;

namespace ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] cadena = new char[100];
            char letter, letterA, letterB;
            int index=0;

            Console.WriteLine("Enter the phrase letter by letter.");
            letter = char.Parse(Console.ReadLine());
            while(letter != '.'){
                cadena[index] = letter;
                letter = char.Parse(Console.ReadLine());
                index++;
            }
            cadena[index] = '\0';

            Console.WriteLine("Enter letter A.");
            letterA = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter letter B.");
            letterB = char.Parse(Console.ReadLine());

            index = 0;
            while(cadena[index] != '\0'){
                if(cadena[index] == letterA)
                    cadena[index] = letterB;
                index++;
            }
            
            Console.WriteLine();
            index = 0;
            while(cadena[index]  != '\0'){
                Console.WriteLine(cadena[index]);
                index++;
            }
        }
    }
}
