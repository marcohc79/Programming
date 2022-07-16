using System;

namespace ejercicio01
{
    class Program
    {
        static void Main(string[] args){
            int num01, num02, num03, num04, max;
            
            Console.WriteLine("Enter number 01: ");
            num01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 02: ");
            num02 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 03: ");
            num03 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 04: ");
            num04 = int.Parse(Console.ReadLine());
            
            if (num01 > 100)
                Console.WriteLine("" + num01);
            if (num02 > 100)
                Console.WriteLine("" + num02);
            if (num03 > 100)
                Console.WriteLine("" + num03);
            if (num04 > 100)
                Console.WriteLine("" + num04);
        }
    }
}
