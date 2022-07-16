using System;

namespace ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
/* 5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente . */ 
            int num01, num02, num03, num04;

            Console.WriteLine("Enter number 01: ");
            num01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 02: ");
            num02 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 03: ");
            num03 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 04: ");
            num04 = int.Parse(Console.ReadLine());

            if (num01 > num02 && num02 > num03 && num03 > num04)
                Console.WriteLine("The numbers are ordered in decreasing order.");

        }
    }
}
