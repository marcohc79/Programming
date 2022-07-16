using System;

namespace ejercicio01
{
    class Program
    {
        static void Main(string[] args){
            int number;
            Console.WriteLine("Enter your age: ");
            number = int.Parse(Console.ReadLine());

            if (number > 10)
                Console.WriteLine("It is greater than 10.");
            else
                Console.WriteLine("It is less than 10.");
        }
    }
}
