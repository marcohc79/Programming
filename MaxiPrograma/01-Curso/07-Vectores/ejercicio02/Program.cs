/* 2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio. */
using System;

namespace ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            float average;
            int biggerNumber;
            int[] numbers = new int[10];

            average = 0;
            for(int i=0; i<10; i++){
                Console.WriteLine("Enter number: ");
                numbers[i] = int.Parse(Console.ReadLine());
                average += numbers[i];
            }

            average = average/10;
            Console.WriteLine("Average: " + average);

            for(int m=0; m<10; m++){
                if(numbers[m] > average)
                    Console.WriteLine("Higher than average: " + numbers[m]);
            }
            
        }
    }
}
