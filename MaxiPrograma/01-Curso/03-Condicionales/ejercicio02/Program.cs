using System;

namespace ejercicio01
{
    class Program
    {
        static void Main(string[] args){
            int number;
            Console.WriteLine("Enter a number : ");
            number = int.Parse(Console.ReadLine());

            if (number > 0)
                Console.WriteLine("Positive.");
            else if (number < 0)
                Console.WriteLine("Negative.");
            else
                Console.WriteLine("Equal to 0.");
        }
    }
}
