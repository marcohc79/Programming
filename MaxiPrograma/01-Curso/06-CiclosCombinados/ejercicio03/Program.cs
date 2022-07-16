/* 3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista. */

using System;

namespace ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, counter=0;

            Console.WriteLine("Enter number: ");
            num = int.Parse(Console.ReadLine());
            while (num >= 0){
                if(num == 0){
                    Console.WriteLine("The list has " + counter + " numbers.");
                    counter = -1;
                }
                Console.WriteLine("Enter number: ");
                num = int.Parse(Console.ReadLine());
                counter++;
            }
            Console.WriteLine("The list has " + counter + " numbers.");
        }
    }
}
