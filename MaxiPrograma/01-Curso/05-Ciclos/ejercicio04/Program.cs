/* 4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo. */
using System;

namespace ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num; 
            bool cont=true;

            Console.WriteLine("Enter number: ");
            num = int.Parse(Console.ReadLine());

            for(int i=2; i < num; i++){
                if (num%i == 0){
                    cont=false;
                    break;
                }
            }

            if(cont)
                Console.WriteLine("It is prime.");
            else
                Console.WriteLine("It isn't prime.");
                
        }
    }
}
