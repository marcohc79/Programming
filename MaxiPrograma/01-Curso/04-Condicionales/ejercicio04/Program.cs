using System;

namespace ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
/* 4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero. */
            int num01, num02, num03;

            Console.WriteLine("Enter number 01: ");
            num01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 02: ");
            num02 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 03: ");
            num03 = int.Parse(Console.ReadLine());

            if ((num01+num02) > (num02 * num03))
                Console.WriteLine("Alert!!!");
        }
    }
}
