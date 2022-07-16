using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01, num02, result;
            double cube;

            Console.WriteLine("Enter number 01: ");
            num01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 02: ");
            num02 = int.Parse(Console.ReadLine());
            result = num01 + num02;
            Console.WriteLine("Result: "+result);

            cube = Math.Pow(num01, 3);
            Console.WriteLine("Cube "+num01+": "+cube);

        }
    }
}
