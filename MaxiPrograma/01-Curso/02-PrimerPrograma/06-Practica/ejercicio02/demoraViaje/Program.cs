using System;

namespace demoraViaje
{
    class Program
    {
        static void Main(string[] args)
        {
            double km, speed, result;

            Console.WriteLine("Enter speed(km/h): ");
            speed = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter distance(km): ");
            km = double.Parse(Console.ReadLine());

            result = km / speed;

            Console.WriteLine("Time: " + result+"hs");

        }
    }
}
