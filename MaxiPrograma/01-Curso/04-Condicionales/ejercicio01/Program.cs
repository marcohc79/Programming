using System;

namespace ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01, num02, result;

            Console.WriteLine("Enter number 01: ");
            num01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 02: ");
            num02 = int.Parse(Console.ReadLine());

            if (num01 > num02)
                result = num01 - num02;
            else if (num01 == num02)
                result = num01 + num02;
            else
                result = num01 * num02;

            Console.WriteLine("Result: " + result);
        }
    }
}
