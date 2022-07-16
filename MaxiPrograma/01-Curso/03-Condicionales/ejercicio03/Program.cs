using System;

namespace ejercicio01
{
    class Program
    {
        static void Main(string[] args){
            float amount, total;
            Console.WriteLine("Enter a number : ");
            amount = int.Parse(Console.ReadLine());

            if (amount >= 5000) 
            {
               total = amount*(1-0.18F);
               Console.WriteLine("Total: "+total);
            }
            else if(amount >= 1000)
            {
                total = amount*(1-0.1F);
                Console.WriteLine("Total: "+total);
            }
            else
                Console.WriteLine("Without discount -- Total: " + amount);
        }
    }
}
