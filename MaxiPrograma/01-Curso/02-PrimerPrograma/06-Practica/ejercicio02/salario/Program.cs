using System;

namespace salario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 15000;
            double commission = 5;
            double totalSalary, charged;

            Console.WriteLine("Total charged: ");
            charged = double.Parse(Console.ReadLine());

            totalSalary = salary + ((charged*5)/100);

            Console.WriteLine("Total Salary: " + totalSalary);
        }
    }
}
