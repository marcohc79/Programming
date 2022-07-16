using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args){
            int num01, num02, resultado;

            Console.WriteLine("Ingrese un número: ");
            num01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número: ");
            num02 = int.Parse(Console.ReadLine());

            resultado = num01 + num02;

            Console.WriteLine("Reseultado: " + resultado);
        }
            
    }
}
