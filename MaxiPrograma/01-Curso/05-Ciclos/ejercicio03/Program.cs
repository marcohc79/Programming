/* 3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años. */
using System;

namespace ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            float age, average=0, cont=0;

            for(int i=0; i < 20; i++){
                Console.WriteLine("Enter age: ");
                age = int.Parse(Console.ReadLine());
                if (age >=18){
                    average += age;
                    cont ++;
                }
            }
            average = average / cont;

            Console.WriteLine("Average is: " + average);
        }
    }
}
