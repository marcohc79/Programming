/* 2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla. */
using System;

namespace ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, higher=0;
            for(int i=1; i < 10; i++){
                Console.WriteLine("Enter number: ");
                num = int.Parse(Console.ReadLine());
                if (num > higher)
                    higher = num;
            }

            Console.WriteLine("The higher is: " + higher);
        }
    }
}
