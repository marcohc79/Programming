/* 1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector. */
using System;

namespace ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vectorNumbers = new int[10];
            int num, position, maximumValue;

            /* solicito los numeros y los guardo en el vector. */
            for(int i=0; i<10; i++){
                Console.WriteLine("Enter number: ");
                vectorNumbers[i] = int.Parse(Console.ReadLine());
            }

            maximumValue = vectorNumbers[0];
            position = 0;
            for(int i=1; i<10; i++){
                if(maximumValue < vectorNumbers[i]){
                    maximumValue = vectorNumbers[i];
                    position = i + 1;
                }
            }

            Console.WriteLine("The maximum value is: " + maximumValue);
            Console.WriteLine("Position: " + position);
        }
    }
}
