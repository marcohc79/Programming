using System;

namespace salario
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade01, grade02, grade03, average;

            Console.WriteLine("Grade 01: ");
            grade01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Grade 02: ");
            grade02 = int.Parse(Console.ReadLine());
            Console.WriteLine("Grade 03: ");
            grade03 = int.Parse(Console.ReadLine());

            average = (grade01+grade02+grade03) / 3;

            Console.WriteLine("Average: " + average);
        }
    }
}
