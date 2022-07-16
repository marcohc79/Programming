using System;

namespace ejercicio01
{
    class Program
    {
        static void Main(string[] args){
            int num01, num02, num03, num04, minimum;
            
            Console.WriteLine("Enter number 01: ");
            num01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 02: ");
            num02 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 03: ");
            num03 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 04: ");
            num04 = int.Parse(Console.ReadLine());
            
            minimum = num01;

            if (minimum > num02)
                minimum = num02;
            if (minimum > num03)
                minimum = num03;
            if (minimum > num04)
                minimum = num04;
            
            Console.WriteLine("The smallest number is: "+minimum);
        }
    }
}
